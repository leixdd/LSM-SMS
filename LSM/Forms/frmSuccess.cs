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
    public partial class frmSuccess : Form
    {
        public frmSuccess()
        {
            InitializeComponent();
        }

        public void setDesc(String desc)
        {
            lblDesc.Text = desc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCards1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }
    }
}
