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
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();

            this.errorList1.GetButton().Click += new System.EventHandler(this.closeBtn);
        }

        private void bunifuCards1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        private void errorList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }
        
        private void closeBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorList1_Load(object sender, EventArgs e)
        {

        }
    }
}
