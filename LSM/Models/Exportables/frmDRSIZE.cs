using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Models.Exportables
{
    public partial class frmDRSIZE : Form
    {
        public frmDRSIZE()
        {
            InitializeComponent();
        }

        
        private void frmReport_Load(object sender, EventArgs e)
        {
            //System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            //pg.Margins.Top = 0;
            //pg.Margins.Bottom = 0;
            //pg.Margins.Left = 0;
            //pg.Margins.Right = 0;
            //System.Drawing.Printing.PaperSize size = new PaperSize("LSMPaper", 164, 210);

            //pg.PaperSize = size;

            //this.reportViewer1.SetPageSettings(pg);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            
            this.reportViewer1.RefreshReport();
        }

        public void setDS(List<Models.DR> ds, 
            String customer_name, 
            String dr_no,
            String dr_date
        )
        {
            DRBindingSource.DataSource = ds;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("CustomerName", customer_name),
                new ReportParameter("DrNo", dr_no),
                new ReportParameter("DRDate", dr_date),
            });

            //this.reportViewer1.RefreshReport();

        }

    }
}
