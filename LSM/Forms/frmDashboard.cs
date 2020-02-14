using LSM.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            list_dash();
        }

        class JSON_DEF_MODEL
        {
            public double cost { get; set; }
            public double gross_sales { get; set; }
            public double net_sales { get; set; }
            public double increase { get; set; }
        }

        private void list_dash()
        {
            HttpServer.Get(Utilities.Routes.R_SALES_DASHBOARD, (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<JSON_DEF_MODEL>(results.data.ToString());

                        lblCost.Text = rs_object.cost.ToString("C", CultureInfo.CurrentCulture);
                        lblNet.Text = rs_object.net_sales.ToString("C", CultureInfo.CurrentCulture);
                        lblSales.Text = rs_object.gross_sales.ToString("C", CultureInfo.CurrentCulture);
                        lblPercentage.Text = rs_object.increase.ToString("C", CultureInfo.CurrentCulture) + " %";
                        return true;
                    }

                    return false;
                }

                return false;
            });

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
