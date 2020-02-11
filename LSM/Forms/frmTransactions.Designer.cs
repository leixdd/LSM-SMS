namespace LSM.Forms
{
    partial class frmTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards3 = new ns1.BunifuCards();
            this.btnItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.bunifuSeparator3 = new ns1.BunifuSeparator();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvChequeList = new System.Windows.Forms.DataGridView();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new ns1.BunifuCards();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cashGroup = new ns1.BunifuCards();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeliveryAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator4 = new ns1.BunifuSeparator();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuCards3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequeList)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.cashGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards3.Controls.Add(this.button3);
            this.bunifuCards3.Controls.Add(this.btnItem);
            this.bunifuCards3.Controls.Add(this.groupBox3);
            this.bunifuCards3.Controls.Add(this.bunifuSeparator3);
            this.bunifuCards3.Controls.Add(this.label10);
            this.bunifuCards3.Controls.Add(this.label12);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(398, 194);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(748, 305);
            this.bunifuCards3.TabIndex = 50;
            // 
            // btnItem
            // 
            this.btnItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItem.BackColor = System.Drawing.Color.Green;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.Location = new System.Drawing.Point(588, 18);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(144, 31);
            this.btnItem.TabIndex = 31;
            this.btnItem.Text = "Add Item";
            this.btnItem.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvBilling);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 218);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delivery Item List";
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilling.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBilling.Location = new System.Drawing.Point(3, 18);
            this.dgvBilling.Name = "dgvBilling";
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBilling.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBilling.Size = new System.Drawing.Size(715, 197);
            this.dgvBilling.TabIndex = 10;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 3;
            this.bunifuSeparator3.Location = new System.Drawing.Point(15, 64);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(373, 10);
            this.bunifuSeparator3.TabIndex = 24;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(409, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "List of all items charged to the customer under this delivery";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "Billing";
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
            this.bunifuCards1.Controls.Add(this.button1);
            this.bunifuCards1.Controls.Add(this.dgvChequeList);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(398, 505);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(748, 187);
            this.bunifuCards1.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(588, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add New Cheque";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvChequeList
            // 
            this.dgvChequeList.AllowUserToAddRows = false;
            this.dgvChequeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChequeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChequeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChequeList.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvChequeList.Location = new System.Drawing.Point(12, 78);
            this.dgvChequeList.Name = "dgvChequeList";
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.dgvChequeList.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvChequeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChequeList.Size = new System.Drawing.Size(721, 94);
            this.dgvChequeList.TabIndex = 25;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "List of all cheque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cheque List";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards2.Controls.Add(this.dgvDeliveries);
            this.bunifuCards2.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 46);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(380, 646);
            this.bunifuCards2.TabIndex = 52;
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.AllowUserToAddRows = false;
            this.dgvDeliveries.AllowUserToDeleteRows = false;
            this.dgvDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveries.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvDeliveries.Location = new System.Drawing.Point(12, 78);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.ReadOnly = true;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDeliveries.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveries.Size = new System.Drawing.Size(353, 553);
            this.dgvDeliveries.TabIndex = 25;
            this.dgvDeliveries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveries_CellContentClick);
            this.dgvDeliveries.SelectionChanged += new System.EventHandler(this.dgvDeliveries_SelectionChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "List of all Deliveries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deliveries";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 31);
            this.button2.TabIndex = 32;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cashGroup
            // 
            this.cashGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashGroup.BackColor = System.Drawing.Color.White;
            this.cashGroup.BorderRadius = 5;
            this.cashGroup.BottomSahddow = true;
            this.cashGroup.color = System.Drawing.Color.DodgerBlue;
            this.cashGroup.Controls.Add(this.txtAmountReceived);
            this.cashGroup.Controls.Add(this.label7);
            this.cashGroup.Controls.Add(this.txtDeliveryAmount);
            this.cashGroup.Controls.Add(this.label6);
            this.cashGroup.Controls.Add(this.dtpDueDate);
            this.cashGroup.Controls.Add(this.label4);
            this.cashGroup.Controls.Add(this.dtpDate);
            this.cashGroup.Controls.Add(this.label5);
            this.cashGroup.Controls.Add(this.bunifuSeparator4);
            this.cashGroup.Controls.Add(this.label8);
            this.cashGroup.LeftSahddow = false;
            this.cashGroup.Location = new System.Drawing.Point(398, 46);
            this.cashGroup.Name = "cashGroup";
            this.cashGroup.RightSahddow = true;
            this.cashGroup.ShadowDepth = 20;
            this.cashGroup.Size = new System.Drawing.Size(748, 142);
            this.cashGroup.TabIndex = 53;
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountReceived.Location = new System.Drawing.Point(541, 99);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.ReadOnly = true;
            this.txtAmountReceived.Size = new System.Drawing.Size(191, 24);
            this.txtAmountReceived.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Amount Received :";
            // 
            // txtDeliveryAmount
            // 
            this.txtDeliveryAmount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryAmount.Location = new System.Drawing.Point(144, 99);
            this.txtDeliveryAmount.Name = "txtDeliveryAmount";
            this.txtDeliveryAmount.ReadOnly = true;
            this.txtDeliveryAmount.Size = new System.Drawing.Size(244, 24);
            this.txtDeliveryAmount.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Delivery Amount :";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(473, 61);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(260, 24);
            this.dtpDueDate.TabIndex = 28;
            this.dtpDueDate.Value = new System.DateTime(2020, 2, 10, 7, 57, 59, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Due Date: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(128, 63);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(260, 24);
            this.dtpDate.TabIndex = 26;
            this.dtpDate.Value = new System.DateTime(2020, 2, 10, 7, 57, 59, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Delivery Date :";
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 3;
            this.bunifuSeparator4.Location = new System.Drawing.Point(15, 48);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(373, 10);
            this.bunifuSeparator4.TabIndex = 24;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Delivery Information";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(438, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 31);
            this.button3.TabIndex = 32;
            this.button3.Text = "Print SOA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 704);
            this.Controls.Add(this.cashGroup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequeList)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.cashGroup.ResumeLayout(false);
            this.cashGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards3;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvBilling;
        private ns1.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private ns1.BunifuCards bunifuCards1;
        private System.Windows.Forms.DataGridView dgvChequeList;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCards bunifuCards2;
        private System.Windows.Forms.DataGridView dgvDeliveries;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ns1.BunifuCards cashGroup;
        private ns1.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeliveryAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}