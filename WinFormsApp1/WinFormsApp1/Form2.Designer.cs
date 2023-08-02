namespace WinFormsApp1
{
    partial class EmpMng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpMng));
            this.FullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.ComboBox();
            this.Absences = new System.Windows.Forms.TextBox();
            this.Absenceslbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Manager = new System.Windows.Forms.ComboBox();
            this.ManagerID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Separated = new System.Windows.Forms.RadioButton();
            this.Widowed = new System.Windows.Forms.RadioButton();
            this.Divorced = new System.Windows.Forms.RadioButton();
            this.Married = new System.Windows.Forms.RadioButton();
            this.Single = new System.Windows.Forms.RadioButton();
            this.TempTable = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Maletxt = new System.Windows.Forms.CheckBox();
            this.Femaletxt = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullName.Location = new System.Drawing.Point(99, 379);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(193, 23);
            this.FullName.TabIndex = 1;
            this.FullName.Enter += new System.EventHandler(this.FullName_Enter);
            this.FullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fullname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(161, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "LN, FN, MI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(299, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee ID:";
            // 
            // EmpID
            // 
            this.EmpID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpID.Enabled = false;
            this.EmpID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpID.Location = new System.Drawing.Point(402, 379);
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Size = new System.Drawing.Size(107, 23);
            this.EmpID.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(21, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth:";
            // 
            // bday
            // 
            this.bday.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bday.Location = new System.Drawing.Point(124, 448);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(168, 27);
            this.bday.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(305, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sex:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(21, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "State:";
            // 
            // State
            // 
            this.State.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.State.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.State.Location = new System.Drawing.Point(73, 493);
            this.State.MaxLength = 2;
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(60, 23);
            this.State.TabIndex = 16;
            this.State.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.State_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(20, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Zip: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Zip
            // 
            this.Zip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Zip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Zip.Location = new System.Drawing.Point(64, 540);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(69, 23);
            this.Zip.TabIndex = 19;
            this.Zip.TextChanged += new System.EventHandler(this.Zip_TextChanged);
            this.Zip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Zip_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(416, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Department:";
            // 
            // Department
            // 
            this.Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Department.FormattingEnabled = true;
            this.Department.Location = new System.Drawing.Point(508, 541);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(176, 28);
            this.Department.TabIndex = 21;
            this.Department.SelectedIndexChanged += new System.EventHandler(this.Department_SelectedIndexChanged);
            // 
            // Absences
            // 
            this.Absences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Absences.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Absences.Location = new System.Drawing.Point(241, 540);
            this.Absences.Name = "Absences";
            this.Absences.Size = new System.Drawing.Size(150, 23);
            this.Absences.TabIndex = 24;
            this.Absences.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Absences_KeyPress);
            // 
            // Absenceslbl
            // 
            this.Absenceslbl.AutoSize = true;
            this.Absenceslbl.BackColor = System.Drawing.Color.Transparent;
            this.Absenceslbl.Location = new System.Drawing.Point(161, 541);
            this.Absenceslbl.Name = "Absenceslbl";
            this.Absenceslbl.Size = new System.Drawing.Size(74, 20);
            this.Absenceslbl.TabIndex = 25;
            this.Absenceslbl.Text = "Absences:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(161, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Salary: ";
            // 
            // Salary
            // 
            this.Salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Salary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Salary.Location = new System.Drawing.Point(223, 490);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(167, 23);
            this.Salary.TabIndex = 27;
            this.Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salary_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(416, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Manager:";
            // 
            // Manager
            // 
            this.Manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Manager.FormattingEnabled = true;
            this.Manager.Location = new System.Drawing.Point(508, 488);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(176, 28);
            this.Manager.TabIndex = 29;
            this.Manager.SelectedIndexChanged += new System.EventHandler(this.Manager_SelectedIndexChanged);
            // 
            // ManagerID
            // 
            this.ManagerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManagerID.Enabled = false;
            this.ManagerID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManagerID.Location = new System.Drawing.Point(627, 376);
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.ReadOnly = true;
            this.ManagerID.Size = new System.Drawing.Size(94, 23);
            this.ManagerID.TabIndex = 31;
            this.ManagerID.TextChanged += new System.EventHandler(this.ManagerID_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(534, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Manager ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Separated);
            this.groupBox2.Controls.Add(this.Widowed);
            this.groupBox2.Controls.Add(this.Divorced);
            this.groupBox2.Controls.Add(this.Married);
            this.groupBox2.Controls.Add(this.Single);
            this.groupBox2.Location = new System.Drawing.Point(20, 575);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 61);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Civil Status:";
            // 
            // Separated
            // 
            this.Separated.AutoSize = true;
            this.Separated.Location = new System.Drawing.Point(532, 26);
            this.Separated.Name = "Separated";
            this.Separated.Size = new System.Drawing.Size(98, 24);
            this.Separated.TabIndex = 46;
            this.Separated.TabStop = true;
            this.Separated.Text = "Separated";
            this.Separated.UseVisualStyleBackColor = true;
            this.Separated.CheckedChanged += new System.EventHandler(this.Separated_CheckedChanged);
            // 
            // Widowed
            // 
            this.Widowed.AutoSize = true;
            this.Widowed.Location = new System.Drawing.Point(395, 26);
            this.Widowed.Name = "Widowed";
            this.Widowed.Size = new System.Drawing.Size(94, 24);
            this.Widowed.TabIndex = 45;
            this.Widowed.TabStop = true;
            this.Widowed.Text = "Widowed";
            this.Widowed.UseVisualStyleBackColor = true;
            this.Widowed.CheckedChanged += new System.EventHandler(this.Widowed_CheckedChanged);
            // 
            // Divorced
            // 
            this.Divorced.AutoSize = true;
            this.Divorced.Location = new System.Drawing.Point(250, 26);
            this.Divorced.Name = "Divorced";
            this.Divorced.Size = new System.Drawing.Size(90, 24);
            this.Divorced.TabIndex = 44;
            this.Divorced.TabStop = true;
            this.Divorced.Text = "Divorced";
            this.Divorced.UseVisualStyleBackColor = true;
            this.Divorced.CheckedChanged += new System.EventHandler(this.Divorced_CheckedChanged);
            // 
            // Married
            // 
            this.Married.AutoSize = true;
            this.Married.Location = new System.Drawing.Point(140, 26);
            this.Married.Name = "Married";
            this.Married.Size = new System.Drawing.Size(82, 24);
            this.Married.TabIndex = 43;
            this.Married.TabStop = true;
            this.Married.Text = "Married";
            this.Married.UseVisualStyleBackColor = true;
            this.Married.CheckedChanged += new System.EventHandler(this.Married_CheckedChanged);
            // 
            // Single
            // 
            this.Single.AutoSize = true;
            this.Single.Location = new System.Drawing.Point(36, 26);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(71, 24);
            this.Single.TabIndex = 42;
            this.Single.TabStop = true;
            this.Single.Text = "Single";
            this.Single.UseVisualStyleBackColor = true;
            this.Single.CheckedChanged += new System.EventHandler(this.Single_CheckedChanged);
            // 
            // TempTable
            // 
            this.TempTable.AllowUserToAddRows = false;
            this.TempTable.AllowUserToDeleteRows = false;
            this.TempTable.AllowUserToResizeColumns = false;
            this.TempTable.AllowUserToResizeRows = false;
            this.TempTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TempTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TempTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TempTable.ColumnHeadersHeight = 29;
            this.TempTable.Location = new System.Drawing.Point(12, 50);
            this.TempTable.Name = "TempTable";
            this.TempTable.ReadOnly = true;
            this.TempTable.RowHeadersWidth = 51;
            this.TempTable.RowTemplate.Height = 29;
            this.TempTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TempTable.Size = new System.Drawing.Size(572, 262);
            this.TempTable.TabIndex = 33;
            this.TempTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TempTable_CellClick);
            this.TempTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TempTable_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-5, 318);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(734, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-5, -5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(734, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(400, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 22);
            this.label16.TabIndex = 38;
            this.label16.Text = "Note: Textbox uneditable.\r\nThese are system generated.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(619, 409);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 22);
            this.label17.TabIndex = 39;
            this.label17.Text = "Note: Textbox uneditable.\r\nThese are system generated.";
            // 
            // Maletxt
            // 
            this.Maletxt.AutoSize = true;
            this.Maletxt.Location = new System.Drawing.Point(346, 450);
            this.Maletxt.Name = "Maletxt";
            this.Maletxt.Size = new System.Drawing.Size(64, 24);
            this.Maletxt.TabIndex = 40;
            this.Maletxt.Text = "Male";
            this.Maletxt.UseVisualStyleBackColor = true;
            this.Maletxt.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Femaletxt
            // 
            this.Femaletxt.AutoSize = true;
            this.Femaletxt.Location = new System.Drawing.Point(423, 449);
            this.Femaletxt.Name = "Femaletxt";
            this.Femaletxt.Size = new System.Drawing.Size(79, 24);
            this.Femaletxt.TabIndex = 41;
            this.Femaletxt.Text = "Female";
            this.Femaletxt.UseVisualStyleBackColor = true;
            this.Femaletxt.CheckedChanged += new System.EventHandler(this.Femaletxt_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Nextbtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(594, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(20, 192);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(94, 29);
            this.Nextbtn.TabIndex = 6;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // EmpMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(726, 664);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Femaletxt);
            this.Controls.Add(this.Maletxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TempTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ManagerID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Absenceslbl);
            this.Controls.Add(this.Absences);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EmpMng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.EmpMng_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox FullName;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox EmpID;
        private Label label6;
        private DateTimePicker bday;
        private GroupBox Sex;
        private Label label7;
        private Label label8;
        private TextBox State;
        private Label label9;
        private TextBox Zip;
        private Label label10;
        private ComboBox Department;
        private TextBox DeptID;
        private Label label11;
        private TextBox Absences;
        private Label Absenceslbl;
        private Label label12;
        private TextBox Salary;
        private Label label13;
        private ComboBox Manager;
        private TextBox ManagerID;
        private Label label14;
        private GroupBox groupBox2;
        private DataGridView TempTable;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label15;
        private Label label16;
        private Label label17;
        private CheckBox Maletxt;
        private CheckBox Femaletxt;
        private RadioButton Separated;
        private RadioButton Widowed;
        private RadioButton Divorced;
        private RadioButton Married;
        private RadioButton Single;
        private GroupBox groupBox1;
        private Button Nextbtn;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button2;
        private PictureBox pictureBox1;
    }
}