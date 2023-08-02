using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string server;
        string database;
        string username;
        string password;
        string constring;
        public void databaseOpen()
        {
            server = "localhost";
            database = "hrdatasys";
            username = "root";
            password = "";
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
        }
        public void getEmpID()
        {
            //get the emp ID
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query2 = "SELECT MAX(Manager_ID)+1 FROM Manager";
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                //set the next emp id from max
                mgrID.Text = reader2.GetValue(0).ToString();

            }
            if (mgrID.Text == "")
            {
                mgrID.Text = 1.ToString();
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query1 = "Select * From Manager ";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            conn.Close();

            getEmpID();

            conn.Close();
            //get department names
            conn.Open();
            String query = "Select * from Department";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                department.Items.Add(reader.GetValue(0).ToString());
            }
            conn.Close();
        }
        public void clearall()
        {
            mgrName.Text = "";
            department.SelectedItem = null;
            getEmpID();
        }


        public void LoadTable()
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query1 = "Select * from Manager";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            mgrID.Text = row.Cells["Manager_ID"].Value.ToString();
            mgrName.Text = row.Cells["Manager_name"].Value.ToString();
            department.SelectedItem = row.Cells["Department"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mgrID_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            string query = "INSERT INTO Manager(Manager_ID, Manager_name, Department) " +
            "VALUES('" + this.mgrID.Text + "','" + this.mgrName.Text + "','" + this.department.SelectedItem + "')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            if (mgrID.Text == "" || mgrName.Text == "" || department.SelectedItem == null)
            {
                MessageBox.Show("Please enter the Manager name first");
            }
            else
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Succesfully Added!");
                //clear all textbox and stuffs.
                clearall();
                
            }
            //update the table after add.
            LoadTable();
        }

        private void update_Click(object sender, EventArgs e)
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            MySql.Data.MySqlClient.MySqlCommand SqlComm = new MySql.Data.MySqlClient.MySqlCommand("UPDATE Manager SET Manager_name=@name, Department=@dept WHERE Manager_ID=@mgrID", conn);
            SqlComm.Parameters.AddWithValue("@mgrID", mgrID.Text);
            SqlComm.Parameters.AddWithValue("@name", mgrName.Text);
            SqlComm.Parameters.AddWithValue("@dept", department.SelectedItem);
            if (mgrID.Text == "" || mgrName.Text =="")
            {
                MessageBox.Show("Please select a Manager to edit");
            }
            else if (department.SelectedItem == null)
            {
                MessageBox.Show("It seems that your manager doesn't have a department. Please delete the record or try again.");
            }
            else
            {
                conn.Open();
                SqlComm.ExecuteNonQuery();
                conn.Close();
                clearall();
                LoadTable();
                MessageBox.Show("Manager was Successfully Updated!");
            }//end else
        }

        private void del_Click(object sender, EventArgs e)
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            string query = "DELETE FROM Manager WHERE Manager_ID ='" + this.mgrID.Text + "'AND Department='"+this.department.SelectedItem+"'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            DialogResult result = MessageBox.Show("Are you sure you want to delete record??", "Delete Record", MessageBoxButtons.YesNo);
            if (this.mgrID.Text != "")
            {
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Record has been deleted!!!");
                    conn.Close();
                    clearall();
                    LoadTable();
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("Please select a manager to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainpage = new Main();
            mainpage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mgrName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
