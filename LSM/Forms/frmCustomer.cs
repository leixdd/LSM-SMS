using LSM.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Forms
{

    public partial class frmCustomer : Form
    {
        private List<rDF> list_object;

        protected Models.DGV_MODEL<Models.TABLE_ITEM_BIND_LIST> TABLE_MODEL = new Models.DGV_MODEL<Models.TABLE_ITEM_BIND_LIST>();

        protected List<Models.TABLE_ITEM_BIND_LIST> temp_list = new List<Models.TABLE_ITEM_BIND_LIST>();
        

        public frmCustomer()
        {
            InitializeComponent();

            this.listAllCustomers();

            dgvDeliveryItems.DataSource = new BindingSource(TABLE_MODEL.get_model, null);
            TABLE_MODEL.get_model.ResetBindings();
        }

        private void listAllCustomers()
        {

            lstCustomers.Items.Clear();

            HttpServer.Get(Utilities.Routes.R_CUSTOMERS, (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<rDF>>(results.data.ToString());
                        list_object = rs_object;
                        foreach (var data in rs_object)
                        {
                            lstCustomers.Items.Add(data.customer_name + " - " + data.company_name);
                        }

                        lstCustomers.SelectedIndex = 0;
                        return true;
                    }

                    return false;
                }

                return false;
            });

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.ShowDialog();
            this.listAllCustomers();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _id = list_object[lstCustomers.SelectedIndex].id;
            frmAddItemSetup frm = new frmAddItemSetup();
            frm.setCID(_id);
            frm.ShowDialog();
            this.getBinds(_id);
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
            var item = list_object[lstCustomers.SelectedIndex];
            txtCompanyAddress.Text = item.company_address;
            txtCompanyName.Text = item.company_name;
            txtContactNumber.Text = item.contact_number;
            txtCustomerName.Text = item.customer_name;
            txtEmailAddress.Text = item.email;

            this.getBinds(item.id);

        }
           
        protected class JSON_DEF_MODEL
        {
            public long id;
            public string item_name;
            public string item_size;
            public double selling_price;
            public double discount;
        }

        private void getBinds(int id)
        {
            TABLE_MODEL.get_model.Clear();
            this.Enabled = false;

            HttpServer.Get(Utilities.Routes.R_CUSTOMERS_BIND_ITEM_GET + id.ToString(), (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<JSON_DEF_MODEL>>(results.data.ToString());

                        foreach (JSON_DEF_MODEL item in rs_object)
                        {
                            var model = new Models.TABLE_ITEM_BIND_LIST
                            {
                                BindID = item.id,
                                Discount = item.discount,
                                ItemName = item.item_name,
                                Size = item.item_size,
                                FinalPrice = (item.selling_price - (item.selling_price * (item.discount / 100) )),
                                SellingPrice = item.selling_price
                            };

                            TABLE_MODEL.get_list.Add(model);
                            temp_list.Add(model);

                        }

                        TABLE_MODEL.get_model.ResetBindings();

                        //resetDGV();

                        this.Enabled = true;
                        return true;
                    }

                    this.Enabled = true;
                    return false;
                }

                this.Enabled = true;
                return false;
            });

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmTransactions transaction_frm = new frmTransactions();
            var _id = list_object[lstCustomers.SelectedIndex].id;
            transaction_frm.setCustomerID(_id);

            Models.GlobalSettings.pastScreen = this;
            Models.GlobalSettings.main_screen.mdi_module_load(transaction_frm);
        }

        private void dgvDeliveryItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult user_ = MessageBox.Show(this, "Are you sure you want to unbound this item? [ " + e.Row.Cells["ItemName"].Value + " ] to customer's item list? ", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);

            if (user_ == DialogResult.No)
            {
                e.Cancel = true;
            }
            else { 

                HttpServer.Post(Routes.R_UNBOUND_ITEM + e.Row.Cells["BindID"].Value, new StringContent("[]", Encoding.UTF8, "application/json"), (passed, results) =>
                {

                    if (passed)
                    {

                        if (bool.Parse(results.success))
                        {
                            frmSuccess success = new frmSuccess();
                            success.setDesc(results.data.ToString());
                            success.ShowDialog();
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

        private void cntxSetup_Opening(object sender, CancelEventArgs e)
        {

        }

        private void removeThisItemToolStripMenuItem_Click(object sender, EventArgs ex)
        {
            var e = this.dgvDeliveryItems.SelectedRows[0];
            DialogResult user_ = MessageBox.Show(this, "Are you sure you want to unbound this item? [ " + e.Cells["ItemName"].Value + " ] to customer's item list? ", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);

            if (user_ != DialogResult.No)
            {
                HttpServer.Post(Routes.R_UNBOUND_ITEM + e.Cells["BindID"].Value, new StringContent("[]", Encoding.UTF8, "application/json"), (passed, results) =>
                {

                    if (passed)
                    {

                        if (bool.Parse(results.success))
                        {
                            frmSuccess success = new frmSuccess();
                            success.setDesc(results.data.ToString());
                            success.ShowDialog();
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

        private void dgvDeliveryItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            {
                this.dgvDeliveryItems.Rows[e.RowIndex].Selected = true;
                Rectangle rect = dgvDeliveryItems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cntxSetup.Show((Control)sender, rect.Left + e.X, rect.Top + e.Y);
            }
        }

        private void editThisItemToolStripMenuItem_Click(object sender, EventArgs ex)
        {
            
            var e = this.dgvDeliveryItems.SelectedRows[0];
            frmEditItemSetup editItem = new frmEditItemSetup();
            editItem.bind_id = (long) e.Cells["BindID"].Value;
            editItem.item_name = e.Cells["ItemName"].Value.ToString();
            editItem.item_selling = Decimal.Parse(e.Cells["SellingPrice"].Value.ToString());
            editItem.item_size = e.Cells["Size"].Value.ToString();
            editItem.item_discount = Decimal.Parse(e.Cells["Discount"].Value.ToString());
            editItem.ShowDialog();
        }

        private void dgvDeliveryItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
             
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }

    class rDF
    {
        public int id { get; set; }
        public string customer_name { get; set; }
        public string company_name { get; set; }
        public string contact_number { get; set; }
        public string email { get; set; }
        public string company_address { get; set; }
    }


}
