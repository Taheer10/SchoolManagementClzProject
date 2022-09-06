using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ViewFeeEntryReport : Form
    {
        public ViewFeeEntryReport()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from FeeEntry", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            searchGridView.DataSource = dt;
        }

        private void SearchId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from FeeEntry WHERE stdenroll=@stdenroll", conn);
            cmd.Parameters.AddWithValue("@stdenroll", SearchId.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            searchGridView.DataSource = dt;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage User = new HomePage();
            User.Show();
        }
    }
}
