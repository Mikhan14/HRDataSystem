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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                string query = "INSERT INTO Department(Dept_name) " +
                "VALUES('" + this.Dept.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                if (Dept.Text == "")
                {
                    MessageBox.Show("Please enter the department name first");
                }
                else
                {
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Succesfully Added!");
                    //clear all textbox and stuffs.
                    Dept.Text = "";
                }
                //update the table after add.
                LoadTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //deleting records
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            string query = "DELETE FROM Department WHERE Dept_name ='" + this.Dept.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;

            DialogResult result = MessageBox.Show("Are you sure you want to delete record??", "Delete Record", MessageBoxButtons.YesNo);
            if (this.Dept.Text != "")
            {
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Record has been deleted!!!");
                    conn.Close();
                    Dept.Text = "";
                    LoadTable();
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("Please select a department to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainpage = new Main();
            mainpage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                MySql.Data.MySqlClient.MySqlCommand SqlComm = new MySql.Data.MySqlClient.MySqlCommand("UPDATE Department SET Dept_name=@dept", conn);
                SqlComm.Parameters.AddWithValue("@dept", Dept.Text);
                if (Dept.Text == "")
                {
                    MessageBox.Show("Please select a department to edit");
                }
                else
                {
                    conn.Open();
                    SqlComm.ExecuteNonQuery();
                    conn.Close();
                    Dept.Text = "";
                    LoadTable();
                    MessageBox.Show("Department was Successfully Updated!");
                }//end else
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Department_Load(object sender, EventArgs e)
        {
            LoadTable(); 
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
        public void LoadTable()
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query1 = "Select * from Department";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            TempTable.DataSource = dt1;
            conn.Close();
        }

        private void Dept_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ony accepts letters
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
    }

        private void TempTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.TempTable.Rows[e.RowIndex];
            Dept.Text = row.Cells["Dept_name"].Value.ToString();
        }

        private void TempTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
