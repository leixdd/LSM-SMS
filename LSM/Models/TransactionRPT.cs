using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class TransactionRPT
    {
        public string trans_no { get; set; }
        public string sold_to { get; set; }
        public string address { get; set; }
        public string b_style { get; set; }
        public string datetime { get; set; }
        public string terms { get; set; }
        public string po { get; set; }
        public string updated_by { get; set; }
        public IList<DR> item_list { get; set;  }
    }
}
