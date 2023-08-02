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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        //for sql
        string server;
        string database;
        string username;
        string password;
        string constring;
        //for gender and civstat
        public void databaseOpen()
        {
            server = "localhost";
            database = "hrdatasys";
            username = "root";
            password = "";
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

        }
        int butnum;
        private void Form7_Load(object sender, EventArgs e)
        {
            loadOrig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            butnum = 1;
            show.Text = "Display the name, salary, department, and manager id of the employees in Production and Software Engineering if their salary is between 60k and 80k. "; 
        }

        private void button3_Click(object sender, EventArgs e)
        { // easy 1

            if (butnum == 1)
            {
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                String query1;
                query1 = "SELECT Emp_name, Salary,Department,Manager_ID FROM employee WHERE Department IN ('Production', 'Software Engineering') AND Salary BETWEEN 60000 AND 80000";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else if (butnum == 2)
            {
                //easy 2
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                String query1;
                query1 = "SELECT COUNT(Emp_name) FROM employee WHERE Civil_status = 'Single' AND Absences > 15";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();

            }
            else if (butnum == 3)
            {
                //inter 1
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                String query1;
                query1 = "SELECT SUM(Salary), EmpStatus FROM Employee E, History H WHERE E.Emp_ID = H.Emp_ID AND Salary > 50000 GROUP BY EmpStatus";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else if (butnum == 4)
            { // inter 2
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                String query1;
                query1 = "SELECT Department, MIN(Salary), MAX(Salary) FROM Employee GROUP BY Department";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else if (butnum == 5)
            {
                //inter 3
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                string query1;
                query1 = "SELECT Emp_name, State, Civil_status FROM employee WHERE State = 'MA' HAVING Civil_status IN ('Married', 'Widowed', 'Divorced') ORDER BY 1 ";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else if (butnum == 6)
            {
                //adv 1
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                String query1;
                query1 = "SELECT Emp_ID, Emp_name, E.Manager_ID,Manager_name FROM employee E, manager M WHERE E.Manager_ID = M.Manager_ID AND Manager_name LIKE ('Michael%')";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else if (butnum == 7)
            {
                //adv 2
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                String query1;
                query1 = "SELECT Manager_name, E.Department, Civil_status, Count(*) FROM manager M, employee E, history H WHERE (E.Manager_ID = M.Manager_ID AND E.Emp_ID = H.Emp_ID) AND H.EmpStatus LIKE '%Active%' GROUP BY Manager_name HAVING Civil_status = 'Married' ORDER BY 1";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else if (butnum == 8)
            {
                //adv 3
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                String query1;
                query1 = "SELECT COUNT(*), Department,Salary FROM employee E, history H WHERE E.Emp_ID = H.Emp_ID AND EmpStatus = 'Active' AND Absences > 10 AND Salary > 60000 GROUP BY Department ORDER BY department";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else if (butnum == 9)
            {
                databaseOpen();
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                String query1;
                query1 = "SELECT COUNT(*) as Count, SUM(Salary) as TotalSalary, Department, EmpStatus FROM employee E, History H WHERE (E.Emp_ID = H.Emp_ID) AND (Date_of_Hire LIKE '%2011%' AND EmpStatus = 'Active')  GROUP BY Department ORDER BY 1;";

                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataAdapter da1 = new MySqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else//SELECT COUNT(*) as Count, SUM(Salary) as TotalSalary, Department, EmpStatus FROM employee E, history H WHERE E.Emp_ID = H.Emp_ID AND Date_of_hire LIKE '%2011%' GROUP BY EmpStatus HAVING EmpStatus = 'Active' ORDER BY 1
            {
                MessageBox.Show("Please clear the selection first.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //clear selection
            show.Text = "";
            butnum = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            loadOrig();
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //easy 2
            button2.Enabled = false;
            butnum = 2;
            show.Text = "Count how many employees are Single and has more than 15 absences. ";
        }
        public void loadOrig()
        {
            databaseOpen();
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            String query1;
            query1 = "Select * from Employee";

            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            butnum = 3;
            button5.Enabled = false;
            show.Text = "Display the sum of salary for each employment status if their Salary is greater than 50k.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            butnum = 4;
            button6.Enabled = false;
            show.Text = "List the maximum and minimum salary in each department. ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            butnum = 5;
            button7.Enabled = false;
            show.Text = "List the employees residing in the state of Massachusetts that are Married, Widowed, or Divorced. Display their marital description as well. ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            butnum = 6;
            button8.Enabled = false;
            show.Text = "Display the emp id, employee name, manager id, and manager name of employees handled by Michael Albert.  ";
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            butnum = 7;
            button9.Enabled = false;
            show.Text = "Count how many married employees are handled by each manager. Include the manager’s name and the department in the display with the count. Do not include terminated employees. Sort the result by Manager name. ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            butnum = 8;
            button10.Enabled = false;
            show.Text = "Display the total amount of salary and the count of all active employees with over ten absences in every department. Only include those who have salaries greater than 60,000. Sort the result by department.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            butnum = 9;
            button11.Enabled = false;
            show.Text = "Display the total salary of all the Active employees in each department who were hired in the year 2011. Display also the count of these employees who satisfy these criteria.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainpage = new Main();
            mainpage.Show();
        }
    }
}
