namespace StudentManagementSystem
{
    partial class ViewFeeEntryReport
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
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.SearchId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGridView
            // 
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Location = new System.Drawing.Point(49, 129);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.Size = new System.Drawing.Size(996, 529);
            this.searchGridView.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(791, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchId
            // 
            this.SearchId.Location = new System.Drawing.Point(489, 68);
            this.SearchId.Name = "SearchId";
            this.SearchId.Size = new System.Drawing.Size(109, 20);
            this.SearchId.TabIndex = 19;
            this.SearchId.TextChanged += new System.EventHandler(this.SearchId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(970, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "HomePage";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ViewFeeEntryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 693);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.searchGridView);
            this.Name = "ViewFeeEntryReport";
            this.Text = "ViewFeeEntryReport";
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SearchId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
    }
}