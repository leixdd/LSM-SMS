using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class Notifications
    {
        public DateTime date_to_be_paid { get; set; }
        public String dr_no { get; set; }
        public String customer_name { get; set; }
        public Double amount_received { get; set; }
        public Double  total_amount { get; set; }
        public int remaining_days
        {
            get; set;
        }

    }
}
