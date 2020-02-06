using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.User
{
    public partial class ErrorList : UserControl
    {
       
        public ErrorList()
        {
            InitializeComponent();
        }

        public void addError(String error)
        {
            lstError.Items.Add(error);
        }
        
        public Button GetButton()
        {
            return this.btnClose;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
