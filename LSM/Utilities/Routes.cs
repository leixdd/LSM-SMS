﻿using System;
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
        public static String R_SALES_DASHBOARD = SERVERHOST + "/api/sales/reports/ncg";

        //ITEMS
        public static String R_ITEMS_SAVE = SERVERHOST + "/api/items/save";
        public static String R_ITEMS_LIST = SERVERHOST + "/api/items/";
        public static String R_ITEMS_EDIT = SERVERHOST + "/api/items/edit/";
        public static String R_ITEMS_DELETE = SERVERHOST + "/api/items/remove/";

        //Customers
        public static String R_CUSTOMERS = SERVERHOST + "/api/customers";
        public static String R_CUSTOMERS_BIND_ITEM = SERVERHOST + "/api/customers/bindItem";
        public static String R_CUSTOMERS_BIND_ITEM_GET = SERVERHOST + "/api/customers/bindItems/";
        
        public static String R_CUSTOMERS_BIND_ITEM_UPDATE = SERVERHOST + "/api/customers/editBindItem";

        public static String R_CUSTOMERS_DELIVERY_HISTORY = SERVERHOST + "/api/customers/deliveries/";
        public static String R_CUSTOMERS_ITEM_RETURN = SERVERHOST + "/api/customers/setToReturn";

        public static String R_UNBOUND_ITEM = SERVERHOST + "/api/customers/removeBindItem/";


        public static String R_NOTIFICATIONS = SERVERHOST + "/api/sales/reports/notifications";
    }
}
