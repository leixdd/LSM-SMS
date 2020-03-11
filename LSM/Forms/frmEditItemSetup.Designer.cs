namespace LSM.Forms
{
    partial class frmEditItemSetup
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
            this.bunifuCards2 = new ns1.BunifuCards();
            this.numFP = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numSP = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards2.Controls.Add(this.numFP);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.numDiscount);
            this.bunifuCards2.Controls.Add(this.label1);
            this.bunifuCards2.Controls.Add(this.txtItemSize);
            this.bunifuCards2.Controls.Add(this.label10);
            this.bunifuCards2.Controls.Add(this.numSP);
            this.bunifuCards2.Controls.Add(this.label12);
            this.bunifuCards2.Controls.Add(this.txtItem);
            this.bunifuCards2.Controls.Add(this.label11);
            this.bunifuCards2.Controls.Add(this.btnCancel);
            this.bunifuCards2.Controls.Add(this.btnTransaction);
            this.bunifuCards2.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards2.Controls.Add(this.lblDesc);
            this.bunifuCards2.Controls.Add(this.label8);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(330, 493);
            this.bunifuCards2.TabIndex = 16;
            this.bunifuCards2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCards2_MouseDown);
            // 
            // numFP
            // 
            this.numFP.DecimalPlaces = 2;
            this.numFP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numFP.Location = new System.Drawing.Point(12, 358);
            this.numFP.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFP.Name = "numFP";
            this.numFP.ReadOnly = true;
            this.numFP.Size = new System.Drawing.Size(303, 20);
            this.numFP.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Final Price:";
            // 
            // numDiscount
            // 
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numDiscount.Location = new System.Drawing.Point(12, 293);
            this.numDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(303, 20);
            this.numDiscount.TabIndex = 50;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Discount (Percentage [e.g. 10 = 10%] ):";
            // 
            // txtItemSize
            // 
            this.txtItemSize.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSize.Location = new System.Drawing.Point(12, 166);
            this.txtItemSize.Name = "txtItemSize";
            this.txtItemSize.Size = new System.Drawing.Size(303, 24);
            this.txtItemSize.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 48;
            this.label10.Text = "Item Size:";
            // 
            // numSP
            // 
            this.numSP.DecimalPlaces = 2;
            this.numSP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSP.Location = new System.Drawing.Point(12, 225);
            this.numSP.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSP.Name = "numSP";
            this.numSP.Size = new System.Drawing.Size(303, 20);
            this.numSP.TabIndex = 44;
            this.numSP.ValueChanged += new System.EventHandler(this.numSP_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 19);
            this.label12.TabIndex = 43;
            this.label12.Text = "Selling Price : ";
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(12, 105);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(303, 24);
            this.txtItem.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Item : ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(303, 30);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Green;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(12, 404);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(303, 30);
            this.btnTransaction.TabIndex = 39;
            this.btnTransaction.Text = "Update Item";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(15, 65);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(300, 10);
            this.bunifuSeparator2.TabIndex = 24;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(11, 46);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(90, 19);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Editing Item";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Edit Item Setup";
            // 
            // frmEditItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 493);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditItemSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddItemSetup";
            this.Shown += new System.EventHandler(this.frmEditItemSetup_Shown);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.frmEditItemSetup_Scroll);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTransaction;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numFP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label label1;
    }
}