using Microsoft.Reporting.WinForms;
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

namespace LSM.Models.Exportables
{
    public partial class frmReportDR : Form
    {
        public frmReportDR()
        {
            InitializeComponent();
        }

        
        private void frmReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        public void setDS(List<Models.DR> ds, 
            String customer_name, 
            String company_address, 
            Double total_amount,
            String dr_no,
            String dr_date,
            String terms
        )
        {
            DRBindingSource.DataSource = ds;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("customerName", customer_name),
                new ReportParameter("companyAddress", company_address),
                new ReportParameter("totalAmount", total_amount.ToString()),
                new ReportParameter("DRNO", dr_no),
                new ReportParameter("DRDATE", dr_date),
                new ReportParameter("Terms", terms),
            });

            this.reportViewer1.RefreshReport();

        }

    }
}
