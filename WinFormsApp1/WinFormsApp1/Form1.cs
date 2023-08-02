namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            timer1.Start();
            Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpMng Emp = new EmpMng();
            Emp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            Time.Text = datetime.ToString("hh:mm:ss tt");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department Dept = new Department();
            Dept.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            History History = new History();
            History.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Managers = new Form5();
            Managers.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ShowManager = new Form6();
            ShowManager.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Showall = new Form7();
            Showall.Show();
        }
    }
}