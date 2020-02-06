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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit(); //Gamit ka ng ganto lagi para wala ng ititira sa background task
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            this.WindowState = FormWindowState.Maximized;
            //MainPanel.Height = (this.Height - statusStrip.Height) - 64;
         //   MainPanel.Height = (this.Height);
            mainboard.Size = new Size(this.Width, this.Height);

            mainboard.Controls.Clear();
            dashboard dash = new dashboard();
            dash.Size = new Size(this.mainboard.Width, this.mainboard.Height);
            mainboard.Controls.Add(dash);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            mainboard.Controls.Clear();
            dashboard dash = new dashboard();
            dash.Size = new Size(this.mainboard.Width - 100, this.mainboard.Height);
            mainboard.Controls.Add(dash);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            mainboard.Controls.Clear();
            DeliveryRec Rec = new DeliveryRec();
            Rec.Size = new Size(this.mainboard.Width, this.mainboard.Height);
            mainboard.Controls.Add(Rec);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            mainboard.Controls.Clear();
            Customer cust = new Customer();
            cust.Size = new Size(this.mainboard.Width, this.mainboard.Height);
            mainboard.Controls.Add(cust);
        }

    }
}
