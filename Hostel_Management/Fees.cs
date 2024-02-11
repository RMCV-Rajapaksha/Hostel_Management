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

namespace Hostel_Management
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ROG\OneDrive\Documents\HostelMgmt.mdf;Integrated Security=True;Connect Timeout=30");

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (PaymentID.Text == "" || comboBox3.Text == "" || maskedTextBox2.Text == "" || comboBox1.Text == "" || dateTimePicker1.Text == "" || maskedTextBox3.Text == "")
            {
                MessageBox.Show("No Empty Filled Accepted, ");
                return;
            }



            try
            {
                Con.Open();
                string query = "INSERT INTO Fees_tbl VALUES (@PaymentId, @StudentUSN, @Studentname,@StdRoom,@PaymntMonth,@College,@Amount )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@PaymentId", PaymentID.Text);
                cmd.Parameters.AddWithValue("@StudentUSN", comboBox3.Text);
                cmd.Parameters.AddWithValue("@Studentname", maskedTextBox2.Text);
                cmd.Parameters.AddWithValue("@StdRoom", comboBox1.Text);
                cmd.Parameters.AddWithValue("@PaymntMonth", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@College", maskedTextBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
              //  FillStudentDGV();

            }
        }
    }
}
