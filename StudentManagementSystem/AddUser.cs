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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace StudentManagementSystem
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            if(NewUser.Text == "" || NewPassword.Text == "")
            {
                MessageBox.Show("Please Enter Data to insert");
            }

            else
            {
                SqlCommand cmd = new SqlCommand("insert into Login(username,password) values(@username,@password)", conn);

                cmd.Parameters.AddWithValue("@username", NewUser.Text);
                cmd.Parameters.AddWithValue("@password", NewPassword.Text);





                cmd.ExecuteNonQuery();
                conn.Close();

                NewUser.Text = "";
                NewPassword.Text = "";


                MessageBox.Show("Inserted SUccesffully");
            }
        }
    }
}
