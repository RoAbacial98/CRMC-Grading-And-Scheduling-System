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
    public partial class TeacherTransferStudentSched : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public TeacherTransferStudentSched(string SubjectCode,string SchoolYear,string Semester,string Subject,string Units,string TeacherIDCode,
              string TFirstname, string TLastname, string TDepartment, string TCourse, string Room, string SchedDay, string TimeStart, string TmeEnd)
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
            txtOTE.Text = TmeEnd;

          
        }

       

       

        private void TeacherTransferStudentSched_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EScode", con);
            cmd.CommandType = CommandType.StoredProcedure;
            object obj = cmd.ExecuteScalar();
            this.lblAutoID.Text = obj.ToString();

   
          
         
        }
      
       

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            try
            {


                SqlConnection connection = new SqlConnection(connectionstring.Trim());

                string insertStatement = "Insert into AdminConfrimSched(ShedID,SchoolYear,Semester,TeacherIDCode,TFirstname,TLastname,TCourse,TDepartment,SubjectCode,Units,Subject,Type,OldTimeStart,OldTimeEnd,OldShedDay,OldRoom,ChangeTo,NewTimeStart,NewTimeEnd,NewShedDay,NewRoom) VALUES (@ShedID,@SchoolYear,@Semester,@TeacherIDCode,@TFirstname,@TLastname,@TCourse,@TDepartment,@SubjectCode,@Units,@Subject,@Type,@OldTimeStart,@OldTimeEnd,@OldShedDay,@OldRoom,@ChangeTo,@NewTimeStart,@NewTimeEnd,@NewShedDay,@NewRoom)";

                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                insertCommand.Parameters.Add("@ShedID", SqlDbType.VarChar).Value = lblAutoID.Text;
                insertCommand.Parameters.Add("@SchoolYear", SqlDbType.VarChar).Value = txtSchoolYear.Text;
                insertCommand.Parameters.Add("@Semester", SqlDbType.VarChar).Value = txtSemester.Text;
                insertCommand.Parameters.Add("@TeacherIDCode", SqlDbType.VarChar).Value = txtTeacherIDCode.Text;
                insertCommand.Parameters.Add("@TFirstname", SqlDbType.VarChar).Value = txtTFirstname.Text;
                insertCommand.Parameters.Add("@TLastname", SqlDbType.VarChar).Value = txtTLastname.Text;
                insertCommand.Parameters.Add("@TCourse", SqlDbType.VarChar).Value = txtTCourse.Text;
                insertCommand.Parameters.Add("@TDepartment", SqlDbType.VarChar).Value = txtTDepartment.Text;
                insertCommand.Parameters.Add("@SubjectCode", SqlDbType.VarChar).Value = txtSubjectCode.Text;
                insertCommand.Parameters.Add("@Units", SqlDbType.VarChar).Value = txtUnits.Text;
                insertCommand.Parameters.Add("@Subject", SqlDbType.VarChar).Value = txtSubject.Text;
                insertCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = lblsplit.Text;
                insertCommand.Parameters.Add("@OldTimeStart", SqlDbType.VarChar).Value = txtOTS.Text;
                insertCommand.Parameters.Add("@OldTimeEnd", SqlDbType.VarChar).Value = txtOTE.Text;
                insertCommand.Parameters.Add("@OldShedDay", SqlDbType.VarChar).Value = txtOldSched.Text;
                insertCommand.Parameters.Add("@OldRoom", SqlDbType.VarChar).Value = txtOldRoom.Text;
                insertCommand.Parameters.Add("@ChangeTo", SqlDbType.VarChar).Value = lblchangeto.Text;
                insertCommand.Parameters.Add("@NewTimeStart", SqlDbType.VarChar).Value = dtptimestrart.Text;
                insertCommand.Parameters.Add("@NewTimeEnd", SqlDbType.VarChar).Value = dtptimeend.Text;
                insertCommand.Parameters.Add("@NewShedDay", SqlDbType.VarChar).Value = cbSD.Text;
                insertCommand.Parameters.Add("@NewRoom", SqlDbType.VarChar).Value = cbNewRoom.Text;



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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();
          

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
