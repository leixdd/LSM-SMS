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
    public partial class frmAddItemSetup : Form
    {
        private int customer_id;
        private int item_id_;

        public frmAddItemSetup()
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
            frmSearchItem si = new frmSearchItem(new Models.Selection_Model
            {
                control = new List<Control> { txtItem, numIC, txtItemSize, numSP },
                ID = 0
            });
            si.ShowDialog();
            this.setFP();
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

            var rp_prep = new Models.ItemBind
            {
                item_id = Models.GlobalSettings.Selection_II_ID,
                customer_id = this.customer_id,
                discount = (Double) numDiscount.Value,
                selling_price = (Double) numSP.Value
            };

            HttpServer.Post(Routes.R_CUSTOMERS_BIND_ITEM, new StringContent(JsonConvert.SerializeObject(rp_prep), Encoding.UTF8, "application/json"), (passed, results) =>
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
    }
}
