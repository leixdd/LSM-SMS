using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class Cheque
    {
        public long bank_account_number { get; set; }

        public string bank_name { get; set; }

        public string bank_branch { get; set; }

        public long cheque_number { get; set; }

        public string cheque_date { get; set; }

        public double cheque_amount { get; set; }

        public Boolean isPostDatedCheck { get; set; }
    }
}
