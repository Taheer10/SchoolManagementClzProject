namespace StudentManagementSystem
{
    partial class Enroll
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
            this.textLevel = new System.Windows.Forms.ComboBox();
            this.yearDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stdRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementSystemDataSet = new StudentManagementSystem.StudentManagementSystemDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.stdRegisterTableAdapter = new StudentManagementSystem.StudentManagementSystemDataSetTableAdapters.StdRegisterTableAdapter();
            this.stdRegisterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementSystemDataSet1 = new StudentManagementSystem.StudentManagementSystemDataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.stdRegisterTableAdapter1 = new StudentManagementSystem.StudentManagementSystemDataSet1TableAdapters.StdRegisterTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EnrolldataGridView = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.ComboBox();
            this.textCourse = new System.Windows.Forms.ComboBox();
            this.textSemester = new System.Windows.Forms.ComboBox();
            this.stdRegister = new StudentManagementSystem.stdRegister();
            this.stdRegisterBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stdRegisterTableAdapter2 = new StudentManagementSystem.stdRegisterTableAdapters.StdRegisterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stdRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdRegisterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrolldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdRegisterBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // textLevel
            // 
            this.textLevel.FormattingEnabled = true;
            this.textLevel.Items.AddRange(new object[] {
            "Bachelor",
            "Master"});
            this.textLevel.Location = new System.Drawing.Point(597, 288);
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(199, 21);
            this.textLevel.TabIndex = 2;
            // 
            // yearDateTime
            // 
            this.yearDateTime.Location = new System.Drawing.Point(596, 225);
            this.yearDateTime.Name = "yearDateTime";
            this.yearDateTime.Size = new System.Drawing.Size(200, 20);
            this.yearDateTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Level";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year";
            // 
            // stdRegisterBindingSource
            // 
            this.stdRegisterBindingSource.DataMember = "StdRegister";
            this.stdRegisterBindingSource.DataSource = this.studentManagementSystemDataSet;
            // 
            // studentManagementSystemDataSet
            // 
            this.studentManagementSystemDataSet.DataSetName = "StudentManagementSystemDataSet";
            this.studentManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // stdRegisterTableAdapter
            // 
            this.stdRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // stdRegisterBindingSource1
            // 
            this.stdRegisterBindingSource1.DataMember = "StdRegister";
            this.stdRegisterBindingSource1.DataSource = this.studentManagementSystemDataSet1;
            // 
            // studentManagementSystemDataSet1
            // 
            this.studentManagementSystemDataSet1.DataSetName = "StudentManagementSystemDataSet1";
            this.studentManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student ID:";
            // 
            // stdRegisterTableAdapter1
            // 
            this.stdRegisterTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(507, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(657, 394);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(795, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EnrolldataGridView
            // 
            this.EnrolldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrolldataGridView.Location = new System.Drawing.Point(61, 459);
            this.EnrolldataGridView.Name = "EnrolldataGridView";
            this.EnrolldataGridView.Size = new System.Drawing.Size(848, 468);
            this.EnrolldataGridView.TabIndex = 18;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(795, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "HomePage";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // StudentId
            // 
            this.StudentId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stdRegisterBindingSource2, "Id", true));
            this.StudentId.DataSource = this.stdRegisterBindingSource2;
            this.StudentId.DisplayMember = "Id";
            this.StudentId.FormattingEnabled = true;
            this.StudentId.Location = new System.Drawing.Point(197, 89);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(121, 21);
            this.StudentId.TabIndex = 20;
            this.StudentId.ValueMember = "Id";
            // 
            // textName
            // 
            this.textName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stdRegisterBindingSource2, "fname", true));
            this.textName.DataSource = this.stdRegisterBindingSource2;
            this.textName.DisplayMember = "fname";
            this.textName.FormattingEnabled = true;
            this.textName.Location = new System.Drawing.Point(197, 141);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 21);
            this.textName.TabIndex = 21;
            this.textName.ValueMember = "fname";
            // 
            // textCourse
            // 
            this.textCourse.FormattingEnabled = true;
            this.textCourse.Items.AddRange(new object[] {
            "BCA",
            "BIT",
            "BSCIT",
            "BBA",
            "BHM",
            "MIT",
            "MCA",
            "MBA",
            "MHM"});
            this.textCourse.Location = new System.Drawing.Point(197, 231);
            this.textCourse.Name = "textCourse";
            this.textCourse.Size = new System.Drawing.Size(121, 21);
            this.textCourse.TabIndex = 22;
            // 
            // textSemester
            // 
            this.textSemester.FormattingEnabled = true;
            this.textSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "",
            "",
            "",
            ""});
            this.textSemester.Location = new System.Drawing.Point(596, 142);
            this.textSemester.Name = "textSemester";
            this.textSemester.Size = new System.Drawing.Size(121, 21);
            this.textSemester.TabIndex = 23;
            // 
            // stdRegister
            // 
            this.stdRegister.DataSetName = "stdRegister";
            this.stdRegister.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdRegisterBindingSource2
            // 
            this.stdRegisterBindingSource2.DataMember = "StdRegister";
            this.stdRegisterBindingSource2.DataSource = this.stdRegister;
            // 
            // stdRegisterTableAdapter2
            // 
            this.stdRegisterTableAdapter2.ClearBeforeFill = true;
            // 
            // Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 960);
            this.Controls.Add(this.textSemester);
            this.Controls.Add(this.textCourse);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.EnrolldataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearDateTime);
            this.Controls.Add(this.textLevel);
            this.Name = "Enroll";
            this.Text = "Enroll";
            this.Load += new System.EventHandler(this.Enroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdRegisterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrolldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdRegisterBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox textLevel;
        private System.Windows.Forms.DateTimePicker yearDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private StudentManagementSystemDataSet studentManagementSystemDataSet;
        private System.Windows.Forms.BindingSource stdRegisterBindingSource;
        private StudentManagementSystemDataSetTableAdapters.StdRegisterTableAdapter stdRegisterTableAdapter;
        private System.Windows.Forms.Label label6;
        private StudentManagementSystemDataSet1 studentManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource stdRegisterBindingSource1;
        private StudentManagementSystemDataSet1TableAdapters.StdRegisterTableAdapter stdRegisterTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView EnrolldataGridView;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox StudentId;
        private System.Windows.Forms.ComboBox textName;
        private System.Windows.Forms.ComboBox textCourse;
        private System.Windows.Forms.ComboBox textSemester;
        private stdRegister stdRegister;
        private System.Windows.Forms.BindingSource stdRegisterBindingSource2;
        private stdRegisterTableAdapters.StdRegisterTableAdapter stdRegisterTableAdapter2;
    }
}