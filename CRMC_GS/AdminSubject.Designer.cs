namespace CRMC_GS
{
    partial class AdminSubject
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
            this.components = new System.ComponentModel.Container();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSchoolYear = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTeacherCode = new System.Windows.Forms.TextBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSIDNo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblSCourse = new System.Windows.Forms.TextBox();
            this.lblSDepartment = new System.Windows.Forms.TextBox();
            this.lblStudentLastname = new System.Windows.Forms.TextBox();
            this.lblStudentFirstname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentcode = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDno = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTdept = new System.Windows.Forms.TextBox();
            this.lblTeacherLastname = new System.Windows.Forms.TextBox();
            this.lblTeacherFirstname = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtptimestrart = new System.Windows.Forms.DateTimePicker();
            this.cbSD = new System.Windows.Forms.ComboBox();
            this.dtptimeend = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblT1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblunits = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSC = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cbdisplayteachers = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.Location = new System.Drawing.Point(210, 38);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTeacher.TabIndex = 0;
            this.btnSearchTeacher.Text = "Search";
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "School Year:";
            // 
            // cbSchoolYear
            // 
            this.cbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchoolYear.FormattingEnabled = true;
            this.cbSchoolYear.Location = new System.Drawing.Point(91, 7);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Size = new System.Drawing.Size(105, 21);
            this.cbSchoolYear.TabIndex = 2;
            this.cbSchoolYear.SelectedIndexChanged += new System.EventHandler(this.cbSchoolYear_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 171);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txtTeacherCode
            // 
            this.txtTeacherCode.Location = new System.Drawing.Point(39, 38);
            this.txtTeacherCode.Name = "txtTeacherCode";
            this.txtTeacherCode.Size = new System.Drawing.Size(165, 20);
            this.txtTeacherCode.TabIndex = 4;
            this.txtTeacherCode.TextChanged += new System.EventHandler(this.txtTeacherCode_TextChanged);
            this.txtTeacherCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTeacherCode_KeyDown);
            this.txtTeacherCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeacherCode_KeyPress);
            // 
            // cbSemester
            // 
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1ST",
            "2ND",
            "SUMMER"});
            this.cbSemester.Location = new System.Drawing.Point(68, 8);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(65, 21);
            this.cbSemester.TabIndex = 7;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            this.cbSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSemester_KeyPress);
            this.cbSemester.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSemester_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semester";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSIDNo);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.lblSCourse);
            this.panel1.Controls.Add(this.lblSDepartment);
            this.panel1.Controls.Add(this.lblStudentLastname);
            this.panel1.Controls.Add(this.lblStudentFirstname);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStudentcode);
            this.panel1.Controls.Add(this.btnSearchStudent);
            this.panel1.Location = new System.Drawing.Point(28, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 186);
            this.panel1.TabIndex = 9;
            // 
            // txtSIDNo
            // 
            this.txtSIDNo.Location = new System.Drawing.Point(96, 56);
            this.txtSIDNo.Name = "txtSIDNo";
            this.txtSIDNo.Size = new System.Drawing.Size(175, 20);
            this.txtSIDNo.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(15, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 38;
            this.label22.Text = "ID No. :";
            // 
            // lblSCourse
            // 
            this.lblSCourse.Location = new System.Drawing.Point(96, 149);
            this.lblSCourse.Name = "lblSCourse";
            this.lblSCourse.Size = new System.Drawing.Size(175, 20);
            this.lblSCourse.TabIndex = 28;
            // 
            // lblSDepartment
            // 
            this.lblSDepartment.Location = new System.Drawing.Point(96, 126);
            this.lblSDepartment.Name = "lblSDepartment";
            this.lblSDepartment.Size = new System.Drawing.Size(175, 20);
            this.lblSDepartment.TabIndex = 27;
            // 
            // lblStudentLastname
            // 
            this.lblStudentLastname.Location = new System.Drawing.Point(96, 102);
            this.lblStudentLastname.Name = "lblStudentLastname";
            this.lblStudentLastname.Size = new System.Drawing.Size(175, 20);
            this.lblStudentLastname.TabIndex = 26;
            // 
            // lblStudentFirstname
            // 
            this.lblStudentFirstname.Location = new System.Drawing.Point(96, 78);
            this.lblStudentFirstname.Name = "lblStudentFirstname";
            this.lblStudentFirstname.Size = new System.Drawing.Size(175, 20);
            this.lblStudentFirstname.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Course:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 131);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Department:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Students";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Firstname:";
            // 
            // txtStudentcode
            // 
            this.txtStudentcode.Location = new System.Drawing.Point(18, 28);
            this.txtStudentcode.Name = "txtStudentcode";
            this.txtStudentcode.Size = new System.Drawing.Size(148, 20);
            this.txtStudentcode.TabIndex = 11;
            this.txtStudentcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentcode_KeyDown);
            this.txtStudentcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentcode_KeyPress);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(172, 26);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 10;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtIDno);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lblTdept);
            this.panel2.Controls.Add(this.lblTeacherLastname);
            this.panel2.Controls.Add(this.lblTeacherFirstname);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnSearchTeacher);
            this.panel2.Controls.Add(this.txtTeacherCode);
            this.panel2.Location = new System.Drawing.Point(359, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 187);
            this.panel2.TabIndex = 16;
            // 
            // txtIDno
            // 
            this.txtIDno.Location = new System.Drawing.Point(120, 70);
            this.txtIDno.Name = "txtIDno";
            this.txtIDno.Size = new System.Drawing.Size(165, 20);
            this.txtIDno.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(45, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "ID No. :";
            // 
            // lblTdept
            // 
            this.lblTdept.Location = new System.Drawing.Point(120, 142);
            this.lblTdept.Name = "lblTdept";
            this.lblTdept.Size = new System.Drawing.Size(165, 20);
            this.lblTdept.TabIndex = 24;
            // 
            // lblTeacherLastname
            // 
            this.lblTeacherLastname.Location = new System.Drawing.Point(120, 118);
            this.lblTeacherLastname.Name = "lblTeacherLastname";
            this.lblTeacherLastname.Size = new System.Drawing.Size(165, 20);
            this.lblTeacherLastname.TabIndex = 23;
            // 
            // lblTeacherFirstname
            // 
            this.lblTeacherFirstname.Location = new System.Drawing.Point(120, 94);
            this.lblTeacherFirstname.Name = "lblTeacherFirstname";
            this.lblTeacherFirstname.Size = new System.Drawing.Size(165, 20);
            this.lblTeacherFirstname.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(43, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Teacher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lastname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Firstname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Schedule Day:";
            // 
            // dtptimestrart
            // 
            this.dtptimestrart.CustomFormat = "hh:mm tt";
            this.dtptimestrart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptimestrart.Location = new System.Drawing.Point(109, 105);
            this.dtptimestrart.Name = "dtptimestrart";
            this.dtptimestrart.ShowUpDown = true;
            this.dtptimestrart.Size = new System.Drawing.Size(71, 20);
            this.dtptimestrart.TabIndex = 5;
            // 
            // cbSD
            // 
            this.cbSD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSD.FormattingEnabled = true;
            this.cbSD.Items.AddRange(new object[] {
            "DAILY",
            "MWF",
            "TTh",
            "Saturday"});
            this.cbSD.Location = new System.Drawing.Point(109, 43);
            this.cbSD.Name = "cbSD";
            this.cbSD.Size = new System.Drawing.Size(160, 21);
            this.cbSD.TabIndex = 17;
            this.cbSD.SelectedIndexChanged += new System.EventHandler(this.cbSD_SelectedIndexChanged);
            // 
            // dtptimeend
            // 
            this.dtptimeend.CustomFormat = "hh:mm tt";
            this.dtptimeend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptimeend.Location = new System.Drawing.Point(198, 105);
            this.dtptimeend.Name = "dtptimeend";
            this.dtptimeend.ShowUpDown = true;
            this.dtptimeend.Size = new System.Drawing.Size(71, 20);
            this.dtptimeend.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "-";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(14, 111);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 13);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "Time:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbRoom);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.lblT1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbSD);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.dtptimeend);
            this.panel3.Controls.Add(this.dtptimestrart);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(713, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 186);
            this.panel3.TabIndex = 21;
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Items.AddRange(new object[] {
            "Lab1",
            "Lab2",
            "Lab3",
            "Lab4",
            "Room 214",
            "Room 300"});
            this.cbRoom.Location = new System.Drawing.Point(109, 72);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(160, 21);
            this.cbRoom.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Room";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(181, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(13, 11);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(13, 13);
            this.lblT1.TabIndex = 21;
            this.lblT1.Text = "1";
            this.lblT1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(122, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Schedule";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lblunits);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.lblSubject);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblSC);
            this.panel4.Location = new System.Drawing.Point(26, 559);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1035, 46);
            this.panel4.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(937, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Units:";
            // 
            // lblunits
            // 
            this.lblunits.AutoSize = true;
            this.lblunits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunits.Location = new System.Drawing.Point(986, 17);
            this.lblunits.Name = "lblunits";
            this.lblunits.Size = new System.Drawing.Size(43, 17);
            this.lblunits.TabIndex = 23;
            this.lblunits.Text = "units";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(238, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Subject:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(302, 17);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(60, 17);
            this.lblSubject.TabIndex = 21;
            this.lblSubject.Text = "subject";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Subject Code:";
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSC.Location = new System.Drawing.Point(123, 17);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(95, 17);
            this.lblSC.TabIndex = 19;
            this.lblSC.Text = "subjectcode";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(26, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1035, 222);
            this.panel5.TabIndex = 23;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Department:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(112, 26);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(90, 17);
            this.lblDepartment.TabIndex = 25;
            this.lblDepartment.Text = "department";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(208, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "Course:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(271, 27);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(57, 17);
            this.lblCourse.TabIndex = 27;
            this.lblCourse.Text = "course";
            // 
            // cbdisplayteachers
            // 
            this.cbdisplayteachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdisplayteachers.FormattingEnabled = true;
            this.cbdisplayteachers.Items.AddRange(new object[] {
            "1ST",
            "2ND",
            "SUMMER"});
            this.cbdisplayteachers.Location = new System.Drawing.Point(68, 8);
            this.cbdisplayteachers.Name = "cbdisplayteachers";
            this.cbdisplayteachers.Size = new System.Drawing.Size(131, 21);
            this.cbdisplayteachers.TabIndex = 31;
            this.cbdisplayteachers.SelectedIndexChanged += new System.EventHandler(this.cbdisplayteachers_SelectedIndexChanged);
            this.cbdisplayteachers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbdisplayteachers_KeyPress);
            this.cbdisplayteachers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbdisplayteachers_MouseClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Teacher";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Location = new System.Drawing.Point(12, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1062, 606);
            this.panel6.TabIndex = 32;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblCourse);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.lblDepartment);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(10, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1035, 66);
            this.panel7.TabIndex = 28;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.cbSchoolYear);
            this.panel10.Location = new System.Drawing.Point(431, 14);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(212, 38);
            this.panel10.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.cbSemester);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(651, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(149, 38);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.cbdisplayteachers);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(810, 14);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(213, 38);
            this.panel8.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.dataGridView1);
            this.panel11.Location = new System.Drawing.Point(11, 92);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1034, 199);
            this.panel11.TabIndex = 29;
            // 
            // AdminSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 632);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Name = "AdminSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSubject";
            this.Activated += new System.EventHandler(this.AdminSubject_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminSubject_FormClosing);
            this.Load += new System.EventHandler(this.AdminSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSchoolYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTeacherCode;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentcode;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtptimestrart;
        private System.Windows.Forms.ComboBox cbSD;
        private System.Windows.Forms.DateTimePicker dtptimeend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblunits;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cbdisplayteachers;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox lblSCourse;
        private System.Windows.Forms.TextBox lblSDepartment;
        private System.Windows.Forms.TextBox lblStudentLastname;
        private System.Windows.Forms.TextBox lblStudentFirstname;
        private System.Windows.Forms.TextBox lblTdept;
        private System.Windows.Forms.TextBox lblTeacherLastname;
        private System.Windows.Forms.TextBox lblTeacherFirstname;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.TextBox txtIDno;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSIDNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
    }
}