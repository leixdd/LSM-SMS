using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class Unit
    {
        public int id { get; set; }
        public string unit_name { get; set; }
        public string unit_short_code { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}
