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


        protected Models.DGV_MODEL<Models.TABLE_DELIVERIES_LIST> TABLE_MODEL_DELIVERIES = new Models.DGV_MODEL<Models.TABLE_DELIVERIES_LIST>();

        protected Models.DGV_MODEL<Models.ChequeDGV> TABLE_MODEL_CHEQUE = new Models.DGV_MODEL<Models.ChequeDGV>();

        public frmTransactions()
        {
            InitializeComponent();
        }

        public void setCustomerID(long id)
        {
            this.customer_id = id;
        }
        
        private void load_deliveries()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Models.GlobalSettings.main_screen.mdi_module_load(new frmCustomer());
        }
    }
}
