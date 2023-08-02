using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class EmpMng : Form
    {
        public EmpMng()
        {
            
            InitializeComponent();
            FullName.Select();
            //Textbox UI
            FullName.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            State.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            Zip.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            Salary.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            Absences.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            ManagerID.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            EmpID.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            
        }
        //for sql
        string server;
        string database;
        string username;
        string password;
        string constring;
        //for gender and civstat
        string gender = "";
        string civstat = "";
        public void databaseOpen()
        {
            server = "localhost";
            database = "hrdatasys";
            username = "root";
            password = "";
            constring = "SERVER=" + server +";" + "DATABASE=" + database + ";"+"UID="+username+";"+"PASSWORD="+password+ ";";

        }

        public void getMngID()
        {
            //for update and delete only.
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query1 = "SELECT * FROM Manager WHERE Manager_ID='" + ManagerID.Text + "';";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                Manager.Text = reader1.GetValue(1).ToString();
            }
            conn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //add data
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                string query = "INSERT INTO employee(Emp_ID, Emp_name, Birthdate, Sex, State, Zip, Absences, Salary, Manager_ID, Civil_status,Department) " +
                    "VALUES('" + this.EmpID.Text + "', '" + this.FullName.Text + "', '" + this.bday.Value.Date.ToString("yyyy/MM/dd") + "', '" + this.gender + "', '" + this.State.Text + "', '" + this.Zip.Text + "', '" + this.Absences.Text + "', '" + this.Salary.Text + "', '" + this.ManagerID.Text + "', '" + this.civstat + "', '" + this.Department.SelectedItem.ToString() + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                if (EmpID.Text == "" || FullName.Text == "" || gender == "" || State.Text == "" || Zip.Text == "" || Absences.Text == "" || Salary.Text == "" || ManagerID.Text == "" || civstat == "" || Department.SelectedItem == null)
                {
                    MessageBox.Show("Please, answer all the following fields.");
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
                updateTable();
            }//end try
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void FullName_Enter(object sender, EventArgs e)
        {
            //what happened here is sinet ko yung focus sa fullname textbox after maload ng form. Then since nandon yung focus ,idididsplay nya agad yung table.
            //update: May Load event pala dapat dun na lang 'to
            //display the table
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query = "Select * from Employee";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            TempTable.DataSource = dt;
            conn.Close();
        }

        private void EmpMng_Load(object sender, EventArgs e)
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            //To get the department names
            conn.Open();
            String query = "Select department from Manager WHERE Manager_ID='" + ManagerID.Text + "' Group By department";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Department.Items.Add(reader.GetValue(0).ToString());
            }
            conn.Close();
            // to get the manager names
            conn.Open();
            String query1 = "Select Manager_name from Manager Group By Manager_name";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                Manager.Items.Add(reader1.GetValue(0).ToString());
            }
            conn.Close();
            //to get the next EMP ID
            conn.Open();
            String query2 = "SELECT MAX(Emp_ID)+1 FROM Employee";
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                //set the next emp id from max
                EmpID.Text = reader2.GetValue(0).ToString();
                
            }
            if (EmpID.Text == "")
            {
                EmpID.Text = 1.ToString();
            }

            conn.Close();
        }



        private void Department_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Manager_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to get Manager ID
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query1 = "SELECT * FROM Manager WHERE Manager_name='" + Manager.Text + "';";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                ManagerID.Text = reader1.GetValue(0).ToString();
            }
            conn.Close();
        }




        private void Zip_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //only accepts number input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void State_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ony accepts letters
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ony accepts letters
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only accepts number input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
            Femaletxt.Checked = false;

        }

        private void Femaletxt_CheckedChanged(object sender, EventArgs e)
        {
            Maletxt.Checked = false;
            gender = "F";
        }

        private void Single_CheckedChanged(object sender, EventArgs e)
        {
            civstat = "Single"; 
        }

        private void Married_CheckedChanged(object sender, EventArgs e)
        {
            civstat = "Married";
        }

        private void Divorced_CheckedChanged(object sender, EventArgs e)
        {
            civstat = "Divorced";
        }

        private void Widowed_CheckedChanged(object sender, EventArgs e)
        {
            civstat = "Widowed";
        }

        private void Separated_CheckedChanged(object sender, EventArgs e)
        {
            civstat = "Separated";
        }

        private void Absences_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only accepts number input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void TempTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //update here
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                MySql.Data.MySqlClient.MySqlCommand SqlComm = new MySql.Data.MySqlClient.MySqlCommand("UPDATE Employee SET Emp_name=@Fullname, Birthdate=@b_day, Sex=@sex,State=@State, Zip=@Zip, Absences=@Absences, Salary=@Salary, Manager_ID=@MgrID,Civil_status=@civstatus, Department=@Dept WHERE Emp_ID=@EmpID", conn);

                if (EmpID.Text == "" || FullName.Text == "" || gender == "" || State.Text == "" || Zip.Text == "" || Absences.Text == "" || Salary.Text == "" || ManagerID.Text == "" || civstat == "" || Department.SelectedItem == null)
                {
                    MessageBox.Show("Please, answer all the following fields.");
                }
                else
                {
                    SqlComm.Parameters.AddWithValue("@EmpID", EmpID.Text);
                    SqlComm.Parameters.AddWithValue("@Fullname", FullName.Text);
                    SqlComm.Parameters.AddWithValue("@b_day", bday.Value.Date.ToString("yyyy/MM/dd"));
                    SqlComm.Parameters.AddWithValue("@sex", gender);
                    SqlComm.Parameters.AddWithValue("@State", State.Text);
                    SqlComm.Parameters.AddWithValue("@Zip", Zip.Text);
                    SqlComm.Parameters.AddWithValue("@Absences", Absences.Text);
                    SqlComm.Parameters.AddWithValue("@Salary", Salary.Text);
                    SqlComm.Parameters.AddWithValue("@MgrID", ManagerID.Text);
                    SqlComm.Parameters.AddWithValue("@civstatus", civstat);
                    SqlComm.Parameters.AddWithValue("@Dept", Department.SelectedItem.ToString());
                    //SqlComm.Parameters.AddWithValue("@recsource", recsource.Text);
                    //SqlComm.Parameters.AddWithValue("@doh", dateofhire.Value.Date.ToString("yyyy/MM/dd"));
                    //SqlComm.Parameters.AddWithValue("@pos", position.SelectedItem.ToString());

                    conn.Open();
                    SqlComm.ExecuteNonQuery();
                    conn.Close();
                    clearall();
                    updateTable();
                    MessageBox.Show("Employee was Successfully Updated!");
                }//end else
            }//end try
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }//end catch
        }
        public void getManagername()
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            //To get the department names
            conn.Open();
            String query = "Select * from Manager WHERE Manager_ID='" + ManagerID.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Manager.Text = reader.GetValue(2).ToString();
            }
            conn.Close();
        }
        public void clearall()
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            //clear all textbox and stuffs.
            EmpID.Text = "";
            FullName.Text = "";
            gender = "";
            Maletxt.Checked = false;
            Femaletxt.Checked = false;
            State.Text = "";
            Zip.Text = "";
            Department.SelectedItem = null;
            Absences.Text = "";
            Salary.Text = "";
            ManagerID.Text = "";
            Manager.SelectedItem = null;
            civstat = "";
            Single.Checked = false;
            Widowed.Checked = false;
            Married.Checked = false;
            Separated.Checked = false;
            Divorced.Checked = false;
            //recsource.Text = "";
            //position.SelectedItem = null;
            bday.Value = DateTime.Today;
            //dateofhire.Value = DateTime.Today;


            //get the emp.ID cuz mahalaga itu
            conn.Open();
            String query2 = "SELECT MAX(Emp_ID)+1 FROM Employee";
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                //set the next emp id from max
                EmpID.Text = reader2.GetValue(0).ToString();

            }
            if (EmpID.Text == "")
            {
                EmpID.Text = 1.ToString();
            }
            conn.Close();
        }
        public void updateTable()
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query1 = "Select * from Employee";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            TempTable.DataSource = dt1;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainpage = new Main(); 
            mainpage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //deleting records
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                string query = "DELETE FROM employee WHERE Emp_ID ='" + this.EmpID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;

                DialogResult result = MessageBox.Show("Are you sure you want to delete record??", "Delete Record", MessageBoxButtons.YesNo);
                if (EmpID.Text == "")
                {
                    MessageBox.Show("Please select an employee to delete first.");
                }
                else
                {
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        dr = cmd.ExecuteReader();
                        MessageBox.Show("Record has been deleted!!!");
                        conn.Close();
                        clearall();
                        updateTable();
                    }
                    else
                    {

                    }
                }
            }//end try
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

    }

        private void Zip_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TempTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //when clicked
            DataGridViewRow row = this.TempTable.Rows[e.RowIndex];
            EmpID.Text = row.Cells["Emp_ID"].Value.ToString();
            FullName.Text = row.Cells["Emp_name"].Value.ToString();
            string seggs = row.Cells["Sex"].Value.ToString();
            if (seggs == "M")
            {
                Maletxt.Checked = true;
            }
            else if (seggs == "F")
            {
                Femaletxt.Checked = true;
            }
            else
            {
                MessageBox.Show("The selected Employee has no recorded gender.");
            }
            bday.Text = row.Cells["Birthdate"].Value.ToString(); // eto
            State.Text = row.Cells["State"].Value.ToString();
            Zip.Text = row.Cells["Zip"].Value.ToString();
            Absences.Text = row.Cells["Absences"].Value.ToString();
            Salary.Text = row.Cells["Salary"].Value.ToString();
            ManagerID.Text = row.Cells["Manager_ID"].Value.ToString();
            Department.SelectedItem = row.Cells["Department"].Value.ToString();
            //dateofhire.Text = row.Cells["Dateofhire"].Value.ToString();
            //recsource.Text = row.Cells["RecruitmentSource"].Value.ToString();
            //position.SelectedItem = row.Cells["Position"].Value.ToString();
            
            //to get Dept
            getMngID();
            
            string civilstatus = row.Cells["civil_status"].Value.ToString();
            if (civilstatus == "Single")
            {
                Single.Checked = true;
            }
            else if (civilstatus == "Married")
            {
                Married.Checked = true;
            }
            if (civilstatus == "Divorced")
            {
                Divorced.Checked = true;
            }
            if (civilstatus == "Widowed")
            {
                Widowed.Checked = true;
            }
            if (civilstatus == "Separated")
            {
                Separated.Checked = true;
            }
            getManagername();
        }

        private void ManagerID_TextChanged(object sender, EventArgs e)
        {
            Department.Items.Clear();
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            //To get the department names
            conn.Open();
            String query = "Select department from Manager WHERE Manager_ID='" + ManagerID.Text + "' Group By department";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Department.Items.Add(reader.GetValue(0).ToString());
            }
            conn.Close();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            History History = new History();
            History.Show(); 
        }
    }
}

