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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();

            this.listAllCustomers();
        }

        private void listAllCustomers()
        {
            HttpServer.Get(Utilities.Routes.R_CUSTOMERS, (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<Models.Customer>>(results.data.ToString());
                        foreach (var data in rs_object)
                        {
                            Console.WriteLine(data.ContactNumber);
                        }

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddItemSetup frm = new frmAddItemSetup();
            frm.ShowDialog();
        }
    }
}
