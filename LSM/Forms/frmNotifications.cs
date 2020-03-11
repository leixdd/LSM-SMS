using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Forms
{
    public partial class frmNotifications : Form
    {

        protected Models.DGV_MODEL<Models.TABLE_NOTIFICATIONS> TABLE_MODEL = new Models.DGV_MODEL<Models.TABLE_NOTIFICATIONS>();

        public frmNotifications()
        {
            InitializeComponent();
        }

        private void frmNotifications_Load(object sender, EventArgs e)
        {
            dgvNotifs.DataSource = new BindingSource(TABLE_MODEL.get_model, null);
            TABLE_MODEL.get_model.ResetBindings();
            TABLE_MODEL.get_list.Clear();

            foreach(Models.Notifications notification in Models.GlobalSettings.Notifications)
            {
                TABLE_MODEL.get_list.Add(new Models.TABLE_NOTIFICATIONS
                {
                     CustomerName = notification.customer_name,
                     DRNo = notification.dr_no,
                     DueDate = notification.date_to_be_paid,
                     RemainingDays = notification.remaining_days,
                     TotalAmount = notification.total_amount
                });
            }

            TABLE_MODEL.get_model.ResetBindings();
            
        }
    }
}
