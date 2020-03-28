namespace LSM.Models.Exportables
{
    partial class frmReportDR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TABLE_BILLING_MODELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TABLE_DELIVERIES_LISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABLEBILLINGMODELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_BILLING_MODELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_DELIVERIES_LISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLEBILLINGMODELBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TABLE_BILLING_MODELBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TABLE_DELIVERIES_LISTBindingSource;
            reportDataSource3.Name = "dr_dataset";
            reportDataSource3.Value = this.DRBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LSM.Models.Exportables.DR.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TABLE_BILLING_MODELBindingSource
            // 
            this.TABLE_BILLING_MODELBindingSource.DataSource = typeof(LSM.Models.TABLE_BILLING_MODEL);
            // 
            // TABLE_DELIVERIES_LISTBindingSource
            // 
            this.TABLE_DELIVERIES_LISTBindingSource.DataSource = typeof(LSM.Models.TABLE_DELIVERIES_LIST);
            // 
            // DRBindingSource
            // 
            this.DRBindingSource.DataSource = typeof(LSM.Models.DR);
            // 
            // tABLEBILLINGMODELBindingSource
            // 
            this.tABLEBILLINGMODELBindingSource.DataSource = typeof(LSM.Models.TABLE_BILLING_MODEL);
            // 
            // frmReportDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportDR";
            this.Text = "Delivery Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_BILLING_MODELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_DELIVERIES_LISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLEBILLINGMODELBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tABLEBILLINGMODELBindingSource;
        private System.Windows.Forms.BindingSource TABLE_BILLING_MODELBindingSource;
        private System.Windows.Forms.BindingSource TABLE_DELIVERIES_LISTBindingSource;
        private System.Windows.Forms.BindingSource DRBindingSource;
    }
}