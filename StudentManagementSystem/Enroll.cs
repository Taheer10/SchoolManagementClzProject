using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentManagementSystem
{
    public partial class Enroll : Form
    {
        public Enroll()
        {
            InitializeComponent();
        }

        private void Enroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stdRegister.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter2.Fill(this.stdRegister.StdRegister);
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet1.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter1.Fill(this.studentManagementSystemDataSet1.StdRegister);
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter.Fill(this.studentManagementSystemDataSet.StdRegister);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into EnrolRegister(stdId,course,edulevel,semester,year,fname) values(@stdId,@course,@edulevel,@semester,@year,@fname)", conn);
           
            cmd.Parameters.AddWithValue("@stdId", int.Parse(StudentId.Text));
            cmd.Parameters.AddWithValue("@fname", textName.Text);
            cmd.Parameters.AddWithValue("@course", textCourse.Text);
            cmd.Parameters.AddWithValue("@edulevel", textLevel.Text);
            cmd.Parameters.AddWithValue("@semester", textSemester.Text);
            cmd.Parameters.AddWithValue("@year", yearDateTime.Text);
            



            cmd.ExecuteNonQuery();
            conn.Close();

            textName.Text = "";
            textCourse.Text = "";
            textLevel.Text = "";
            textSemester.Text = "";
            yearDateTime.Text = "";

             MessageBox.Show("Are you Sure You want to Save Data", "Confirmation ", MessageBoxButtons.YesNo);
            MessageBox.Show("Inserted Succesffully");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Update EnrolRegister set stdId=@stdId, course=@course, edulevel=@edulevel, semester=@semester, year=@year, fname=@fname WHERE stdId=@stdId", conn);

            cmd.Parameters.AddWithValue("@stdId", int.Parse(StudentId.Text));
            cmd.Parameters.AddWithValue("@fname", textName.Text);
            cmd.Parameters.AddWithValue("@course", textCourse.Text);
            cmd.Parameters.AddWithValue("@edulevel", textLevel.Text);
            cmd.Parameters.AddWithValue("@semester", textSemester.Text);
            cmd.Parameters.AddWithValue("@year", yearDateTime.Text);




            cmd.ExecuteNonQuery();
            conn.Close();

            textName.Text = "";
            textCourse.Text = "";
            textLevel.Text = "";
            textSemester.Text = "";
            yearDateTime.Text = "";

            MessageBox.Show("Are you Sure You want to Update Data", "Confirmation ", MessageBoxButtons.YesNo);
            MessageBox.Show("Updated Succesffully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Delete EnrolRegister WHERE stdId=@stdId", conn);

            cmd.Parameters.AddWithValue("@stdId", int.Parse(StudentId.Text));
            cmd.Parameters.AddWithValue("@fname", textName.Text);
            cmd.Parameters.AddWithValue("@course", textCourse.Text);
            cmd.Parameters.AddWithValue("@edulevel", textLevel.Text);
            cmd.Parameters.AddWithValue("@semester", textSemester.Text);
            cmd.Parameters.AddWithValue("@year", yearDateTime.Text);




            cmd.ExecuteNonQuery();
            conn.Close();

            textName.Text = "";
            textCourse.Text = "";
            textLevel.Text = "";
            textSemester.Text = "";
            yearDateTime.Text = "";

            MessageBox.Show("Are you Sure You want to Delete Data", "Confirmation ", MessageBoxButtons.YesNo);
            MessageBox.Show("Deleted Succesffully");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from EnrolRegister WHERE fname=@fname", conn);
            cmd.Parameters.AddWithValue("@fname", textName.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EnrolldataGridView.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from EnrolRegister", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EnrolldataGridView.DataSource = dt;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage User = new HomePage();
            User.Show();
        }
    }
}
