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
    public partial class frmAddItemSetup : Form
    {
        public frmAddItemSetup()
        {
            InitializeComponent();
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
    }
}
