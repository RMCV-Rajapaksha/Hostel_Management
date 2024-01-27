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


            if (PaymentID.Text == "" || StudName.Text == "" || FatherName.Text == "" || MotherName.Text == "" || AddressTb.Text == "" || CollegeTb.Text == "")
            {
                MessageBox.Show("No Empty Filled Accepted, ");
                return;
            }



            try
            {
                Con.Open();
                string query = "INSERT INTO Student_tbl VALUES (@StdUsn, @StdName, @FatherName,@MotherName,@StdAddress,@College,@StdRoom ,@StdStatus)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@StdUsn", StudUsn.Text);
                cmd.Parameters.AddWithValue("@StdName", StudName.Text);
                cmd.Parameters.AddWithValue("@FatherName", FatherName.Text);
                cmd.Parameters.AddWithValue("@MotherName", MotherName.Text);
                cmd.Parameters.AddWithValue("@StdAddress", AddressTb.Text);
                cmd.Parameters.AddWithValue("@College", CollegeTb.Text);
                cmd.Parameters.AddWithValue("@StdRoom", StudRoomCd.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@StdStatus", StduStatusCb.SelectedItem.ToString());
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
