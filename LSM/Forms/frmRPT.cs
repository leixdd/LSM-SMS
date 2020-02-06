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
    public partial class frmRPT : Form
    {

        protected Dictionary<string, Models.IReport> reports = new Dictionary<string, Models.IReport>();

        public frmRPT()
        {
            InitializeComponent();
        }

        private void frmRPT_Load(object sender, EventArgs e)
        {
            generateListItem();
        }

        private void generateListItem()
        {
            foreach (var item in Models.GlobalSettings.REPORTS)
            {
                lstReports.Items.Add(item.report_name());
                reports.Add(item.report_name(), item);
            }
        }

       
        private void lstReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReports.SelectedIndices.Count > 0)
            {
                var rpt = reports[lstReports.SelectedItem.ToString()];
                dgvGPT.DataSource = rpt.dgv;
                rpt.generate_report();
            }
            

        }

        private void contextRPT_Opening(object sender, CancelEventArgs e)
        {
            //if (dgvGPT.SelectedCells.Count == 0)
            //{
            //    MessageBox.Show(this, "Must select at least 1 item at the grid view", "Wait!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}

            //if (dgvGPT.SelectedRows[0].Cells["ModeOfPayment"].Value.Equals("Cash")) 
            //{
            //    e.Cancel = true;
            //}

            e.Cancel = true;
        }

        private void toolViewCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
