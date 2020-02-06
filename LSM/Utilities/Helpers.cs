using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Utilities
{
    class Helpers
    {

        public static T FindWithName<T>(string tag, Control fm) where T : Control
        {
           
            foreach (T type in fm.Controls.OfType<T>())
            {
                if (type.Name == tag)
                    return type;
            }


            return null;
        }

        public static void generate_combo_units(System.Windows.Forms.ComboBox comboUnit)
        {
            comboUnit.Items.Clear();
            foreach (var unit in Models.GlobalSettings.UNIT_LIST)
            {
                comboUnit.Items.Add(unit.unit_name);
            }

            if (comboUnit.Items.Count > 0)
            {
                comboUnit.SelectedIndex = 0;
            }
        }

        public static int unit_index(string unit)
        {
            foreach (var unit_ in Models.GlobalSettings.UNIT_LIST)
            {
                if (unit_.unit_name == unit)
                {
                    return unit_.id;
                }
            }

            return 0;
        }
    }
}
