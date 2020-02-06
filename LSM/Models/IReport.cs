using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Models
{
    public interface IReport
    {
        void generate_report();

        string report_name();

        BindingSource dgv { get; }
    }
}
