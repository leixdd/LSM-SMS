namespace LSM.Forms
{
    partial class frmItemList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards2 = new ns1.BunifuCards();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDeliveryItems = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards2.Controls.Add(this.txtSearch);
            this.bunifuCards2.Controls.Add(this.label1);
            this.bunifuCards2.Controls.Add(this.groupBox3);
            this.bunifuCards2.Controls.Add(this.groupBox2);
            this.bunifuCards2.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards2.Controls.Add(this.lblDesc);
            this.bunifuCards2.Controls.Add(this.label8);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1213, 547);
            this.bunifuCards2.TabIndex = 28;
            this.bunifuCards2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards2_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(966, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(232, 25);
            this.txtSearch.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(892, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search :";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvDeliveryItems);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(384, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 457);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item List";
            // 
            // dgvDeliveryItems
            // 
            this.dgvDeliveryItems.AllowUserToAddRows = false;
            this.dgvDeliveryItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryItems.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDeliveryItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliveryItems.Location = new System.Drawing.Point(3, 18);
            this.dgvDeliveryItems.Name = "dgvDeliveryItems";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDeliveryItems.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDeliveryItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveryItems.Size = new System.Drawing.Size(811, 436);
            this.dgvDeliveryItems.TabIndex = 10;
            this.dgvDeliveryItems.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDeliveryItems_UserDeletingRow);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtItemSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnClearFields);
            this.groupBox2.Controls.Add(this.btnTransaction);
            this.groupBox2.Controls.Add(this.numUnitPrice);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 275);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Control";
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(10, 179);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(331, 27);
            this.btnClearFields.TabIndex = 20;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(10, 212);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(331, 41);
            this.btnTransaction.TabIndex = 21;
            this.btnTransaction.Text = "Save Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 2;
            this.numUnitPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUnitPrice.Location = new System.Drawing.Point(109, 134);
            this.numUnitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(232, 22);
            this.numUnitPrice.TabIndex = 18;
            this.numUnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "Unit Price : ";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(109, 39);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(232, 24);
            this.txtItemName.TabIndex = 12;
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Item Name : ";
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
            this.lblDesc.Size = new System.Drawing.Size(299, 19);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Database of all items with its cost and unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "ITEM DATABASE";
            // 
            // txtItemSize
            // 
            this.txtItemSize.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSize.Location = new System.Drawing.Point(109, 85);
            this.txtItemSize.Name = "txtItemSize";
            this.txtItemSize.Size = new System.Drawing.Size(232, 24);
            this.txtItemSize.TabIndex = 22;
            this.txtItemSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Item Size : ";
            // 
            // frmItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 547);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemList";
            this.Text = "frmItemList";
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards2;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDeliveryItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemSize;
        private System.Windows.Forms.Label label2;
    }
}