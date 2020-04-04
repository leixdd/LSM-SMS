using LSM.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Forms
{
    public partial class frmTransactions : Form
    {
        private long customer_id = 0;
        private Boolean ableToSelect = false;

        private Dictionary<long, IList<CHEQUE_MODEL>> dict_cheques = new Dictionary<long, IList<CHEQUE_MODEL>>();

        private Dictionary<long, IList<BILLING_MODEL>> dict_bills = new Dictionary<long, IList<BILLING_MODEL>>();


        private Dictionary<long, CUSTOMER_MODEL> dict_customer = new Dictionary<long, CUSTOMER_MODEL>();

        protected Models.DGV_MODEL<Models.TABLE_DELIVERIES_LIST> TABLE_MODEL_DELIVERIES = new Models.DGV_MODEL<Models.TABLE_DELIVERIES_LIST>();

        protected Models.DGV_MODEL<Models.TABLE_BILLING_MODEL> TABLE_MODEL_ITEM = new Models.DGV_MODEL<Models.TABLE_BILLING_MODEL>();

        protected Models.DGV_MODEL<Models.TABLE_BILLING_MODEL_RT> TABLE_MODEL_ITEM_RETURNED = new Models.DGV_MODEL<Models.TABLE_BILLING_MODEL_RT>();

        protected Models.DGV_MODEL<Models.ChequeDGV> TABLE_MODEL_CHEQUE = new Models.DGV_MODEL<Models.ChequeDGV>();
        
        public frmTransactions()
        {
            InitializeComponent();

            dgvDeliveries.DataSource = new BindingSource(TABLE_MODEL_DELIVERIES.get_model, null);
            dgvChequeList.DataSource = new BindingSource(TABLE_MODEL_CHEQUE.get_model, null);

            dgvBilling.DataSource = new BindingSource(TABLE_MODEL_ITEM.get_model, null);

            dgvRTI.DataSource = new BindingSource(TABLE_MODEL_ITEM_RETURNED.get_model, null);

            TABLE_MODEL_CHEQUE.get_model.ResetBindings();
            TABLE_MODEL_DELIVERIES.get_model.ResetBindings();
            TABLE_MODEL_ITEM.get_model.ResetBindings();
            TABLE_MODEL_ITEM_RETURNED.get_model.ResetBindings();
        }

        public void setCustomerID(long id)
        {
            this.customer_id = id;
        }
        
        private void load_deliveries()
        {
            TABLE_MODEL_DELIVERIES.get_list.Clear();
            TABLE_MODEL_DELIVERIES.get_model.ResetBindings();

            dict_cheques.Clear();
            dict_bills.Clear();
            dict_customer.Clear();


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
                            dict_customer.Add(item.id, item.customer);

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
            TABLE_MODEL_ITEM_RETURNED.get_list.Clear();

            foreach (BILLING_MODEL item in items)
            {

                if (item.isReturned == 0)
                {
                    TABLE_MODEL_ITEM.get_list.Add(new Models.TABLE_BILLING_MODEL
                    {
                        Amount = item.amount,
                        DRBind = item.dr_trans_no,
                        ID = item.id,
                        ItemID = item.item_id,
                        Name = item.item.item_name,
                        Quantity = item.quantity,
                        Size = item.item.item_size,
                        isReturned = item.isReturned
                    });
                }
                else {
                    TABLE_MODEL_ITEM_RETURNED.get_list.Add(new Models.TABLE_BILLING_MODEL_RT
                    {
                        Amount = item.amount,
                        DRBind = item.dr_trans_no,
                        ID = item.id,
                        ItemID = item.item_id,
                        Name = item.item.item_name,
                        Quantity = item.quantity,
                        Size = item.item.item_size,
                        isReturned = item.isReturned
                    });
                }
            }


            TABLE_MODEL_ITEM.get_model.ResetBindings();
            TABLE_MODEL_ITEM_RETURNED.get_model.ResetBindings();
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
            public int isReturned { get; set; }

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
            if (dgvDeliveries.Rows.Count > 0 && dgvDeliveries.SelectedRows.Count > 0)
            {
                dtpDueDate.Value = DateTime.Parse(dgvDeliveries.SelectedRows[0].Cells["DueDate"].Value.ToString());
                dtpDate.Value = DateTime.Parse(dgvDeliveries.SelectedRows[0].Cells["Date"].Value.ToString());
                txtAmountReceived.Text = dgvDeliveries.SelectedRows[0].Cells["AmountReceived"].Value.ToString();
                txtDeliveryAmount.Text = dgvDeliveries.SelectedRows[0].Cells["TotalAmount"].Value.ToString();

                dgvBilling.Columns["DRBind"].Visible = false;
                dgvBilling.Columns["ItemID"].Visible = false;
                dgvBilling.Columns["ID"].Visible = false;
                dgvBilling.Columns["Amount"].DefaultCellStyle.Format = "N2";

                try
                {
                    this.load_cheques(dict_cheques[(long)dgvDeliveries.SelectedRows[0].Cells["ID"].Value]);
                    this.load_charages(dict_bills[(long)dgvDeliveries.SelectedRows[0].Cells["ID"].Value]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CUSTOMER_MODEL cm = dict_customer[(long)dgvDeliveries.SelectedRows[0].Cells["ID"].Value];

            Models.Exportables.frmReport rpt = new Models.Exportables.frmReport();
            //rpt.setDS(TABLE_MODEL_ITEM.get_list, cm.customer_name, cm.company_name, cm.contact_number, cm.company_address, dgvDeliveries.SelectedRows[0].Cells["TotalAmount"].Value.ToString());
            rpt.ShowDialog();
        }

        private void dgvBilling_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void btnItem_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgvBilling_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                this.dgvBilling.Rows[e.RowIndex].Selected = true;
                Rectangle rect = this.dgvBilling.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cntBilling.Show((Control)sender, rect.Left + e.X, rect.Top + e.Y);
            }
        }

        private void setAsAReturnedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tbl = this.dgvBilling.SelectedRows[0];

            DialogResult user_ = MessageBox.Show(this, "Are you sure you want to send this item to <returned items>? [ " + tbl.Cells["Name"].Value + " ] ", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);

            if (user_ != DialogResult.No)
            {

                var f = new {
                    bindID = tbl.Cells["ID"].Value,
                    rtStatus = 1
                };

                HttpServer.Post(Routes.R_CUSTOMERS_ITEM_RETURN, new StringContent(JsonConvert.SerializeObject(f), Encoding.UTF8, "application/json"), (passed, results) =>
                {

                    if (passed)
                    {

                        if (bool.Parse(results.success))
                        {
                            frmSuccess success = new frmSuccess();
                            success.setDesc(results.data.ToString());
                            success.ShowDialog();
                            this.TABLE_MODEL_CHEQUE.get_list.Clear();
                            this.TABLE_MODEL_CHEQUE.get_model.ResetBindings();
                            this.TABLE_MODEL_ITEM.get_list.Clear();
                            this.TABLE_MODEL_ITEM.get_model.ResetBindings();
                            this.TABLE_MODEL_ITEM_RETURNED.get_list.Clear();
                            this.TABLE_MODEL_ITEM_RETURNED.get_model.ResetBindings();

                            this.load_deliveries();

                            return true;
                        }

                        frmError _error = new frmError();
                        var data_ = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(results.data.ToString());
                        foreach (String control in data_.Keys)
                        {
                            _error.errorList1.addError(String.Join(",", data_[control]));
                        }

                        _error.Show();


                        return false;
                    }

                    return false;
                });

            }




        }

        private void bringBackToBillingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tbl = this.dgvRTI.SelectedRows[0];

            DialogResult user_ = MessageBox.Show(this, "Are you sure you want to bring back this item to <billing items>? [ " + tbl.Cells["Name"].Value + " ] ", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);

            if (user_ != DialogResult.No)
            {

                var f = new
                {
                    bindID = tbl.Cells["ID"].Value,
                    rtStatus = 0
                };

                HttpServer.Post(Routes.R_CUSTOMERS_ITEM_RETURN, new StringContent(JsonConvert.SerializeObject(f), Encoding.UTF8, "application/json"), (passed, results) =>
                {

                    if (passed)
                    {

                        if (bool.Parse(results.success))
                        {
                            frmSuccess success = new frmSuccess();
                            success.setDesc(results.data.ToString());
                            success.ShowDialog();
                            this.TABLE_MODEL_CHEQUE.get_list.Clear();
                            this.TABLE_MODEL_CHEQUE.get_model.ResetBindings();
                            this.TABLE_MODEL_ITEM.get_list.Clear();
                            this.TABLE_MODEL_ITEM.get_model.ResetBindings();
                            this.TABLE_MODEL_ITEM_RETURNED.get_list.Clear();
                            this.TABLE_MODEL_ITEM_RETURNED.get_model.ResetBindings();

                            this.load_deliveries();

                            return true;
                        }

                        frmError _error = new frmError();
                        var data_ = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(results.data.ToString());
                        foreach (String control in data_.Keys)
                        {
                            _error.errorList1.addError(String.Join(",", data_[control]));
                        }

                        _error.Show();


                        return false;
                    }

                    return false;
                });

            }
        }

        private void dgvRTI_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                this.dgvRTI.Rows[e.RowIndex].Selected = true;
                Rectangle rect = this.dgvRTI.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cntRT.Show((Control)sender, rect.Left + e.X, rect.Top + e.Y);
            }
        }

        private void btnPrintDR_Click(object sender, EventArgs e)
        {
            if (dgvDeliveries.Rows.Count > 0)
            {
                CUSTOMER_MODEL cm = dict_customer[(long)dgvDeliveries.SelectedRows[0].Cells["ID"].Value];

                Models.Exportables.frmReport rpt = new Models.Exportables.frmReport();
                Double totalAmount = 0;

                foreach (Models.TABLE_DELIVERIES_LIST dev in TABLE_MODEL_DELIVERIES.get_list)
                {
                    totalAmount += dev.TotalAmount;
                }

                String tA = totalAmount.ToString("C", CultureInfo.CurrentCulture);
                rpt.setDS(TABLE_MODEL_DELIVERIES.get_list, cm.customer_name, cm.company_name, cm.contact_number, cm.company_address, tA);
                rpt.ShowDialog();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvDeliveries.Rows.Count > 0)
            {
                CUSTOMER_MODEL cm = dict_customer[(long)dgvDeliveries.SelectedRows[0].Cells["ID"].Value];

                Models.Exportables.frmDRSIZE rpt = new Models.Exportables.frmDRSIZE();
                    //new Models.Exportables.frmReportDR();

                var dr_mod = new List<Models.DR>();

                foreach (Models.TABLE_BILLING_MODEL tb in TABLE_MODEL_ITEM.get_list)
                {
                    dr_mod.Add(new Models.DR
                    {
                        Amount = tb.Amount.ToString(),
                        Item = tb.Name,
                        ItemID = (int) tb.ItemID,
                        Quantity = tb.Quantity,
                        Size = tb.Size,
                    });
                }

                //rpt.setDS(dr_mod, cm.customer_name, cm.company_address,
                //    Double.Parse(dgvDeliveries.SelectedRows[0].Cells["TotalAmount"].Value.ToString()),
                //    dgvDeliveries.SelectedRows[0].Cells["DRNo"].Value.ToString(),
                //    DateTime.Parse(dgvDeliveries.SelectedRows[0].Cells["Date"].Value.ToString()).ToLongDateString(),
                //    DateTime.Parse(dgvDeliveries.SelectedRows[0].Cells["DueDate"].Value.ToString()).ToLongDateString());
                //rpt.ShowDialog();

                rpt.setDS(dr_mod, cm.customer_name, 
                    dgvDeliveries.SelectedRows[0].Cells["DRNo"].Value.ToString(),
                    DateTime.Parse(dgvDeliveries.SelectedRows[0].Cells["Date"].Value.ToString()).ToShortDateString());
                rpt.ShowDialog();
            }
        }
        
    }
}
