namespace StudentManagementSystem
{
    partial class HomePage
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
            this.btnStdRegister = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnFeeEntry = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStdRegister
            // 
            this.btnStdRegister.Location = new System.Drawing.Point(151, 74);
            this.btnStdRegister.Name = "btnStdRegister";
            this.btnStdRegister.Size = new System.Drawing.Size(196, 142);
            this.btnStdRegister.TabIndex = 0;
            this.btnStdRegister.Text = "Register Student";
            this.btnStdRegister.UseVisualStyleBackColor = true;
            this.btnStdRegister.Click += new System.EventHandler(this.btnStdRegister_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(446, 74);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(196, 142);
            this.btnEnroll.TabIndex = 1;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnFeeEntry
            // 
            this.btnFeeEntry.Location = new System.Drawing.Point(151, 223);
            this.btnFeeEntry.Name = "btnFeeEntry";
            this.btnFeeEntry.Size = new System.Drawing.Size(196, 142);
            this.btnFeeEntry.TabIndex = 2;
            this.btnFeeEntry.Text = "Fee Entry";
            this.btnFeeEntry.UseVisualStyleBackColor = true;
            this.btnFeeEntry.Click += new System.EventHandler(this.btnFeeEntry_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(446, 223);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(196, 142);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(691, 23);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnFeeEntry);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnStdRegister);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStdRegister;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnFeeEntry;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogOut;
    }
}