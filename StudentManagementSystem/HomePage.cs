using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnStdRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterStudent User = new RegisterStudent();
            User.Show();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            this.Hide();

            Enroll User = new Enroll();
            User.Show();
        }

        private void btnFeeEntry_Click(object sender, EventArgs e)
        {
            this.Hide();

            FeeEntry User = new FeeEntry();
            User.Show();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewFeeEntryReport User = new ViewFeeEntryReport();
            User.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login User = new Login();
            User.Show();
        }
    }
}
