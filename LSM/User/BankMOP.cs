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
    public partial class BankMOP : UserControl
    {
        public BankMOP()
        {
            InitializeComponent();
        }

        public string AccNumber
        {
            get
            {
                return txtBankNumber.Text;
            }

        }

        public string BankName
        {
            get
            {
                return txtBankName.Text;
            }
        }

        public string BankBranch
        {
            get
            {
                return txtBranch.Text;
            }
        }

        public string ChequeNumber
        {
            get
            {
                return txtChequeNumber.Text;
            }
        }

        public string ChequeDate
        {
            get
            {
                return dtpDate.Value.ToString("yyyy-MM-dd");
            }
        }

        public string ChequeAmount
        {
            get
            {
                return txtChequeAmount.Text;
            }
        }

        public bool postdated_check
        {
            get
            {
                return lblPDC.Checked;
            }
        }


    }
}
