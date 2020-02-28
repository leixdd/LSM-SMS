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
    public partial class frmEditItemSetup : Form
    {
        private int customer_id;
        public long bind_id { get; set; }
        public string item_name { get; set; }
        public string item_size { get; set; }
        public decimal item_selling { get; set; }
        public decimal item_discount { get; set; }

        public frmEditItemSetup()
        {
            InitializeComponent();
        }

        public void setCID(int cid)
        {
            this.customer_id = cid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItem_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void bunifuCards2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        private void numSP_ValueChanged(object sender, EventArgs e)
        {
            this.setFP();
        }

        protected void setFP()
        {
            numFP.Value = numSP.Value - (numSP.Value * (numDiscount.Value / 100));
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {

            this.setFP();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmError _error = new frmError();

            var rp_prep = new 
            {
                bindID = bind_id,
                discount = (Double) numDiscount.Value,
                selling_price = (Double) numSP.Value
            };

            HttpServer.Post(Routes.R_CUSTOMERS_BIND_ITEM_UPDATE, new StringContent(JsonConvert.SerializeObject(rp_prep), Encoding.UTF8, "application/json"), (passed, results) =>
            {
                if (passed)
                {

                    if (!bool.Parse(results.success))
                    {
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



                    this.Close();
                }
                return false;
            });

        }

        private void frmEditItemSetup_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmEditItemSetup_Shown(object sender, EventArgs e)
        {

            txtItem.Text = item_name;
            txtItemSize.Text = item_size;
            numDiscount.Value = item_discount;
            numSP.Value = item_selling;

            this.setFP();
        }
    }
}
