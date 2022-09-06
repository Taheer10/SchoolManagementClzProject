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
    public partial class FeeEntry : Form
    {
        public FeeEntry()
        {
            InitializeComponent();

          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (StudentId.Text != "" || textName.Text != "" || textCourse.Text != "" || textFee.Text == "" || textDiscount.Text == "" || textDue.Text == "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into FeeEntry(fee,dueamount,discount,stdenroll,paymentDate,fname,course,edulevel,totalamount) values(@fee,@dueamount,@discount,@stdenroll,@paymentDate,@fname,@course,@edulevel,@totalamount)", conn);

                cmd.Parameters.AddWithValue("@stdenroll", StudentId.Text);
                cmd.Parameters.AddWithValue("@fname", textName.Text);
                cmd.Parameters.AddWithValue("@course", textCourse.Text);
                cmd.Parameters.AddWithValue("@edulevel", textLevel.Text);
                cmd.Parameters.AddWithValue("@fee", textFee.Text);
                cmd.Parameters.AddWithValue("@discount", textDiscount.Text);
                cmd.Parameters.AddWithValue("@dueamount", textDue.Text);
                cmd.Parameters.AddWithValue("@totalamount", textTotalAmount.Text);
                cmd.Parameters.AddWithValue("@paymentdate", paymentDate.Text);



                cmd.ExecuteNonQuery();
                conn.Close();

                textName.Text = "";
                textCourse.Text = "";
                textLevel.Text = "";
                StudentId.Text = "";
                paymentDate.Text = "";
                textFee.Text = "";
                textDiscount.Text = "";
                textDue.Text = "";
                textTotalAmount.Text = "";



                MessageBox.Show("Are you Sure You want to Save Data", "Confirmation ", MessageBoxButtons.YesNo);
                MessageBox.Show("Inserted Succesffully");
            }
            else
            {
                MessageBox.Show("Please Enter Data");

            }

        }

        private void FeeEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet7.EnrolRegister' table. You can move, or remove it, as needed.
            this.enrolRegisterTableAdapter3.Fill(this.studentManagementSystemDataSet7.EnrolRegister);
            this.enrolRegisterTableAdapter2.Fill(this.studentManagementSystemDataSet6.EnrolRegister);
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet5.EnrolRegister' table. You can move, or remove it, as needed.
            this.enrolRegisterTableAdapter1.Fill(this.studentManagementSystemDataSet5.EnrolRegister);
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet4.EnrolRegister' table. You can move, or remove it, as needed.
            this.enrolRegisterTableAdapter.Fill(this.studentManagementSystemDataSet4.EnrolRegister);
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet3.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter1.Fill(this.studentManagementSystemDataSet3.StdRegister);
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet2.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter.Fill(this.studentManagementSystemDataSet2.StdRegister);

        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(StudentId.Text == "" || textName.Text=="" || textCourse.Text == "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("update FeeEntry set fee=@fee, dueamount=@dueamount, discount=@discount, stdenroll=@stdenroll, paymentDate=@paymentDate, fname=@fname, course=@course, edulevel=@edulevel, totalamount=@totalamount" , conn);

                cmd.Parameters.AddWithValue("@stdenroll", StudentId.Text);
                cmd.Parameters.AddWithValue("@fname", textName.Text);
                cmd.Parameters.AddWithValue("@course", textCourse.Text);
                cmd.Parameters.AddWithValue("@edulevel", textLevel.Text);
                cmd.Parameters.AddWithValue("@fee", textFee.Text);
                cmd.Parameters.AddWithValue("@discount", textDiscount.Text);
                cmd.Parameters.AddWithValue("@dueamount", textDue.Text);
                cmd.Parameters.AddWithValue("@totalamount", textTotalAmount.Text);
                cmd.Parameters.AddWithValue("@paymentdate", paymentDate.Text);



                cmd.ExecuteNonQuery();
                conn.Close();

                textName.Text = "";
                textCourse.Text = "";
                textLevel.Text = "";
                StudentId.Text = "";
                paymentDate.Text = "";
                textFee.Text = "";
                textDiscount.Text = "";
                textDue.Text = "";
                textTotalAmount.Text = "";


                MessageBox.Show("Are you Sure You want to Save Data", "Confirmation ", MessageBoxButtons.YesNo);
                MessageBox.Show("Updated Succesffully");
            }
            else
            {
                MessageBox.Show("Please Enter Data");

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TAHIR\SQLEXPRESS;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Delete FeeEntry WHERE stdenroll=@stdenroll", conn);

            cmd.Parameters.AddWithValue("@stdenroll", StudentId.Text);
            cmd.Parameters.AddWithValue("@fname", textName.Text);
            cmd.Parameters.AddWithValue("@course", textCourse.Text);
            cmd.Parameters.AddWithValue("@edulevel", textLevel.Text);
            cmd.Parameters.AddWithValue("@fee", textFee.Text);
            cmd.Parameters.AddWithValue("@discount", textDiscount.Text);
            cmd.Parameters.AddWithValue("@dueamount", textDue.Text);
            cmd.Parameters.AddWithValue("@totalamount", textTotalAmount.Text);
            cmd.Parameters.AddWithValue("@paymentDate", paymentDate.Text);



            cmd.ExecuteNonQuery();
            conn.Close();

            textName.Text = "";
            textCourse.Text = "";
            textLevel.Text = "";
            StudentId.Text = "";
            paymentDate.Text = "";
            textFee.Text = "";
            textDiscount.Text = "";
            textDue.Text = "";
            textTotalAmount.Text = "";



            MessageBox.Show("Are you Sure You want to Delete Data", "Confirmation ", MessageBoxButtons.YesNo);
            MessageBox.Show("Deleted Succesffully");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage User = new HomePage();
            User.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            ViewFeeEntryReport User = new ViewFeeEntryReport();
            User.Show();
        }

        public int total;
        private void textFee_TextChanged(object sender, EventArgs e)
        {
        }

        private void textDiscount_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void textDue_TextChanged(object sender, EventArgs e)
        {
           
                try
                {
                    textTotalAmount.Text = (int.Parse(textFee.Text) + int.Parse(textDue.Text) - int.Parse(textDiscount.Text)).ToString();
                }
                catch
                {
                 //test  
                }
               
            
        }
    }
}
