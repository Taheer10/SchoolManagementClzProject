using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into StdRegister(fname,address,gender,age,contact,email,registerdate) values(@fname,@address,@gender,@age,@contact,@email,@registerdate)", conn);

            cmd.Parameters.AddWithValue("@fname", textName.Text);
            cmd.Parameters.AddWithValue("@address", textAddress.Text);
            cmd.Parameters.AddWithValue("@gender", textGender.Text);
            cmd.Parameters.AddWithValue("@age",textAge.Text);
            cmd.Parameters.AddWithValue("@contact", textContact.Text);
            cmd.Parameters.AddWithValue("@email", textEmail.Text);
            cmd.Parameters.AddWithValue("@registerdate", dateTimeRegister.Text);



            cmd.ExecuteNonQuery();
            conn.Close();

            textName.Text = "";
            textAddress.Text = "";
            textGender.Text = "";
            textAge.Text = "";
            textContact.Text = "";
            textEmail.Text = "";
            dateTimeRegister.Text = "";



            MessageBox.Show("Inserted Succesffully");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Update StdRegister set fname=@fname, address=@address, gender=@gender, age=@age, contact=@contact, email=@email, registerdate=@registerdate WHERE fname=@fname", conn);

            cmd.Parameters.AddWithValue("@fname", textName.Text);
            cmd.Parameters.AddWithValue("@address", textAddress.Text);
            cmd.Parameters.AddWithValue("@gender", textGender.Text);
            cmd.Parameters.AddWithValue("@age", textAge.Text);
            cmd.Parameters.AddWithValue("@contact", textContact.Text);
            cmd.Parameters.AddWithValue("@email", textEmail.Text);
            cmd.Parameters.AddWithValue("@registerdate", dateTimeRegister.Text);



            cmd.ExecuteNonQuery();
            conn.Close();
            textName.Text = "";
            textAddress.Text = "";
            textGender.Text = "";
            textAge.Text = "";
            textContact.Text = "";
            textEmail.Text = "";
            dateTimeRegister.Text = "";



            MessageBox.Show("Updated Succesffully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();


            SqlCommand cmd = new SqlCommand("Delete StdRegister WHERE fname=@fname", conn);
            cmd.Parameters.AddWithValue("@fname", textName.Text);
            cmd.Parameters.AddWithValue("@address", textAddress.Text);
            cmd.Parameters.AddWithValue("@gender", textGender.Text);
            cmd.Parameters.AddWithValue("@age", textAge.Text);
            cmd.Parameters.AddWithValue("@contact", textContact.Text);
            cmd.Parameters.AddWithValue("@email", textEmail.Text);
            cmd.Parameters.AddWithValue("@registerdate", dateTimeRegister.Text);



            cmd.ExecuteNonQuery();
            conn.Close();

            textName.Text = "";
            textAddress.Text = "";
            textGender.Text = "";
            textAge.Text = "";
            textContact.Text = "";
            textEmail.Text = "";
            dateTimeRegister.Text = "";



            MessageBox.Show("Deleted Succesffully");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from StdRegister WHERE fname=@fname", conn);
            cmd.Parameters.AddWithValue("@fname", textName.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from StdRegister", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage User = new HomePage();
            User.Show();
        }
    }
}
