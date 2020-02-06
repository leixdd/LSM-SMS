using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class ReportTemplate
    {
        public string template_name { get; set; }

        public string template_route { get; set; }

        public IReport template_class { get; set; }
    }
}
