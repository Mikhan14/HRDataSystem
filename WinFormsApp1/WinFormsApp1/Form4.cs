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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();

        }
        
        private void History_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadTableHistory();
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
            String query1 = "Select Emp_ID, Emp_name from EMPLOYEE ";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            conn.Close();
        }

        public void LoadTableHistory()
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query1 = "Select * from history";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ADD 
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            string query = "INSERT INTO History(Emp_ID, Date_of_hire, Company_name,TerminationDate,EmpStatus,Position,RecruitmentSource) " +
            "VALUES('" + this.EmpID.Text + "','" + this.DateOH.Value.Date.ToString("yyyy/MM/dd") + "','" + this.CompName.Text + "','" + this.TODate.Value.Date.ToString("yyyy/MM/dd") + "','" + this.status.SelectedItem + "','" + this.Pos.SelectedItem + "','" + this.RecSource.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            if (EmpID.Text == "")
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
                clearall();
                
            }
            //update the table after add.
            LoadTableHistory();
        }
        public void clearall()
        {
            EmpID.Text = ""; 
            CompName.Text = "";
            DateOH.Value = DateTime.Today;
            TODate.Value = DateTime.Today;
            status.SelectedItem = null;
            Pos.SelectedItem = null;
            RecSource.Text = "";
            TODate.Value = DateTime.Today;
            TODate.Enabled = true;
            status.Items.Clear();
            status.Items.Add("Active");
            status.Items.Add("Voluntary Terminated");
            status.Items.Add("Terminated");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            EmpID.Text = row.Cells["Emp_ID"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainpage = new Main();
            mainpage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        { // UPDATE RECORDS
            //Please follow-up yung pag update ng date of hire. 
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            MySql.Data.MySqlClient.MySqlCommand SqlComm = new MySql.Data.MySqlClient.MySqlCommand("UPDATE History SET  Date_of_hire=@DOH,Company_name=@cn, TerminationDate=@TD, EmpStatus=@Estatus, Position=@pos, RecruitmentSource=@recsource WHERE Emp_ID=@Emp_ID AND Date_of_hire=@DOH", conn);
            SqlComm.Parameters.AddWithValue("@Emp_ID", EmpID.Text);
            SqlComm.Parameters.AddWithValue("@DOH", DateOH.Value.Date.ToString("yyyy/MM/dd"));
            SqlComm.Parameters.AddWithValue("@cn", CompName.Text);
            SqlComm.Parameters.AddWithValue("@TD", TODate.Value.Date.ToString("yyyy/MM/dd"));
            SqlComm.Parameters.AddWithValue("@Estatus",status.SelectedItem);
            SqlComm.Parameters.AddWithValue("@recsource", RecSource.Text);
            SqlComm.Parameters.AddWithValue("@pos", Pos.SelectedItem);
            if (EmpID.Text == "" || DateOH.Text == "" || CompName.Text=="" || TODate.Text=="" ||Pos.SelectedItem == null || RecSource.Text =="")
            {
                MessageBox.Show("Please fill all the required field to continue!");
            }
            else
            {
                conn.Open();
                SqlComm.ExecuteNonQuery();
                conn.Close();
                clearall();
                LoadTableHistory();
                MessageBox.Show("Employee's History was Successfully Updated!");
            }//end else

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                //DELETE RECORDS
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                string query = "DELETE FROM History WHERE Emp_ID ='" + this.EmpID.Text + "'AND Date_of_hire='" + this.DateOH.Value.Date.ToString("yyyy/MM/dd") + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;

                DialogResult result = MessageBox.Show("Are you sure you want to delete record??", "Delete Record", MessageBoxButtons.YesNo);
                if (this.EmpID.Text != "")
                {
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        dr = cmd.ExecuteReader();
                        MessageBox.Show("Record has been deleted!!!");
                        conn.Close();
                        clearall();
                        LoadTable();
                        LoadTableHistory();
                    }
                    else
                    { }
                }
                else
                {
                    MessageBox.Show("Please select a manager to delete.");
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            EmpID.Text = row.Cells["Emp_ID"].Value.ToString();
            DateOH.Text = row.Cells["Date_of_hire"].Value.ToString();
            TODate.Text = row.Cells["Terminationdate"].Value.ToString();
            CompName.Text = row.Cells["Company_name"].Value.ToString();
            Pos.SelectedItem = row.Cells["Position"].Value.ToString();
            status.SelectedItem = row.Cells["EmpStatus"].Value.ToString();
            RecSource.Text = row.Cells["RecruitmentSource"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearall();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //TODate.Value = DateTime.MinValue; 
            status.Items.Clear();
            status.Items.Add("Active");
            TODate.Enabled = false;
            TODate.Value = new DateTime(1753, 01, 01);

        }
    }
}
