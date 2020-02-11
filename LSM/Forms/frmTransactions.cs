using LSM.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Forms
{
    public partial class frmTransactions : Form
    {
        private long customer_id = 0;

        private Dictionary<long, IList<CHEQUE_MODEL>> dict_cheques = new Dictionary<long, IList<CHEQUE_MODEL>>();

        private Dictionary<long, IList<BILLING_MODEL>> dict_bills = new Dictionary<long, IList<BILLING_MODEL>>();

        protected Models.DGV_MODEL<Models.TABLE_DELIVERIES_LIST> TABLE_MODEL_DELIVERIES = new Models.DGV_MODEL<Models.TABLE_DELIVERIES_LIST>();

        protected Models.DGV_MODEL<Models.TABLE_BILLING_MODEL> TABLE_MODEL_ITEM = new Models.DGV_MODEL<Models.TABLE_BILLING_MODEL>();

        protected Models.DGV_MODEL<Models.ChequeDGV> TABLE_MODEL_CHEQUE = new Models.DGV_MODEL<Models.ChequeDGV>();

        public frmTransactions()
        {
            InitializeComponent();

            dgvDeliveries.DataSource = new BindingSource(TABLE_MODEL_DELIVERIES.get_model, null);
            dgvChequeList.DataSource = new BindingSource(TABLE_MODEL_CHEQUE.get_model, null);
            dgvBilling.DataSource = new BindingSource(TABLE_MODEL_ITEM.get_model, null);

            TABLE_MODEL_CHEQUE.get_model.ResetBindings();
            TABLE_MODEL_DELIVERIES.get_model.ResetBindings();
            TABLE_MODEL_ITEM.get_model.ResetBindings();
        }

        public void setCustomerID(long id)
        {
            this.customer_id = id;
        }
        
        private void load_deliveries()
        {
            HttpServer.Get(Utilities.Routes.R_CUSTOMERS_DELIVERY_HISTORY + this.customer_id.ToString(), (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var main_result = JsonConvert.DeserializeObject<List<MAIN_MODEL>>(results.data.ToString());

                        foreach (MAIN_MODEL item in main_result)
                        {
                            var model = new Models.TABLE_DELIVERIES_LIST
                            {
                                Address = item.address,
                                AmountReceived = item.amount_received,
                                Date = item.date,
                                DeliveredTo = item.customer.customer_name,
                                DeliveryStyle = item.delivery_style,
                                DRNo = item.dr_no,
                                DueDate = item.date_to_be_paid,
                                ID = item.id,
                                Terms = item.terms,
                                Tin = item.tin,
                                TotalAmount = item.total_amount,
                                UpdatedBy = item.user.name
                            };


                            dict_cheques.Add(item.id, item.bank_transactions);
                            dict_bills.Add(item.id, item.billing_items);

                            TABLE_MODEL_DELIVERIES.get_list.Add(model);
                        }

                        TABLE_MODEL_DELIVERIES.get_model.ResetBindings();

                        resetDGV();

                        return true;
                    }

                    return false;
                }

                return false;
            });
        }

        private void load_cheques(IList<CHEQUE_MODEL> cheques)
        {
            TABLE_MODEL_CHEQUE.get_list.Clear();

            foreach (CHEQUE_MODEL cheque in cheques)
            {
                var c_model = new Models.ChequeDGV
                {
                    BankAccountNumber = cheque.bank_account_number,
                    BankBranch = cheque.bank_branch,
                    BankName = cheque.bank_name,
                    ChequeAmount = cheque.cheque_amount,
                    ChequeDate = cheque.cheque_date.ToLongDateString(),
                    ChequeNumber = cheque.cheque_number,
                    IsPostDatedCheque = cheque.isPostDateCheque

                };

                TABLE_MODEL_CHEQUE.get_list.Add(c_model);

            }


            TABLE_MODEL_CHEQUE.get_model.ResetBindings();
        }

        private void load_charages(IList<BILLING_MODEL> items)
        {
            TABLE_MODEL_ITEM.get_list.Clear();

            foreach (BILLING_MODEL item in items)
            {
                var i_model = new Models.TABLE_BILLING_MODEL
                {
                    Amount = item.amount,
                    DRBind = item.dr_trans_no,
                    ID = item.id,
                    ItemID = item.item_id,
                    Name = item.item.item_name,
                    Quantity = item.quantity,
                    Size = item.item.item_size
                };

                TABLE_MODEL_ITEM.get_list.Add(i_model);

            }


            TABLE_MODEL_ITEM.get_model.ResetBindings();
        }

        private void resetDGV()
        {
            this.dgvDeliveries.Columns["ID"].Visible = false;
            this.dgvDeliveries.Columns["Address"].Visible = false;
            this.dgvDeliveries.Columns["UpdatedBy"].Visible = false;
            this.dgvDeliveries.Columns["Tin"].Visible = false;
            this.dgvDeliveries.Columns["Terms"].Visible = false;
            this.dgvDeliveries.Columns["DeliveryStyle"].Visible = false;
            this.dgvDeliveries.Columns["DeliveredTo"].Visible = false;
            this.dgvDeliveries.Columns["Date"].Visible = false;
            this.dgvDeliveries.Columns["DueDate"].Visible = false;
            this.dgvDeliveries.Columns["AmountReceived"].DefaultCellStyle.Format = "N2";
            this.dgvDeliveries.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Models.GlobalSettings.main_screen.mdi_module_load(new frmCustomer());
        }

        class MAIN_MODEL
        {

            public long id { get; set; }
            public string dr_no { get; set; }
            public string deliverd_to { get; set; }
            public string address { get; set; }
            public string delivery_style { get; set; }
            public string date { get; set; }
            public string terms { get; set; }
            public string tin { get; set; }

            public string date_to_be_paid { get; set; }
            public string updated_by { get; set; }
            public Double total_amount { get; set; }
            public Double amount_received { get; set; }

            public CUSTOMER_MODEL customer { get; set; }
            public USER_MODEL user { get; set; }

            public IList<CHEQUE_MODEL> bank_transactions { get; set; }
            public IList<BILLING_MODEL> billing_items { get; set; }
        }

        class USER_MODEL
        {
            public long id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
        }

        class CUSTOMER_MODEL
        {
            public long id { get; set; }
            public string customer_name { get; set; }
            public string company_name { get; set; }
            public string contact_number { get; set; }
            public string email { get; set; }
            public string company_address { get; set; }
        }

        class BILLING_MODEL
        {
            public long id { get; set; }
            public long dr_trans_no { get; set; }
            public long item_id { get; set; }
            public int quantity { get; set; }
            public double amount { get; set; }
            public ITEM_MODEL item { get; set; }
        }

        class ITEM_MODEL
        {
            public long id { get; set; }
            public string item_name { get; set; }
            public double item_cost { get; set; }
            public string item_size { get; set; }
        }

        class CHEQUE_MODEL
        {
            public long id { get; set; }
            public long bank_account_number { get; set; }
            public string bank_name { get; set; }
            public string bank_branch { get; set; }
            public long cheque_number { get; set; }
            public DateTime cheque_date { get; set; }
            public double cheque_amount { get; set; }
            public Boolean isPostDateCheque { get; set; }
            
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            this.load_deliveries();
        }

        private void dgvDeliveries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDeliveries_SelectionChanged(object sender, EventArgs e)
        {
            dtpDueDate.Value = DateTime.Parse(dgvDeliveries.SelectedRows[0].Cells["DueDate"].Value.ToString());
            dtpDate.Value = DateTime.Parse(dgvDeliveries.SelectedRows[0].Cells["Date"].Value.ToString());
            txtAmountReceived.Text = dgvDeliveries.SelectedRows[0].Cells["AmountReceived"].Value.ToString();
            txtDeliveryAmount.Text = dgvDeliveries.SelectedRows[0].Cells["TotalAmount"].Value.ToString();

            this.load_cheques(dict_cheques[(long) dgvDeliveries.SelectedRows[0].Cells["ID"].Value]);
            this.load_charages(dict_bills[(long)dgvDeliveries.SelectedRows[0].Cells["ID"].Value]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Models.Exportables.frmReport rpt = new Models.Exportables.frmReport();
            rpt.ShowDialog();
        }
    }
}
