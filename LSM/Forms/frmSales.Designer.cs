namespace LSM.Forms
{
    partial class frmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDeliveryItems = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtItemSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.numIC = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTransactionNumber = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusStyle = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSoldTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvDeliveryItems);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(371, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(778, 501);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item List";
            // 
            // dgvDeliveryItems
            // 
            this.dgvDeliveryItems.AllowUserToAddRows = false;
            this.dgvDeliveryItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeliveryItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliveryItems.Location = new System.Drawing.Point(3, 18);
            this.dgvDeliveryItems.Name = "dgvDeliveryItems";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDeliveryItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeliveryItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveryItems.Size = new System.Drawing.Size(772, 480);
            this.dgvDeliveryItems.TabIndex = 10;
            this.dgvDeliveryItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryItems_CellEndEdit);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtItemSize);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bunifuSeparator2);
            this.groupBox2.Controls.Add(this.numIC);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.numUnitPrice);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numQuantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bunifuSeparator1);
            this.groupBox2.Controls.Add(this.btnClearFields);
            this.groupBox2.Controls.Add(this.btnTransaction);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 430);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Control";
            // 
            // txtItemSize
            // 
            this.txtItemSize.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSize.Location = new System.Drawing.Point(113, 84);
            this.txtItemSize.Name = "txtItemSize";
            this.txtItemSize.Size = new System.Drawing.Size(227, 24);
            this.txtItemSize.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Item Size:";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 9;
            this.bunifuSeparator2.Location = new System.Drawing.Point(10, 162);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(330, 18);
            this.bunifuSeparator2.TabIndex = 33;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // numIC
            // 
            this.numIC.DecimalPlaces = 2;
            this.numIC.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numIC.Location = new System.Drawing.Point(113, 123);
            this.numIC.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numIC.Name = "numIC";
            this.numIC.ReadOnly = true;
            this.numIC.Size = new System.Drawing.Size(227, 22);
            this.numIC.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Item Cost :";
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 2;
            this.numUnitPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUnitPrice.Location = new System.Drawing.Point(113, 197);
            this.numUnitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(227, 22);
            this.numUnitPrice.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "Selling Price : ";
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(113, 42);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(227, 24);
            this.txtItem.TabIndex = 23;
            this.txtItem.Click += new System.EventHandler(this.txtItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Item : ";
            // 
            // numQuantity
            // 
            this.numQuantity.DecimalPlaces = 2;
            this.numQuantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numQuantity.Location = new System.Drawing.Point(113, 232);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(227, 22);
            this.numQuantity.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quantity : ";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 7;
            this.bunifuSeparator1.Location = new System.Drawing.Point(10, 345);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(330, 13);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(10, 312);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(330, 27);
            this.btnClearFields.TabIndex = 20;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Green;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(10, 371);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(330, 41);
            this.btnTransaction.TabIndex = 21;
            this.btnTransaction.Text = "RECEIVE PAYMENT";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(10, 279);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(330, 27);
            this.btnAddItem.TabIndex = 19;
            this.btnAddItem.Text = "ADD ITEM";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnTransactionNumber);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(884, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 41);
            this.panel1.TabIndex = 27;
            // 
            // btnTransactionNumber
            // 
            this.btnTransactionNumber.BackColor = System.Drawing.Color.White;
            this.btnTransactionNumber.FlatAppearance.BorderSize = 0;
            this.btnTransactionNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionNumber.ForeColor = System.Drawing.Color.Red;
            this.btnTransactionNumber.Location = new System.Drawing.Point(54, 7);
            this.btnTransactionNumber.Name = "btnTransactionNumber";
            this.btnTransactionNumber.Size = new System.Drawing.Size(203, 29);
            this.btnTransactionNumber.TabIndex = 12;
            this.btnTransactionNumber.Text = "0000000000";
            this.btnTransactionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactionNumber.UseVisualStyleBackColor = false;
            this.btnTransactionNumber.Click += new System.EventHandler(this.btnTransactionNumber_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "NO.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTerms);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBusStyle);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtSoldTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 118);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Information";
            // 
            // txtPO
            // 
            this.txtPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPO.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPO.Location = new System.Drawing.Point(890, 79);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(236, 24);
            this.txtPO.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(815, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "P.O. NO.";
            // 
            // txtTerms
            // 
            this.txtTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTerms.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerms.Location = new System.Drawing.Point(890, 53);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(236, 24);
            this.txtTerms.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(815, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Terms: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(890, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(236, 24);
            this.dtpDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(815, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date: ";
            // 
            // txtBusStyle
            // 
            this.txtBusStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusStyle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusStyle.Location = new System.Drawing.Point(167, 79);
            this.txtBusStyle.Name = "txtBusStyle";
            this.txtBusStyle.Size = new System.Drawing.Size(642, 24);
            this.txtBusStyle.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(167, 53);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(642, 24);
            this.txtAddress.TabIndex = 4;
            // 
            // txtSoldTo
            // 
            this.txtSoldTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoldTo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoldTo.Location = new System.Drawing.Point(167, 26);
            this.txtSoldTo.Name = "txtSoldTo";
            this.txtSoldTo.Size = new System.Drawing.Size(642, 24);
            this.txtSoldTo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Business Style:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sold To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "SALES INVOICE";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 691);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSales";
            this.Text = "frmSales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.Shown += new System.EventHandler(this.frmSales_Shown);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDeliveryItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTransactionNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusStyle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSoldTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label9;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.NumericUpDown numIC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtItemSize;
        private System.Windows.Forms.Label label10;
    }
}