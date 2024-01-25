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

namespace Hostel_Management
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ROG\OneDrive\Documents\HostelMgmt.mdf;Integrated Security=True;Connect Timeout=30");

        string RoomBooked; // 
        void FillRoomDGV()
        {
            try
            {
                Con.Open();
                string myquery = "Select * from Room_tbl"; // Corrected the SQL query
                SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
                var ds = new DataSet();
                da.Fill(ds, "Room_tbl"); // Added the table name to fill the DataSet correctly

                RoomDGV.DataSource = ds.Tables[0]; // Corrected DataSorcery to DataSource

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RoomNumtb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
                return;
            }

            string roomstatus = (YesRadio.Checked) ? "Busy" : "Free";

            try
            {
                Con.Open();
                string query = "INSERT INTO Room_tbl VALUES (@RoomNum, @RoomStatus, @Booked)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@RoomNum", RoomNumtb.Text);
                cmd.Parameters.AddWithValue("@RoomStatus", RoomStatusCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Booked", roomstatus);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                FillRoomDGV();
                FillRoomDGV();

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NoRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (RoomNumtb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {

                Con.Open();
                String query = "Delete from Room_tbl where RoomNum=" + RoomNumtb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Deleted");
                Con.Close();
                FillRoomDGV();

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNumtb.Text = RoomDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            FillRoomDGV(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            if (RoomNumtb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                string roomstatus = (YesRadio.Checked) ? "Busy" : "Free";

                Con.Open();
                String query = "update Room_tbl set RoomStatus='"+RoomStatusCb.SelectedItem.ToString()+"',Booked='"+roomstatus+"' where RoomNum="+RoomNumtb.Text+"";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Updated");
                Con.Close();
                FillRoomDGV();

            }
        }

        private void RoomNumtb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}