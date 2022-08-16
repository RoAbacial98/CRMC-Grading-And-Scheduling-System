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
    public partial class AdminSubject : Form
    {
        private string status = "0";
      
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public AdminSubject(string Department, string Course, string SubjectCode, string Title, string Units)
        {
            InitializeComponent();
            lblDepartment.Text = Department;
            lblCourse.Text = Course;
            lblSC.Text = SubjectCode;
            lblSubject.Text = Title;
            lblunits.Text = Units;

           
            
        }  

        private void AdminSubject_Load(object sender, EventArgs e)
        {
           

            FillDepartment();
            this.status = "0";


           txtStudentcode.ReadOnly = true;
           txtSIDNo.ReadOnly =  true;
           lblStudentFirstname.ReadOnly = true;
           lblStudentLastname.ReadOnly = true;
           lblSDepartment.ReadOnly =  true;
           lblSCourse.ReadOnly = true;
           btnSearchStudent.Enabled =  false;

           txtTeacherCode.ReadOnly =  true;
           txtIDno.ReadOnly = true;
           lblTeacherFirstname.ReadOnly =  true;
           lblTeacherLastname.ReadOnly =  true;
           lblTdept.ReadOnly =  true;
           btnSearchTeacher.Enabled = false;

           cbSD.Enabled = false;
           dtptimestrart.Enabled = false;
           dtptimeend.Enabled = false;
           btnSave.Enabled = false;

           
        }
       
        public void FillDepartment()
        {


            SqlCommand cmd = new SqlCommand("Select  Schoolyear From Schoolyear", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            cbSchoolYear.Items.Clear();
            foreach (DataRow Row in table.Rows)
            {
                cbSchoolYear.Items.Add(Row["Schoolyear"].ToString());
            }

        }

        private void btnSearchStudent_Click(object sender, System.EventArgs e)
        {



            try
            {

                string sqlQuery = "SELECT *FROM Students WHERE StudentIDNo ='" + txtStudentcode.Text + "' OR  Firstname ='" + txtStudentcode.Text + "'  OR  Lastname ='" + txtStudentcode.Text + "' ";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);

                txtSIDNo.Text = table.Rows[0][4].ToString();
                lblStudentFirstname.Text = table.Rows[0][1].ToString();
                lblStudentLastname.Text = table.Rows[0][2].ToString();
                lblSDepartment.Text = table.Rows[0][3].ToString();
                lblSCourse.Text = table.Rows[0][5].ToString();
                sda.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Student not found in the database");
                txtStudentcode.Text = "";
                txtSIDNo.Text = "";
                lblStudentFirstname.Text = "";
                lblStudentLastname.Text = "";
                lblSDepartment.Text = "";
                lblSCourse.Text = "";
            }
        }

        private void btnSearchTeacher_Click(object sender, System.EventArgs e)
        {

            try
            {

                string sqlQuery = "SELECT *FROM Teachers WHERE IDNo ='" + txtTeacherCode.Text + "' OR  Firstname ='" + txtTeacherCode.Text + "'  OR  Lastname ='" + txtTeacherCode.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);

                txtIDno.Text = table.Rows[0][4].ToString();
                lblTeacherFirstname.Text = table.Rows[0][1].ToString();
                lblTeacherLastname.Text = table.Rows[0][2].ToString();
                lblTdept.Text = table.Rows[0][3].ToString();
                sda.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Teacher not found in the database");
                txtIDno.Text = "";
                lblTeacherFirstname.Text = "";
                lblTeacherLastname.Text = "";
                lblDepartment.Text = "";
                txtTeacherCode.Text = "";
            }


        }

        private void txtStudentcode_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtTeacherCode_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

     
        public void SaveDisplay()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from Grade where Subject like '" + lblSubject.Text + "%'  AND SchoolYear like '" + cbSchoolYear.Text + "%' AND Semester like '" + cbSemester.Text + "%' AND TLastname like '" + lblTeacherLastname.Text + "%'AND TDepartment like '" + lblDepartment.Text + "%'AND TCourse like '" + lblCourse.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].Visible = false;
            dataGridView1.Columns[27].Visible = false;
            dataGridView1.Columns[28].Visible = false;
            dataGridView1.Columns[29].Visible = false;
            dataGridView1.Columns[30].Visible = false;
            dataGridView1.Columns[31].Visible = false;


            dataGridView1.Columns[1].HeaderText = "ID Number";
            dataGridView1.Columns[2].HeaderText = "Firstname";
            dataGridView1.Columns[3].HeaderText = "Lastname";
            dataGridView1.Columns[5].HeaderText = "Course";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }
        public void TSchedule() {
            if (this.status.Trim().Equals("0"))
            {

                try
                {


                    SqlConnection connection = new SqlConnection(connectionstring.Trim());

                    string insertStatement = "Insert into TSchedule(ShedID,Subject,SchoolYear,Semester,SubjectCode,Units,TeacherIDCode,TFirstname,TLastname,TDepartment,TCourse,SchedDay,Room,TimeStart,TmeEnd,XSchedDay,XRoom,XTimeStart,XTmeEnd) VALUES (@ShedID,@Subject,@SchoolYear,@Semester,@SubjectCode,@Units,@TeacherIDCode,@TFirstname,@TLastname,@TDepartment,@TCourse,@SchedDay,@Room,@TimeStart,@TmeEnd,@XSchedDay,@XRoom,@XTimeStart,@XTmeEnd)";
                    
                    SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                    insertCommand.Parameters.Add("@Room", SqlDbType.VarChar).Value = cbRoom.Text;
                    insertCommand.Parameters.Add("@ShedID", SqlDbType.VarChar).Value = lblT1.Text;
                    insertCommand.Parameters.Add("@Subject", SqlDbType.VarChar).Value = lblSubject.Text;
                    insertCommand.Parameters.Add("@SchoolYear", SqlDbType.VarChar).Value = cbSchoolYear.Text;
                    insertCommand.Parameters.Add("@Semester", SqlDbType.VarChar).Value = cbSemester.Text;
                    insertCommand.Parameters.Add("@SubjectCode", SqlDbType.VarChar).Value = lblSC.Text;
                    insertCommand.Parameters.Add("@Units", SqlDbType.VarChar).Value = lblunits.Text;
                    insertCommand.Parameters.Add("@TeacherIDCode", SqlDbType.VarChar).Value = txtIDno.Text;
                    insertCommand.Parameters.Add("@TFirstname", SqlDbType.VarChar).Value = lblTeacherFirstname.Text;
                    insertCommand.Parameters.Add("@TLastname", SqlDbType.VarChar).Value = lblTeacherLastname.Text;
                    insertCommand.Parameters.Add("@TDepartment", SqlDbType.VarChar).Value = lblDepartment.Text;
                    insertCommand.Parameters.Add("@TCourse", SqlDbType.VarChar).Value = lblCourse.Text;
                    insertCommand.Parameters.Add("@SchedDay", SqlDbType.VarChar).Value = cbSD.Text;
                    insertCommand.Parameters.Add("@TimeStart", SqlDbType.VarChar).Value = dtptimestrart.Text;
                    insertCommand.Parameters.Add("@TmeEnd", SqlDbType.VarChar).Value = dtptimeend.Text;

                    insertCommand.Parameters.Add("@XSchedDay", SqlDbType.VarChar).Value = cbSD.Text;
                    insertCommand.Parameters.Add("@XRoom", SqlDbType.VarChar).Value = cbRoom.Text;
                    insertCommand.Parameters.Add("@XTimeStart", SqlDbType.VarChar).Value = dtptimestrart.Text;
                    insertCommand.Parameters.Add("@XTmeEnd", SqlDbType.VarChar).Value = dtptimeend.Text;


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
                    // MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }  
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (cbSD.Text.ToString().Length == 0)
            {
                MessageBox.Show("Shedule day  is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbSD.Focus();
                return;
            }
            if (txtStudentcode.Text.ToString().Length == 0)
            {
                MessageBox.Show("Studentcode is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStudentcode.Focus();
                return;
            }
         
            if (lblSDepartment.Text.ToString().Length == 0)
            {
                MessageBox.Show("Press Student Search", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblSDepartment.Focus();
                return;
            }
            if (lblTeacherLastname.Text.ToString().Length == 0)
            {
                MessageBox.Show("Press Teacher Search!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTeacherLastname.Focus();
                return;
            }

             //duplicate
            SqlCommand cmd = new SqlCommand("Select * from Grade where SFirstname = '" + lblStudentFirstname.Text + "' AND SLastname = '" + lblStudentLastname.Text + "'AND SDepartment = '" + lblSDepartment.Text + "' AND SCourse = '" + lblSCourse.Text + "' AND Subject = '" + lblSubject.Text + "' AND SchoolYear = '" + cbSchoolYear.Text + "' AND Semester = '" + cbSemester.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Student already Existed!!");
                    ds.Clear();
                    txtStudentcode.Text = "";
                    txtSIDNo.Text = "";
                    lblStudentFirstname.Text = "";
                    lblStudentLastname.Text = "";
                    lblSDepartment.Text = "";
                    lblSCourse.Text = "";
                }
                else
                {

                    if (MessageBox.Show("Do you want to Save Students info?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        try
                        {


                            SqlConnection connection = new SqlConnection(connectionstring.Trim());

                            string insertStatement = "Insert into Grade(StudentIDCode,SFirstname,SLastname,SDepartment,SCourse,Subject,SchoolYear,Semester,SubjectCode,Units,TeacherIDCode,TFirstname,TLastname,TDepartment,TCourse,SchedDay,TimeStart,TmeEnd) VALUES (@StudentIDCode,@SFirstname,@SLastname,@SDepartment,@SCourse,@Subject,@SchoolYear,@Semester,@SubjectCode,@Units,@TeacherIDCode,@TFirstname,@TLastname,@TDepartment,@TCourse,@SchedDay,@TimeStart,@TmeEnd)";

                            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                            insertCommand.Parameters.Add("@StudentIDCode", SqlDbType.VarChar).Value = txtSIDNo.Text;
                            insertCommand.Parameters.Add("@SFirstname", SqlDbType.VarChar).Value = lblStudentFirstname.Text;
                            insertCommand.Parameters.Add("@SLastname", SqlDbType.VarChar).Value = lblStudentLastname.Text;
                            insertCommand.Parameters.Add("@SDepartment", SqlDbType.VarChar).Value = lblSDepartment.Text;
                            insertCommand.Parameters.Add("@SCourse", SqlDbType.VarChar).Value = lblSCourse.Text;
                            insertCommand.Parameters.Add("@Subject", SqlDbType.VarChar).Value = lblSubject.Text;
                            insertCommand.Parameters.Add("@SchoolYear", SqlDbType.VarChar).Value = cbSchoolYear.Text;
                            insertCommand.Parameters.Add("@Semester", SqlDbType.VarChar).Value = cbSemester.Text;
                            insertCommand.Parameters.Add("@SubjectCode", SqlDbType.VarChar).Value = lblSC.Text;
                            insertCommand.Parameters.Add("@Units", SqlDbType.VarChar).Value = lblunits.Text;
                            insertCommand.Parameters.Add("@TeacherIDCode", SqlDbType.VarChar).Value = txtIDno.Text;
                            insertCommand.Parameters.Add("@TFirstname", SqlDbType.VarChar).Value = lblTeacherFirstname.Text;
                            insertCommand.Parameters.Add("@TLastname", SqlDbType.VarChar).Value = lblTeacherLastname.Text;
                            insertCommand.Parameters.Add("@TDepartment", SqlDbType.VarChar).Value = lblDepartment.Text;
                            insertCommand.Parameters.Add("@TCourse", SqlDbType.VarChar).Value = lblCourse.Text;
                            insertCommand.Parameters.Add("@SchedDay", SqlDbType.VarChar).Value = cbSD.Text;
                            insertCommand.Parameters.Add("@TimeStart", SqlDbType.VarChar).Value = dtptimestrart.Text;
                            insertCommand.Parameters.Add("@TmeEnd", SqlDbType.VarChar).Value = dtptimeend.Text;


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
                                SaveDisplay();
                                teacherAdd();
                                TSchedule();
                                connection.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            this.status = "1";

            txtSIDNo.Text = "";
            txtStudentcode.Text = "";
            lblSCourse.Text = "";
            lblSDepartment.Text = "";
            lblStudentFirstname.Text = "";
            lblStudentLastname.Text = "";
          }
        public void teacherAdd() {

             
                try
                {


                    SqlConnection connection = new SqlConnection(connectionstring.Trim());

                    string insertStatement = "Insert into CBTaeachers(SchoolYear,Semester,Course,Subject,Teacher) VALUES (@SchoolYear,@Semester,@Course,@Subject,@Teacher)";

                    SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                    insertCommand.Parameters.Add("@SchoolYear", SqlDbType.VarChar).Value = cbSchoolYear.Text;
                    insertCommand.Parameters.Add("@Semester", SqlDbType.VarChar).Value = cbSemester.Text;
                    insertCommand.Parameters.Add("@Course", SqlDbType.VarChar).Value = lblCourse.Text;
                    insertCommand.Parameters.Add("@Subject", SqlDbType.VarChar).Value = lblSubject.Text;
                    insertCommand.Parameters.Add("@Teacher", SqlDbType.VarChar).Value = lblTeacherLastname.Text;



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
                    // MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             

            

           
        }

       

      

        private void browse() {

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
            if (cbdisplayteachers.Text.ToString().Length == 0)
            {
                MessageBox.Show("Teachers is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbdisplayteachers.Focus();
                return;
            }

            //
            try
            {


                string sqlQuery = "SELECT *FROM TSchedule WHERE TLastname ='" + cbdisplayteachers.Text + "' AND Subject ='" + lblSubject.Text + "'AND SchoolYear ='" + cbSchoolYear.Text + "'AND Semester ='" + cbSemester.Text + "' ";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);

                txtIDno.Text = table.Rows[0][6].ToString();
                lblTeacherFirstname.Text = table.Rows[0][7].ToString();
                lblTeacherLastname.Text = table.Rows[0][8].ToString();
                lblTdept.Text = table.Rows[0][9].ToString();

                cbSD.Text = table.Rows[0][11].ToString();
                dtptimestrart.Text = table.Rows[0][12].ToString();
                dtptimeend.Text = table.Rows[0][13].ToString();





                sda.Dispose();
            }
            catch (Exception ex)
            {
            }
            //

            SearchDisplay();
            

            if (cbdisplayteachers.Text == "---NONE---")
            {
                txtTeacherCode.Text = "";
                txtIDno.Text = "";
                lblTeacherFirstname.Text = "";
                lblTeacherLastname.Text = "";
                lblTdept.Text = "";
                cbSD.Text = null;
                
            }
            else
            {

            }
        }

        public void SearchDisplay() {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from Grade where Subject like '" + lblSubject.Text + "%'  AND SchoolYear like '" + cbSchoolYear.Text + "%' AND Semester like '" + cbSemester.Text + "%' AND TLastname like '" + cbdisplayteachers.Text + "%'AND TDepartment like '" + lblDepartment.Text + "%'AND TCourse like '" + lblCourse.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].Visible = false;
            dataGridView1.Columns[27].Visible = false;
            dataGridView1.Columns[28].Visible = false;
            dataGridView1.Columns[29].Visible = false;
            dataGridView1.Columns[30].Visible = false;
            dataGridView1.Columns[31].Visible = false;


            dataGridView1.Columns[1].HeaderText = "ID Number";
            dataGridView1.Columns[2].HeaderText = "Firstname";
            dataGridView1.Columns[3].HeaderText = "Lastname";
            dataGridView1.Columns[5].HeaderText = "Course";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
   
            con.Close();
        }

        

        private void cbSchoolYear_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select  Semester From Semester where SchoolYear = '" + cbSchoolYear.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            cbSemester.Items.Clear();
            foreach (DataRow ab in table.Rows)
            {
                cbSemester.Items.Add(ab["Semester"].ToString());
            }

           
        }

        private void cbSemester_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
            

                SqlCommand cmd = new SqlCommand("Select  Teacher From CBTaeachers where SchoolYear = '" + cbSchoolYear.Text + "' AND Semester = '" + cbSemester.Text + "'AND Course = '" + lblCourse.Text + "'AND Subject = '" + lblSubject.Text + "' group by Teacher", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                cbdisplayteachers.Items.Clear();
                cbdisplayteachers.Items.Add("---NONE---");
                foreach (DataRow ab in table.Rows)
                {
                    cbdisplayteachers.Items.Add(ab["Teacher"].ToString());
                }

            
           
        }

        private void AdminSubject_Activated(object sender, System.EventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbdisplayteachers_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            
            
            if (cbdisplayteachers.Text == "---NONE---")
            {
                this.status = "0";
                txtStudentcode.ReadOnly = false;
                txtSIDNo.ReadOnly = false;
                lblStudentFirstname.ReadOnly = false;
                lblStudentLastname.ReadOnly = false;
                lblSDepartment.ReadOnly = false;
                lblSCourse.ReadOnly = false;
                btnSearchStudent.Enabled = true;

                txtTeacherCode.ReadOnly = false;
                txtIDno.ReadOnly = false;
                lblTeacherFirstname.ReadOnly = false;
                lblTeacherLastname.ReadOnly = false;
                lblTdept.ReadOnly = false;
                btnSearchTeacher.Enabled = true;

                cbSD.Enabled = true;
                dtptimestrart.Enabled = true;
                dtptimeend.Enabled = true;
                btnSave.Enabled = true;
            }
            else {
                this.status = "1";

                txtStudentcode.ReadOnly = false;
                txtSIDNo.ReadOnly = false;
                lblStudentFirstname.ReadOnly = false;
                lblStudentLastname.ReadOnly = false;
                lblSDepartment.ReadOnly = false;
                lblSCourse.ReadOnly = false;
                btnSearchStudent.Enabled = true;

                txtTeacherCode.Enabled = false;
                txtIDno.ReadOnly = true;
                lblTeacherFirstname.ReadOnly = true;
                lblTeacherLastname.ReadOnly = true;
                lblTdept.ReadOnly = true;
                btnSearchTeacher.Enabled = false;

                cbSD.Enabled = false;
                dtptimestrart.Enabled = false;
                dtptimeend.Enabled = false;
            }

            browse();
           
        }

       
        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete Grade  where SubjectID=@SubjectID";
            SqlParameter parm = new SqlParameter("@SubjectID", SqlDbType.VarChar);
            cmd.Parameters.Add(parm);

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                parm.Value = row.Cells["SubjectID"].Value;
                cmd.ExecuteNonQuery();



            }
            con.Close();
            SearchDisplay();
            MessageBox.Show("deleted");
        }

        private void txtTeacherCode_KeyDown(object sender, KeyEventArgs e)
        {
            this.status = "0";
            txtIDno.Text = "";
            lblTeacherFirstname.Text = "";
            lblTeacherLastname.Text = "";
            lblTdept.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtTeacherCode_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void cbSD_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void txtStudentcode_KeyDown(object sender, KeyEventArgs e)
        {
                txtSIDNo.Text = "";
                lblStudentFirstname.Text = "";
                lblStudentLastname.Text = "";
                    lblSDepartment.Text = "";
                    lblSCourse.Text = "";
        }

        private void cbSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cbdisplayteachers_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbSemester_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbSchoolYear.Text.ToString().Length == 0)
            {
                MessageBox.Show("Please select the SchoolYear first", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
        }

        private void cbdisplayteachers_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbSemester.Text.ToString().Length == 0)
            {
                MessageBox.Show("Please select the Semester first", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
        }

        private void AdminSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminSelectCourse user = new AdminSelectCourse();
            user.Show();
            this.Hide();
        }

      

     
    }
}
