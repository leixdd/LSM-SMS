using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class RP
    {
        public TransactionRPT transact_items { get; set; }

        public Double total_amount { get; set; }

        public Double amount_received { get; set; }

        public IList<ChequeDGV> cheque { get; set; }

        public Boolean check_empty { get; set; }
    }
}
