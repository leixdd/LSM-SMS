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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCards2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmError _error = new frmError();

            var rp_prep = new Models.Customer
            {
                CompanyAddress = txtCompanyAddress.Text,
                CompanyName = txtCompanyName.Text,
                ContactNumber = txtContactNumber.Text,
                Email = txtEmailAddress.Text,
                Name = txtCustomerName.Text
            };

            HttpServer.Post(Routes.R_CUSTOMERS, new StringContent(JsonConvert.SerializeObject(rp_prep), Encoding.UTF8, "application/json"), (passed, results) =>
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

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
