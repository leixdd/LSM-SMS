using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSM.Utilities;
using Newtonsoft.Json;
using System.Net.Http;

namespace LSM.Forms
{
    public partial class frmItemList : Form
    {
        protected Models.DGV_MODEL<Models.TABLE_ITEM_LIST> TABLE_MODEL = new Models.DGV_MODEL<Models.TABLE_ITEM_LIST>();

        protected class JSON_DEF_MODEL
        {
            public long item_id { get; set; }
            public string item_name { get; set; }
            public double item_cost { get; set; }
            public string item_size { get; set; }
        }

        public frmItemList()
        {
            InitializeComponent();
            //Helpers.generate_combo_units(comboUnit);
            dgvDeliveryItems.DataSource = new BindingSource(TABLE_MODEL.get_model, null);
            TABLE_MODEL.get_model.ResetBindings();
            this.generate_data();
        }

        protected void generate_data() 
        {
            TABLE_MODEL.get_list.Clear();

            HttpServer.Get(Utilities.Routes.R_ITEMS_LIST, (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<JSON_DEF_MODEL>>(results.data.ToString());

                        foreach (JSON_DEF_MODEL item in rs_object) {
                            TABLE_MODEL.get_list.Add(new Models.TABLE_ITEM_LIST
                            {
                                Cost = item.item_cost,
                                ID = item.item_id,
                                Name = item.item_name,
                                Size = item.item_size.ToString() //TODO
                            });
                        }

                        TABLE_MODEL.get_model.ResetBindings();

                        return true;
                    }

                    return false;
                }

                return false;
            });
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.submit();
        }

        private void submit ()
        {
            try
            {
                var item_request = new Models.JSON_ITEM_MODEL
                {
                    item_cost = Double.Parse(numUnitPrice.Value.ToString()),
                    item_name = txtItemName.Text,
                    item_size = txtItemSize.Text
                };


                HttpServer.Post(Routes.R_ITEMS_SAVE, new StringContent(JsonConvert.SerializeObject(item_request), Encoding.UTF8, "application/json"), (passed, results) =>
                {
                    if (passed)
                    {

                        if (!bool.Parse(results.success))
                        {
                            frmError _error = new frmError();
                            var data_ = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(results.data.ToString());
                            foreach (String control in data_.Keys)
                            {
                                _error.errorList1.addError(String.Join(",", data_[control]));
                            }

                            _error.Show();


                            return false;
                        }

                        frmSuccess success = new frmSuccess();
                        success.setDesc(results.data.ToString());
                        success.ShowDialog();

                        generate_data();


                    }
                    return false;
                });


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDeliveryItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult user_ = MessageBox.Show(this, "Are you sure you want to delete this item? [ " + e.Row.Cells["Name"].Value + " ]", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);

            if (user_ == DialogResult.No) {
                e.Cancel = true;
            }



            HttpServer.Post(Routes.R_ITEMS_DELETE + e.Row.Cells["ID"].Value, new StringContent("[]", Encoding.UTF8, "application/json"), (passed, results) =>
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

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.submit();
            }
        }
    }
}
