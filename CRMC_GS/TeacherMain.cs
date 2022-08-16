using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
namespace CRMC_GS
{
    public partial class TeacherMain : Form
    {
        private string status = "0";
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");
        public TeacherMain(string Tlastname, string IDNo, string Firstname)
        {
            InitializeComponent();
            label1.Text = Tlastname;
            lblIDNo.Text = IDNo;
            label2.Text = Firstname;
        }

        private void TeacherMain_Load(object sender, EventArgs e)
        {
            
        }

     

        public void browse() {

            this.status = "1";
            if (cbSchoolYear.Text.ToString().Length == 0)
            {
                MessageBox.Show("SchoolYear is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbSchoolYear.Focus();
                return;
            }
            if (cbSemester.Text.ToString().Length == 0)
            {
                MessageBox.Show("Semester is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbSemester.Focus();
                return;
            }


            SearchDisplay();
        }


        public void SearchDisplay() {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from TSchedule where  TeacherIDCode like '" + lblIDNo.Text + "%' AND SchoolYear like '" + cbSchoolYear.Text + "%' AND Semester like '" + cbSemester.Text + "%' order by TCourse ", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = true;
            dataGridView1.Columns[12].Visible = true;
            dataGridView1.Columns[13].Visible = true;
            dataGridView1.Columns[14].Visible = true;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
          
         

            dataGridView1.Columns[11].HeaderText = "Schedule";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            con.Close();
        }

        private void dataGridView1_DoubleClick(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();

            
            string Department = dataGridView1.SelectedRows[0].Cells["TDepartment"].Value.ToString();
            string Course = dataGridView1.SelectedRows[0].Cells["TCourse"].Value.ToString();
            string SubjectCode = dataGridView1.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
            string Title = dataGridView1.SelectedRows[0].Cells["Subject"].Value.ToString();
            string Units = dataGridView1.SelectedRows[0].Cells["Units"].Value.ToString();
            
            string SchedDay = dataGridView1.SelectedRows[0].Cells["SchedDay"].Value.ToString();
            string TimeStart = dataGridView1.SelectedRows[0].Cells["TimeStart"].Value.ToString();
            string TmeEnd = dataGridView1.SelectedRows[0].Cells["TmeEnd"].Value.ToString();

            
            string SY = cbSchoolYear.Text;
            string Sem = cbSemester.Text;

            string IDNo = lblIDNo.Text;
            string Tlastname = label1.Text;
            string Firstname = label2.Text;


            TeacherGrading input = new TeacherGrading(Department, Course, SubjectCode, Title,
                Units, SchedDay, TimeStart, TmeEnd, SY, Sem, IDNo, Tlastname, Firstname);
            input.Show();
            this.Hide();
        }

        private void studentsINCToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string Firstname = label2.Text;
            string Tlastname = label1.Text;
            string IDNo = lblIDNo.Text;



            TeacherStudentsINC user = new TeacherStudentsINC(Firstname, Tlastname, IDNo);
            user.Show();
            this.Hide();
        }

        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

           
            
        }

        private void TeacherMain_Activated(object sender, System.EventArgs e)
        {
            if (this.status.Trim().Equals("0"))
            {

            }else{

                SearchDisplay();
            }
        }

        private void splitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            string SubjectCode = dataGridView1.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
            string SchoolYear = dataGridView1.SelectedRows[0].Cells["SchoolYear"].Value.ToString();
            string Semester = dataGridView1.SelectedRows[0].Cells["Semester"].Value.ToString();
            string Subject = dataGridView1.SelectedRows[0].Cells["Subject"].Value.ToString();
            string Units = dataGridView1.SelectedRows[0].Cells["Units"].Value.ToString();
            string TeacherIDCode = dataGridView1.SelectedRows[0].Cells["TeacherIDCode"].Value.ToString();
            string TFirstname = dataGridView1.SelectedRows[0].Cells["TFirstname"].Value.ToString();
            string TLastname = dataGridView1.SelectedRows[0].Cells["TLastname"].Value.ToString();
            string TDepartment = dataGridView1.SelectedRows[0].Cells["TDepartment"].Value.ToString();
            string TCourse = dataGridView1.SelectedRows[0].Cells["TCourse"].Value.ToString();
            string Room = dataGridView1.SelectedRows[0].Cells["Room"].Value.ToString();
            string SchedDay = dataGridView1.SelectedRows[0].Cells["SchedDay"].Value.ToString();
            string TimeStart = dataGridView1.SelectedRows[0].Cells["TimeStart"].Value.ToString();
            string TmeEnd = dataGridView1.SelectedRows[0].Cells["TmeEnd"].Value.ToString();

            TeacherTransferStudentSched user = new TeacherTransferStudentSched(SubjectCode, SchoolYear, Semester, Subject, Units, TeacherIDCode,
                TFirstname, TLastname, TDepartment, TCourse,Room, SchedDay, TimeStart, TmeEnd);
            user.Show();
        }

