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
    public partial class AdminConfirmUpdate : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public AdminConfirmUpdate(string SubjectCode, string SchoolYear, string Semester, string Subject, string Units, string TeacherIDCode,
               string TFirstname, string TLastname, string TDepartment, string TCourse, string OLDSchedDay, string OLdDRoom, string OLDTimeStart, string OLDTmeEnd, string ShedID,
            string NewTimeStart,string NewTimeEnd,string NewShedDay,string NewRoom)
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
            txtOldSched.Text = OLDSchedDay;
            txtOLDRoom.Text = OLdDRoom;
            txtOTS.Text = OLDTimeStart;
            txtOTE.Text = OLDTmeEnd;

            txtNewSD.Text = NewShedDay;
            txtNewTS.Text = NewTimeStart;
            txtNewTE.Text = NewTimeEnd;
            txtNewRoom.Text = NewRoom;
         
            
        }

        private void AdminConfirmUpdate_Load(object sender, System.EventArgs e)
        {
            
          
        }

      

      

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

      

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            //duplicate
            SqlCommand cmd = new SqlCommand("Select * from TSchedule where SchoolYear = '" + txtSchoolYear.Text + "' AND Semester = '" + txtSemester.Text + "'AND SchedDay = '" + txtNewSD.Text + "' AND Room = '" + txtNewRoom.Text + "' AND TimeStart = '" + txtNewTS.Text + "' AND TmeEnd = '" + txtNewTE.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("The Schedule is already occupied!!!");
                ds.Clear();
               
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionstring.Trim());
                string insertStatement = " UPDATE TSchedule SET SchedDay=@SchedDay,TimeStart=@TimeStart,TmeEnd=@TmeEnd,Room=@Room,Type=@Type WHERE Subject=@Subject AND SchoolYear=@SchoolYear AND Semester=@Semester AND SubjectCode=@SubjectCode AND Units=@Units AND TeacherIDCode=@TeacherIDCode AND TFirstname=@TFirstname AND TLastname=@TLastname AND TDepartment=@TDepartment AND TCourse=@TCourse AND ShedID=@ShedID";
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);


                insertCommand.Parameters.Add("@ShedID", SqlDbType.VarChar).Value = lblAutoID.Text;
                insertCommand.Parameters.Add("@Subject", SqlDbType.VarChar).Value = txtSubject.Text;
                insertCommand.Parameters.Add("@SchoolYear", SqlDbType.VarChar).Value = txtSchoolYear.Text;
                insertCommand.Parameters.Add("@Semester", SqlDbType.VarChar).Value = txtSemester.Text;
                insertCommand.Parameters.Add("@SubjectCode", SqlDbType.VarChar).Value = txtSubjectCode.Text;
                insertCommand.Parameters.Add("@Units", SqlDbType.VarChar).Value = txtUnits.Text;
                insertCommand.Parameters.Add("@TeacherIDCode", SqlDbType.VarChar).Value = txtTeacherIDCode.Text;
                insertCommand.Parameters.Add("@TFirstname", SqlDbType.VarChar).Value = txtTFirstname.Text;
                insertCommand.Parameters.Add("@TLastname", SqlDbType.VarChar).Value = txtTLastname.Text;
                insertCommand.Parameters.Add("@TDepartment", SqlDbType.VarChar).Value = txtTDepartment.Text;
                insertCommand.Parameters.Add("@TCourse", SqlDbType.VarChar).Value = txtTCourse.Text;
                insertCommand.Parameters.Add("@SchedDay", SqlDbType.VarChar).Value = txtNewSD.Text;
                insertCommand.Parameters.Add("@Room", SqlDbType.VarChar).Value = txtNewRoom.Text;
                insertCommand.Parameters.Add("@TimeStart", SqlDbType.VarChar).Value = txtNewTS.Text;
                insertCommand.Parameters.Add("@TmeEnd", SqlDbType.VarChar).Value = txtNewTE.Text;
                insertCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = lblUpdate.Text;


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
                //    this.Close();

                MessageBox.Show("Successfully Set Schedule");

                close();
            }

        }

        public void close() {
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring.Trim());

                string insertStatement = "Delete FROM AdminConfrimSched WHERE ShedID ='" + lblAutoID.Text.Trim() + "' AND TeacherIDCode ='" + txtTeacherIDCode.Text.Trim() + "' AND Subject ='" + txtSubject.Text.Trim() + "' AND SchoolYear ='" + txtSchoolYear.Text.Trim() + "' AND Semester ='" + txtSemester.Text.Trim() + "'";

                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

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

        private void AdminConfirmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
           
          
        }

        private void btnView_Click(object sender, System.EventArgs e)
        {
          
           
        }

    }
}
