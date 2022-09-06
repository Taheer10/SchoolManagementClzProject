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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AttachEventListeners();
        }

        public void AttachEventListeners()
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from  LOGIN where username = '" + TextUser.Text + "'and password = '" + TextPassword.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                HomePage home = new HomePage();
                home.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct data");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextUser.Text = "";
            TextPassword.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddUser User = new AddUser();
            User.Show();
        }
    }
}
