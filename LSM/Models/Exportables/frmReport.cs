using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Models.Exportables
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        
        private void frmReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void setDS(List<TABLE_BILLING_MODEL> ds, String customer_name, String company_name, String contact_number, String company_address)
        {
            tABLEBILLINGMODELBindingSource.DataSource = ds;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("customerName", customer_name),
                new ReportParameter("companyName", company_name),
                new ReportParameter("contactNumber", contact_number),
                new ReportParameter("companyAddress", company_address)
            });
            this.reportViewer1.RefreshReport();
        }

    }
}
