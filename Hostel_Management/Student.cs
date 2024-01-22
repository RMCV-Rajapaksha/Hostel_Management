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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ROG\OneDrive\Documents\HostelMgmt.mdf;Integrated Security=True;Connect Timeout=30");

        void FillStudentDGV()
        {
            try
            {
                Con.Open();
                string myquery = "Select * from Student_tbl"; // Corrected the SQL query
                SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
                var ds = new DataSet();
                da.Fill(ds, "Student_tbl"); // Added the table name to fill the DataSet correctly

                StudentDGV.DataSource = ds.Tables[0]; // Corrected DataSorcery to DataSource

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void FillRoomCombobox()
        {
            Con.Open();
            String query = "Select * from Room_tbl where RoomStatus='"+"Active"+"'and Booked ='"+"Free"+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNum", typeof(int));
            dt.Load(rdr);
            StudRoomCd.ValueMember = "RoomNum";
            StudRoomCd.DataSource = dt; 

            Con.Close();
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (StudUsn.Text == "")
            {
                MessageBox.Show("Enter The Student Number");
            }
            else
            {
               
                Con.Open();
                String query = "update Student_tbl set StdName='" + StudName.Text + "',FatherName='" + FatherName.Text + "',MotherName='" + MotherName.Text + "',StdAddress='" + AddressTb.Text + "',College='" + CollegeTb.Text + "', StdRoom=" + (StudRoomCd.SelectedValue != null ? StudRoomCd.SelectedValue.ToString() : "NULL") + ",StdStatus=" + (StduStatusCb.SelectedValue != null ? StduStatusCb.SelectedValue.ToString() : "NULL") + " where StdUsn='" + StudUsn.Text + "' ";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Updated");
                Con.Close();
                FillStudentDGV();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StudUsn.Text == "")
            {
                MessageBox.Show("Enter The Student Number");
            }
            else
            {

                Con.Open();
                String query = "Delete from Student_tbl where StdUsn= '" + StudUsn.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Deleted");
                Con.Close();
                FillStudentDGV();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Student_Load(object sender, EventArgs e)
        {
            FillStudentDGV();
            FillRoomCombobox();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            FillStudentDGV();
        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (StudUsn.Text == "" || StudName.Text=="" || FatherName.Text=="" || MotherName.Text=="" || AddressTb.Text == "" || CollegeTb.Text=="" )
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
                FillStudentDGV();

            }
        }

        private void StduStatusCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudUsn.Text = StudentDGV.SelectedRows[0].Cells[0].Value.ToString();
            StudName.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            FatherName.Text = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();
            MotherName.Text = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            AddressTb.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
            CollegeTb.Text = StudentDGV.SelectedRows[0].Cells[5].Value.ToString();

        }
    }
}
