using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class ChequeDGV : BaseTable
    {
        private long bank_account_number { get; set; }

        private string bank_name { get; set; }

        private string bank_branch { get; set; }

        private long cheque_number { get; set; }

        private string cheque_date { get; set; }

        private double cheque_amount { get; set; }

        private Boolean isPostDatedCheck { get; set; }


        public long BankAccountNumber
        {
            get { return this.bank_account_number;  }
            set {
                if (value != this.bank_account_number)
                {
                    this.bank_account_number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string BankName
        {
            get { return this.bank_name; }
            set
            {
                if (value != this.bank_name)
                {
                    this.bank_name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string BankBranch
        {
            get { return this.bank_branch; }
            set
            {
                if (value != this.bank_branch)
                {
                    this.bank_branch = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public long ChequeNumber
        {
            get { return this.cheque_number; }
            set
            {
                if (value != this.cheque_number)
                {
                    this.cheque_number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ChequeDate
        {
            get { return this.cheque_date; }
            set
            {
                if (value != this.cheque_date)
                {
                    this.cheque_date = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double ChequeAmount
        {
            get { return this.cheque_amount; }
            set
            {
                if (value != this.cheque_amount)
                {
                    this.cheque_amount = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Boolean IsPostDatedCheque
        {
            get { return this.isPostDatedCheck; }
            set
            {
                if (value != this.isPostDatedCheck)
                {
                    this.isPostDatedCheck = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
