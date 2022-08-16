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
    public partial class AdminConfirmSplit : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public AdminConfirmSplit(string SubjectCode, string SchoolYear, string Semester, string Subject, string Units, string TeacherIDCode,
               string TFirstname, string TLastname, string TDepartment, string TCourse, string OLDSchedDay, string OLDRoom, string OLDTimeStart, string OLDTmeEnd, string ShedID,
            string NewTimeStart, string NewTimeEnd, string NewShedDay, string NewRoom)
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
            txtOldRoom.Text = OLDRoom;
            txtOTS.Text = OLDTimeStart;
            txtOTE.Text = OLDTmeEnd;

            txtNewSD.Text = NewShedDay;
            txtNewTS.Text = NewTimeStart;
            txtNewTE.Text = NewTimeEnd;
            txtNewRoom.Text = NewRoom;
            lblAutoID.Text = ShedID;
         
        }

        private void AdminConfirmSplit_Load(object sender, EventArgs e)
        {
          
        }

       
        private void button1_Click(object sender, EventArgs e)
        {  //duplicate
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
                updateshit();
                Saveshit();
                close();
            }
        }

        public void updateshit() {
            SqlConnection connection = new SqlConnection(connectionstring.Trim());
            string insertStatement = " UPDATE TSchedule SET XSchedDay=@XSchedDay,XTimeStart=@XTimeStart,XTmeEnd=@XTmeEnd,XRoom=@XRoom,Type=@Type WHERE Subject=@Subject AND SchoolYear=@SchoolYear AND Semester=@Semester AND SubjectCode=@SubjectCode AND Units=@Units AND TeacherIDCode=@TeacherIDCode AND TFirstname=@TFirstname AND TLastname=@TLastname AND TDepartment=@TDepartment AND TCourse=@TCourse AND ShedID=@ShedID";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);


            insertCommand.Parameters.Add("@ShedID", SqlDbType.VarChar).Value = lbl1.Text;
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


            insertCommand.Parameters.Add("@XSchedDay", SqlDbType.VarChar).Value = txtNewSD.Text;
            insertCommand.Parameters.Add("@XTimeStart", SqlDbType.VarChar).Value = txtNewTS.Text;
            insertCommand.Parameters.Add("@XTmeEnd", SqlDbType.VarChar).Value = txtNewTE.Text;
            insertCommand.Parameters.Add("@XRoom", SqlDbType.VarChar).Value = txtNewRoom.Text;
            insertCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = lblSplit2.Text;


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
        
        }

        public void Saveshit() {
            try
            {


                SqlConnection connection = new SqlConnection(connectionstring.Trim());

                string insertStatement = "Insert into TSchedule(ShedID,SubjectCode,SchoolYear,Semester,Subject,Units,TeacherIDCode,TFirstname,TLastname,TDepartment,TCourse,SchedDay,Room,TimeStart,TmeEnd,XSchedDay,XRoom,XTimeStart,XTmeEnd,Type) VALUES (@ShedID,@SubjectCode,@SchoolYear,@Semester,@Subject,@Units,@TeacherIDCode,@TFirstname,@TLastname,@TDepartment,@TCourse,@SchedDay,@Room,@TimeStart,@TmeEnd,@XSchedDay,@XRoom,@XTimeStart,@XTmeEnd,@Type)";
                                                                                                                            
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                insertCommand.Parameters.Add("@ShedID", SqlDbType.VarChar).Value = lblAutoID.Text;
                insertCommand.Parameters.Add("@SubjectCode", SqlDbType.VarChar).Value = txtSubjectCode.Text;
                insertCommand.Parameters.Add("@SchoolYear", SqlDbType.VarChar).Value = txtSchoolYear.Text;
                insertCommand.Parameters.Add("@Semester", SqlDbType.VarChar).Value = txtSemester.Text;
                insertCommand.Parameters.Add("@Subject", SqlDbType.VarChar).Value = txtSubject.Text;
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


                insertCommand.Parameters.Add("@XSchedDay", SqlDbType.VarChar).Value = txtOldSched.Text;
                insertCommand.Parameters.Add("@XRoom", SqlDbType.VarChar).Value = txtOldRoom.Text;
                insertCommand.Parameters.Add("@XTimeStart", SqlDbType.VarChar).Value = txtOTS.Text;
                insertCommand.Parameters.Add("@XTmeEnd", SqlDbType.VarChar).Value = txtOTE.Text;


                insertCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = txtSplit.Text;


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
        }

        private void dataGridViewOld_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnTransfer_Click(object sender, System.EventArgs e)
        {

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

       

        private void AdminConfirmSplit_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

        }

        private void dataGridViewNew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
           
        }
    }
}