        private void TeacherMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin user = new frmLogin();
            user.Show();
            this.Hide();
        }

        private void cbSemester_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            browse();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            if (cbSemester.Text.ToString().Length == 0)
            {
                MessageBox.Show("Look at your schedule first", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbSchoolYear.Focus();
                return;
            }

            string IDNo = lblIDNo.Text;
            string Tlastname = label1.Text;
            string Firstname = label2.Text;
            string year = cbSchoolYear.Text;
            string sem = cbSemester.Text;

            TeachersRoomSchedule input = new TeachersRoomSchedule(IDNo, Tlastname, Firstname,year, sem);
            input.Show();
            this.Hide();


        }

        private void updateScheduleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            string SubjectCode = dataGridView1.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
            string SchoolYear = dataGridView1.SelectedRows[0].Cells["SchoolYear"].Value.ToString();
            string Semester = dataGridView1.SelectedRows[0].Cells["Semester"].Value.ToString();
            string Subject = dataGridView1.SelectedRows[0].Cells["Subject"].Value.ToString();
            string Units = dataGridView1.SelectedRows[0].Cells["Units"].Value.ToString();
            string TeacherIDCode = dataGridView1.SelectedRows[0].Cells["TeacherIDCode"].Value.ToString();
            string TFirstname = dataGridView1.SelectedRows[0].Cells["TFirstname"].Value.ToString();
            string TLastname = dataGridView1.SelectedRows[0].Cells["TLastname"].Value.ToString();
            string TDepartment = dataGridView1.SelectedRows[0].Cells["TDepartment"].Value.ToString();
            string TCourse = dataGridView1.SelectedRows[0].Cells["TCourse"].Value.ToString();
            string Room = dataGridView1.SelectedRows[0].Cells["Room"].Value.ToString();
            string SchedDay = dataGridView1.SelectedRows[0].Cells["SchedDay"].Value.ToString();
            string TimeStart = dataGridView1.SelectedRows[0].Cells["TimeStart"].Value.ToString();
            string TmeEnd = dataGridView1.SelectedRows[0].Cells["TmeEnd"].Value.ToString();

            TeacherUpdateSched user = new TeacherUpdateSched(SubjectCode, SchoolYear, Semester, Subject, Units, TeacherIDCode,
                TFirstname, TLastname, TDepartment, TCourse,SchedDay,Room, TimeStart, TmeEnd);
            user.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblType.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if(lblType.Text == "Update"){
                DataTable dt = new DataTable();
                string SubjectCode = dataGridView1.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
                string SchoolYear = dataGridView1.SelectedRows[0].Cells["SchoolYear"].Value.ToString();
                string Semester = dataGridView1.SelectedRows[0].Cells["Semester"].Value.ToString();
                string Subject = dataGridView1.SelectedRows[0].Cells["Subject"].Value.ToString();
                string Units = dataGridView1.SelectedRows[0].Cells["Units"].Value.ToString();
                string TeacherIDCode = dataGridView1.SelectedRows[0].Cells["TeacherIDCode"].Value.ToString();
                string TFirstname = dataGridView1.SelectedRows[0].Cells["TFirstname"].Value.ToString();
                string TLastname = dataGridView1.SelectedRows[0].Cells["TLastname"].Value.ToString();
                string TDepartment = dataGridView1.SelectedRows[0].Cells["TDepartment"].Value.ToString();
                string TCourse = dataGridView1.SelectedRows[0].Cells["TCourse"].Value.ToString();
                string Room = dataGridView1.SelectedRows[0].Cells["Room"].Value.ToString();
                string SchedDay = dataGridView1.SelectedRows[0].Cells["SchedDay"].Value.ToString();
                string TimeStart = dataGridView1.SelectedRows[0].Cells["TimeStart"].Value.ToString();
                string TmeEnd = dataGridView1.SelectedRows[0].Cells["TmeEnd"].Value.ToString();

                string XRoom = dataGridView1.SelectedRows[0].Cells["XRoom"].Value.ToString();
                string XSchedDay = dataGridView1.SelectedRows[0].Cells["XSchedDay"].Value.ToString();
                string XTimeStart = dataGridView1.SelectedRows[0].Cells["XTimeStart"].Value.ToString();
                string XTmeEnd = dataGridView1.SelectedRows[0].Cells["XTmeEnd"].Value.ToString();

                TeacherUpdateTranferStudents user = new TeacherUpdateTranferStudents(SubjectCode, SchoolYear, Semester, Subject, Units, TeacherIDCode,
                    TFirstname, TLastname, TDepartment, TCourse, Room, SchedDay, TimeStart, TmeEnd, XRoom, XSchedDay, XTimeStart, XTmeEnd);
                user.Show();
                this.Hide();

            }
            else if (lblType.Text == "Split")
            {
                DataTable dt = new DataTable();
                string SubjectCode = dataGridView1.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
                string SchoolYear = dataGridView1.SelectedRows[0].Cells["SchoolYear"].Value.ToString();
                string Semester = dataGridView1.SelectedRows[0].Cells["Semester"].Value.ToString();
                string Subject = dataGridView1.SelectedRows[0].Cells["Subject"].Value.ToString();
                string Units = dataGridView1.SelectedRows[0].Cells["Units"].Value.ToString();
                string TeacherIDCode = dataGridView1.SelectedRows[0].Cells["TeacherIDCode"].Value.ToString();
                string TFirstname = dataGridView1.SelectedRows[0].Cells["TFirstname"].Value.ToString();
                string TLastname = dataGridView1.SelectedRows[0].Cells["TLastname"].Value.ToString();
                string TDepartment = dataGridView1.SelectedRows[0].Cells["TDepartment"].Value.ToString();
                string TCourse = dataGridView1.SelectedRows[0].Cells["TCourse"].Value.ToString();
                string Room = dataGridView1.SelectedRows[0].Cells["Room"].Value.ToString();
                string SchedDay = dataGridView1.SelectedRows[0].Cells["SchedDay"].Value.ToString();
                string TimeStart = dataGridView1.SelectedRows[0].Cells["TimeStart"].Value.ToString();
                string TmeEnd = dataGridView1.SelectedRows[0].Cells["TmeEnd"].Value.ToString();

                string XRoom = dataGridView1.SelectedRows[0].Cells["XRoom"].Value.ToString();
                string XSchedDay = dataGridView1.SelectedRows[0].Cells["XSchedDay"].Value.ToString();
                string XTimeStart = dataGridView1.SelectedRows[0].Cells["XTimeStart"].Value.ToString();
                string XTmeEnd = dataGridView1.SelectedRows[0].Cells["XTmeEnd"].Value.ToString();

                TeacherSplitStrangerStudents user = new TeacherSplitStrangerStudents(SubjectCode, SchoolYear, Semester, Subject, Units, TeacherIDCode,
                    TFirstname, TLastname, TDepartment, TCourse, Room, SchedDay, TimeStart, TmeEnd, XRoom, XSchedDay, XTimeStart, XTmeEnd);
                user.Show();
                this.Hide();

            }
            else if (lblType.Text == "Split2")
            {
                DataTable dt = new DataTable();
                string SubjectCode = dataGridView1.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
                string SchoolYear = dataGridView1.SelectedRows[0].Cells["SchoolYear"].Value.ToString();
                string Semester = dataGridView1.SelectedRows[0].Cells["Semester"].Value.ToString();
                string Subject = dataGridView1.SelectedRows[0].Cells["Subject"].Value.ToString();
                string Units = dataGridView1.SelectedRows[0].Cells["Units"].Value.ToString();
                string TeacherIDCode = dataGridView1.SelectedRows[0].Cells["TeacherIDCode"].Value.ToString();
                string TFirstname = dataGridView1.SelectedRows[0].Cells["TFirstname"].Value.ToString();
                string TLastname = dataGridView1.SelectedRows[0].Cells["TLastname"].Value.ToString();
                string TDepartment = dataGridView1.SelectedRows[0].Cells["TDepartment"].Value.ToString();
                string TCourse = dataGridView1.SelectedRows[0].Cells["TCourse"].Value.ToString();
                string Room = dataGridView1.SelectedRows[0].Cells["Room"].Value.ToString();
                string SchedDay = dataGridView1.SelectedRows[0].Cells["SchedDay"].Value.ToString();
                string TimeStart = dataGridView1.SelectedRows[0].Cells["TimeStart"].Value.ToString();
                string TmeEnd = dataGridView1.SelectedRows[0].Cells["TmeEnd"].Value.ToString();

                string XRoom = dataGridView1.SelectedRows[0].Cells["XRoom"].Value.ToString();
                string XSchedDay = dataGridView1.SelectedRows[0].Cells["XSchedDay"].Value.ToString();
                string XTimeStart = dataGridView1.SelectedRows[0].Cells["XTimeStart"].Value.ToString();
                string XTmeEnd = dataGridView1.SelectedRows[0].Cells["XTmeEnd"].Value.ToString();

                TeacherSplit2StransferStudents user = new TeacherSplit2StransferStudents(SubjectCode, SchoolYear, Semester, Subject, Units, TeacherIDCode,
                    TFirstname, TLastname, TDepartment, TCourse, Room, SchedDay, TimeStart, TmeEnd, XRoom, XSchedDay, XTimeStart, XTmeEnd);
                user.Show();
                this.Hide();

            }
            else {
 
            }
        }


      

      

      
    }
}
