using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSM.Utilities;

namespace LSM.Models
{
    public class GlobalSettings
    {
        public static IList<Models.Unit> UNIT_LIST = new List<Models.Unit>();
        public static IList<Models.Notifications> Notifications = new List<Models.Notifications>();

        public static User CURRENT_USER = new User();

        public static List<IReport> REPORTS = new List<IReport>
        {
                new Models.Report_Templates.RPT_SalesTransactions{ route = Routes.R_SALES_REPORTS_LIST_SALES, RPT_NAME = "Generate Sales List" }
        };

        public static frmMain_Screen main_screen;
        public static System.Windows.Forms.Form pastScreen;

        //Current Selection ID
        public static int Selection_Item_ID = 0;

        public static int Selection_II_ID = 0;
    }
}
