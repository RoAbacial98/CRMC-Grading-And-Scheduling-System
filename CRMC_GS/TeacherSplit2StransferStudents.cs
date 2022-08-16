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
    public partial class TeacherSplit2StransferStudents : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");


        public TeacherSplit2StransferStudents(string SubjectCode, string SchoolYear, string Semester, string Subject, string Units, string TeacherIDCode,
              string TFirstname, string TLastname, string TDepartment, string TCourse, string Room, string SchedDay, string TimeStart, string TmeEnd, string XRoom, string XSchedDay, string XTimeStart, string XTmeEnd)
        {
            InitializeComponent();
            txtSubjectCode.Text = SubjectCode;
            txtSchoolYear.Text = SchoolYear;
            txtSemester.Text = Semester;
            txtSubject.Text = Subject;
            txtUnits.Text = Units;
            txtTeacherIDCode.Text = TeacherIDCode;
            txtTFirstname.Text = TFirstname;
            txtTLastname.Text = TLastname;
            txtTDepartment.Text = TDepartment;
            txtTCourse.Text = TCourse;

            txtOldRoom.Text = Room;
            txtOldSched.Text = SchedDay;
            txtOTS.Text = TimeStart;
            txtOTE.Text = TimeStart;

            txtNewRoom.Text = XRoom;
            txtSD.Text = XSchedDay;
            txtNewTS.Text = XTimeStart;
            txtNewTE.Text = XTmeEnd;
        }

        private void TeacherSplit2StransferStudents_Load(object sender, EventArgs e)
        {
            OLDSearchDisplay();
            NewSearchDisplay();
        }

        private void NewSched()
        {
            SqlConnection connection = new SqlConnection(connectionstring.Trim());
            string insertStatement = " UPDATE Grade SET SchedDay=@SchedDay,TimeStart=@TimeStart,TmeEnd=@TmeEnd WHERE SubjectID=@SubjectID";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);



            insertCommand.Parameters.Add("@SubjectID", SqlDbType.VarChar).Value = lblStudentID.Text;
            insertCommand.Parameters.Add("@SchedDay", SqlDbType.VarChar).Value = txtSD.Text;
            insertCommand.Parameters.Add("@TimeStart", SqlDbType.VarChar).Value = txtNewTS.Text;
            insertCommand.Parameters.Add("@TmeEnd", SqlDbType.VarChar).Value = txtNewTE.Text;


            int row = 0;

            try
            {
                connection.Open();
                row = insertCommand.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {

                connection.Close();
            }
        }

        public void NewSearchDisplay()
        {

            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from Grade where Subject like '" + txtSubject.Text + "%' AND SchoolYear like '" + txtSchoolYear.Text + "%' AND Semester like '" + txtSemester.Text + "%'AND TeacherIDCode like '" + txtTeacherIDCode.Text + "%' AND TDepartment like '" + txtTDepartment.Text + "%'AND TCourse like '" + txtTCourse.Text + "%'AND SchedDay like '" + txtSD.Text + "%'AND TimeStart like '" + txtNewTS.Text + "%' AND TmeEnd like '" + txtNewTE.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            datagridNew.DataSource = dt;
            datagridNew.Columns[0].Visible = false;
            datagridNew.Columns[1].Visible = false;
            datagridNew.Columns[2].Visible = true;
            datagridNew.Columns[3].Visible = true;
            datagridNew.Columns[4].Visible = false;
            datagridNew.Columns[5].Visible = true;
            datagridNew.Columns[6].Visible = false;
            datagridNew.Columns[7].Visible = false;
            datagridNew.Columns[8].Visible = false;
            datagridNew.Columns[9].Visible = false;
            datagridNew.Columns[10].Visible = false;
            datagridNew.Columns[11].Visible = false;
            datagridNew.Columns[12].Visible = false;
            datagridNew.Columns[13].Visible = false;
            datagridNew.Columns[14].Visible = false;
            datagridNew.Columns[15].Visible = false;
            datagridNew.Columns[16].Visible = false;
            datagridNew.Columns[17].Visible = false;
            datagridNew.Columns[18].Visible = false;
            datagridNew.Columns[19].Visible = false;
            datagridNew.Columns[20].Visible = false;
            datagridNew.Columns[21].Visible = false;
            datagridNew.Columns[22].Visible = false;
            datagridNew.Columns[23].Visible = false;
            datagridNew.Columns[24].Visible = false;
            datagridNew.Columns[25].Visible = false;
            datagridNew.Columns[26].Visible = false;
            datagridNew.Columns[27].Visible = false;
            datagridNew.Columns[28].Visible = false;
            datagridNew.Columns[29].Visible = false;
            datagridNew.Columns[30].Visible = false;
            datagridNew.Columns[31].Visible = false;

            datagridNew.Columns[2].HeaderText = "Firstname";
            datagridNew.Columns[3].HeaderText = "Lastname";
            datagridNew.Columns[5].HeaderText = "Course";
            datagridNew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }


        public void OLDSearchDisplay()
        {

            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from Grade where Subject like '" + txtSubject.Text + "%' AND SchoolYear like '" + txtSchoolYear.Text + "%' AND Semester like '" + txtSemester.Text + "%'AND TeacherIDCode like '" + txtTeacherIDCode.Text + "%' AND TDepartment like '" + txtTDepartment.Text + "%'AND TCourse like '" + txtTCourse.Text + "%'AND SchedDay like '" + txtOldSched.Text + "%'AND TimeStart like '" + txtOTS.Text + "%'AND TmeEnd like '" + txtOTE.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            datagridOLD.DataSource = dt;
            datagridOLD.Columns[0].Visible = false;
            datagridOLD.Columns[1].Visible = false;
            datagridOLD.Columns[2].Visible = true;
            datagridOLD.Columns[3].Visible = true;
            datagridOLD.Columns[4].Visible = false;
            datagridOLD.Columns[5].Visible = true;
            datagridOLD.Columns[6].Visible = false;
            datagridOLD.Columns[7].Visible = false;
            datagridOLD.Columns[8].Visible = false;
            datagridOLD.Columns[9].Visible = false;
            datagridOLD.Columns[10].Visible = false;
            datagridOLD.Columns[11].Visible = false;
            datagridOLD.Columns[12].Visible = false;
            datagridOLD.Columns[13].Visible = false;
            datagridOLD.Columns[14].Visible = false;
            datagridOLD.Columns[15].Visible = false;
            datagridOLD.Columns[16].Visible = false;
            datagridOLD.Columns[17].Visible = false;
            datagridOLD.Columns[18].Visible = false;
            datagridOLD.Columns[19].Visible = false;
            datagridOLD.Columns[20].Visible = false;
            datagridOLD.Columns[21].Visible = false;
            datagridOLD.Columns[22].Visible = false;
            datagridOLD.Columns[23].Visible = false;
            datagridOLD.Columns[24].Visible = false;
            datagridOLD.Columns[25].Visible = false;
            datagridOLD.Columns[26].Visible = false;
            datagridOLD.Columns[27].Visible = false;
            datagridOLD.Columns[28].Visible = false;
            datagridOLD.Columns[29].Visible = false;
            datagridOLD.Columns[30].Visible = false;
            datagridOLD.Columns[31].Visible = false;

            datagridOLD.Columns[2].HeaderText = "Firstname";
            datagridOLD.Columns[3].HeaderText = "Lastname";
            datagridOLD.Columns[5].HeaderText = "Course";
            datagridOLD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }

        private void btnTransfer_Click(object sender, System.EventArgs e)
        {
            if (lblStudentID.Text == "StudentID")
            {
                MessageBox.Show("You forgot to select a student!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            NewSched();
            NewSearchDisplay();
            OLDSearchDisplay();
        }

        private void btnTransferLower_Click(object sender, System.EventArgs e)
        {
            if (lblStudentID.Text == "StudentID")
            {
                MessageBox.Show("You forgot to select a student!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            NewSched();
            NewSearchDisplay();
            OLDSearchDisplay();
        }

        private void datagridOLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblStudentID.Text = datagridOLD.CurrentRow.Cells[0].Value.ToString();
        }

        private void datagridNew_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblStudentID.Text = datagridNew.CurrentRow.Cells[0].Value.ToString();
        }

        private void TeacherSplit2StransferStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            string Firstname = txtTFirstname.Text;
            string Tlastname = txtTLastname.Text;
            string IDNo = txtTeacherIDCode.Text;

            TeacherMain user = new TeacherMain(Tlastname, IDNo, Firstname);
            user.Show();
            this.Hide();
        }
    }
}
