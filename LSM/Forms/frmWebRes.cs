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
    public partial class frmWebRes : Form
    {

        public frmWebRes()
        {
            InitializeComponent();
        }

        private void bunifuCards1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        public Boolean viewRes(Func<bool> function) {
            return function();
        }

        private void formLoader1_Load(object sender, EventArgs e)
        {
        }

        private void frmWebRes_Shown(object sender, EventArgs e)
        {
        }
    }
}
