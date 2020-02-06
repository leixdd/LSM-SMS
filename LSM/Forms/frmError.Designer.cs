namespace LSM.Forms
{
    partial class frmError
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
            this.bunifuCards1 = new ns1.BunifuCards();
            this.errorList1 = new LSM.User.ErrorList();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.errorList1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(436, 498);
            this.bunifuCards1.TabIndex = 1;
            this.bunifuCards1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCards1_MouseDown);
            // 
            // errorList1
            // 
            this.errorList1.BackColor = System.Drawing.Color.White;
            this.errorList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorList1.Location = new System.Drawing.Point(0, 0);
            this.errorList1.Name = "errorList1";
            this.errorList1.Size = new System.Drawing.Size(436, 498);
            this.errorList1.TabIndex = 1;
            this.errorList1.Load += new System.EventHandler(this.errorList1_Load);
            this.errorList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.errorList1_MouseDown);

            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 498);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmError";
            this.TopMost = true;
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards bunifuCards1;
        public User.ErrorList errorList1;
    }
}