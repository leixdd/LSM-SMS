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
    public partial class frmSetDR : Form
    {
        private Boolean isDR = true;
        public frmSetDR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DRSet();
        }

        protected void DRSet()
        {
            try
            {
                if (this.isDR)
                {
                    Forms.frmDR.DRNO_Value = long.Parse(txtDRNumber.Text);
                }
                else
                {
                    Forms.frmSales.TRANSACTION_NUMBER = long.Parse(txtDRNumber.Text);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void txtDRNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DRSet();
            }
        }

        public void setLabelTitle(String label, byte mod = 0)
        {
            this.isDR = mod == 0;
            var title_command = "Set " + label;
            this.Text = title_command;
            this.button1.Text = title_command;
            this.label1.Text = label;
        }
    }
}
