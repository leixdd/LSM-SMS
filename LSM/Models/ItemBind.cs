using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class ItemBind
    {
        public int item_id { get; set; }
        public int customer_id { get; set; }
        public double selling_price { get; set; }
        public double discount { get; set; }
    }
}
