using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM
{
    public partial class frmMain_Screen : Form
    {

        protected static Color CONSTANT_BG = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        protected static Button CurrentSelectedModule = null;

        public void mdi_module_load(Form frm, object sender = null)
        {
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();

            if (sender != null)
            {
                if (CurrentSelectedModule == null)
                {
                    Button btn = (Button)sender;
                    btn.BackColor = System.Drawing.SystemColors.HotTrack;
                    CurrentSelectedModule = btn;
                }
                else
                {
                    Button btn = (Button)sender;
                    btn.BackColor = System.Drawing.SystemColors.HotTrack;
                    CurrentSelectedModule.BackColor = CONSTANT_BG;
                    CurrentSelectedModule = btn;
                    lblModule.Text = btn.Text;
                }
            }
        }

        public frmMain_Screen()
        {
            InitializeComponent();

            mdi_module_load(new Forms.frmDashboard(), btnDashboard);

            Utilities.HttpServer.Get(Utilities.Routes.R_UNITS, (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<Models.Unit>>(results.data.ToString());
                        Models.GlobalSettings.UNIT_LIST = rs_object;

                        return true;
                    }

                    return false;
                }

                return false;
            });

            lblStatus.Text = "Connected";
            lblUserID.Text = Models.GlobalSettings.CURRENT_USER.Username;
            lblSessionID.Text = DateTime.Today.ToLongDateString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           mdi_module_load(new Forms.frmDR(), (Button) sender); //explicit cast sender into a button
        }

        private void btnDR_MouseHover(object sender, EventArgs e)
        {
        }

        private void hoverOrEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != CurrentSelectedModule)
                btn.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void OutOrLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != CurrentSelectedModule)
                btn.BackColor = CONSTANT_BG;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            mdi_module_load(new Forms.frmDashboard(), (Button)sender);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSN_click(object sender, EventArgs e)
        {
            mdi_module_load(new Forms.frmSales(), (Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mdi_module_load(new Forms.frmRPT(), (Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            mdi_module_load(new Forms.frmCustomer(), (Button)sender);
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {

            mdi_module_load(new Forms.frmItemList(), (Button)sender);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
