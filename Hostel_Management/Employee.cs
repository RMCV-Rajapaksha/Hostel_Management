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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
       SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ROG\OneDrive\Documents\HostelMgmt.mdf;Integrated Security=True;Connect Timeout=30");

        void FillEmployeeDGV()
        {
            try
            {
                Con.Open();
                string myquery = "Select * from Employee_tbl"; // Corrected the SQL query
                SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
                var ds = new DataSet();
                da.Fill(ds, "Student_tbl"); // Added the table name to fill the DataSet correctly

                EmployeeDGV.DataSource = ds.Tables[0]; // Corrected DataSorcery to DataSource

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

            if (EmpNametb.Text == "" || EmpIdTb.Text == "" || EmpPhoneTb.Text == "" )
            {
                MessageBox.Show("No Empty Filled Accepted, ");
                return;
            }



            try
            {
                Con.Open();
                string query = "INSERT INTO Employee_tbl VALUES (@EmpId, @EmpName, @EmpPhone ,@EmpAddress ,@EmpPos ,@EmpStatus)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@EmpId", EmpIdTb.Text);
                cmd.Parameters.AddWithValue("@EmpName", EmpNametb.Text);
                cmd.Parameters.AddWithValue("@EmpPhone", EmpPhoneTb.Text);
                cmd.Parameters.AddWithValue("@EmpAddress", EmpAddTb.Text);
                cmd.Parameters.AddWithValue("@EmpPos", EmpPositionCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@EmpStatus", EmpStatusCb.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                FillEmployeeDGV();

            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            FillEmployeeDGV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIdTb.Text = EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNametb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpAddTb.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
          EmpPositionCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmpStatusCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter The Employee ID");
            }
            else
            {

                Con.Open();
                String query = "Delete from Employee_tbl where EmpId= '" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Deleted");
                Con.Close();
                FillEmployeeDGV();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (EmpIdTb.Text == "" ||(EmpNametb.Text == "" || EmpIdTb.Text == "" || EmpPhoneTb.Text == "") || EmpStatusCb.SelectedItem.ToString()=="" || EmpStatusCb.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Fill All the Informtion");
            }
            else
            {

                Con.Open();
                String query = "update Employee_tbl set EmpName='" + EmpNametb.Text + "',EmpPhone='" + EmpPhoneTb.Text + "',EmpAddress='" + EmpAddTb.Text + "', EmpPos='"+EmpPositionCb.SelectedItem.ToString()+"', EmpStatus='" + EmpStatusCb.SelectedItem.ToString() + "' where EmpId='"+EmpIdTb.Text+"' ";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Updated");
                Con.Close();
                FillEmployeeDGV();

            }
        }

        private void EmpIdTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
