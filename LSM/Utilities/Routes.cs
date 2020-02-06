using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using config = LSM.Utilities.Configurations;

namespace LSM.Utilities
{
    class Routes
    {
        protected static string SERVERHOST = config.Server().secured + "://" + config.Server().host + ":" + config.Server().port;

        //Auth
        public static String R_LOGIN = SERVERHOST + "/api/account/login";
        
        //DR
        public static String R_DR_SAVE = SERVERHOST + "/api/dr/save";

        //Units
        public static String R_UNITS = SERVERHOST + "/api/units";

        //SI
        public static String R_SALES_SAVE = SERVERHOST + "/api/sales/save";
        public static String R_SALES_REPORTS_LIST_SALES = SERVERHOST + "/api/sales/reports/sales";

        //ITEMS
        public static String R_ITEMS_SAVE = SERVERHOST + "/api/items/save";
        public static String R_ITEMS_LIST = SERVERHOST + "/api/items/";
        public static String R_ITEMS_DELETE = SERVERHOST + "/api/items/remove/";


    }
}
