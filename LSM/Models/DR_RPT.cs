using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class DR_RPT
    {
        public string dr_no { get; set; }
        public string deliverd_to { get; set; }
        public string address { get; set; }
        public string d_style { get; set; }
        public string datetime { get; set; }
        public string terms { get; set; }
        public string tin { get; set; }

        public string datetime_to_be_paid { get; set; }

        public Boolean check_empty { get; set; }
        public string updated_by { get; set; }
        public IList<DR> dr_list { get; set;  }

        public Double total_amount { get; set; }

        public Double amount_received { get; set; }

        public IList<ChequeDGV> cheque { get; set; }

    }
}
