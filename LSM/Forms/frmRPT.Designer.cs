namespace LSM.Forms
{
    partial class frmRPT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards2 = new ns1.BunifuCards();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.dgvGPT = new System.Windows.Forms.DataGridView();
            this.contextRPT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolViewCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGPT)).BeginInit();
            this.contextRPT.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards2.Controls.Add(this.lstReports);
            this.bunifuCards2.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards2.Controls.Add(this.lblDesc);
            this.bunifuCards2.Controls.Add(this.label8);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 12);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(400, 533);
            this.bunifuCards2.TabIndex = 27;
            // 
            // lstReports
            // 
            this.lstReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstReports.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReports.FormattingEnabled = true;
            this.lstReports.ItemHeight = 17;
            this.lstReports.Location = new System.Drawing.Point(15, 79);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(373, 446);
            this.lstReports.TabIndex = 25;
            this.lstReports.SelectedIndexChanged += new System.EventHandler(this.lstReports_SelectedIndexChanged);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(15, 61);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(373, 10);
            this.bunifuSeparator2.TabIndex = 24;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(11, 39);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(311, 19);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Select 1 item on the list to generate a report";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "REPORTS";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.dgvGPT);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(418, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(653, 533);
            this.bunifuCards1.TabIndex = 28;
            // 
            // dgvGPT
            // 
            this.dgvGPT.AllowUserToAddRows = false;
            this.dgvGPT.AllowUserToDeleteRows = false;
            this.dgvGPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGPT.ContextMenuStrip = this.contextRPT;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGPT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGPT.Location = new System.Drawing.Point(14, 79);
            this.dgvGPT.Name = "dgvGPT";
            this.dgvGPT.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGPT.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGPT.Size = new System.Drawing.Size(626, 446);
            this.dgvGPT.TabIndex = 25;
            // 
            // contextRPT
            // 
            this.contextRPT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextRPT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolViewCheck});
            this.contextRPT.Name = "contextRPT";
            this.contextRPT.Size = new System.Drawing.Size(161, 52);
            this.contextRPT.Opening += new System.ComponentModel.CancelEventHandler(this.contextRPT_Opening);
            // 
            // toolViewCheck
            // 
            this.toolViewCheck.Name = "toolViewCheck";
            this.toolViewCheck.Size = new System.Drawing.Size(160, 26);
            this.toolViewCheck.Text = "View Check";
            this.toolViewCheck.Click += new System.EventHandler(this.toolViewCheck_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 61);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(373, 10);
            this.bunifuSeparator1.TabIndex = 24;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Results form past transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "GENERATED REPORT";
            // 
            // frmRPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 557);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRPT";
            this.Text = "frmRPT";
            this.Load += new System.EventHandler(this.frmRPT_Load);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGPT)).EndInit();
            this.contextRPT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards2;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label8;
        private ns1.BunifuCards bunifuCards1;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.DataGridView dgvGPT;
        private System.Windows.Forms.ContextMenuStrip contextRPT;
        private System.Windows.Forms.ToolStripMenuItem toolViewCheck;

    }
}