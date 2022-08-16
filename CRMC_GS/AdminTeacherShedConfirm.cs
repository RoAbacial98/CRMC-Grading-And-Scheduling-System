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
    public partial class AdminTeacherShedConfirm : Form
    {

        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public AdminTeacherShedConfirm()
        {
            InitializeComponent();  
        }

        private void AdminTeacherShedConfirm_Load(object sender, EventArgs e)
        {

            DisplayRecord();
        }

        public void DisplayRecord() {
            SqlCommand cmd = new SqlCommand("Select *From AdminConfrimSched", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = true;
            dataGridView1.Columns[11].Visible = true;
            dataGridView1.Columns[12].Visible = true;
            dataGridView1.Columns[13].Visible = true;
            dataGridView1.Columns[14].Visible = true;
            dataGridView1.Columns[15].Visible = true;
            dataGridView1.Columns[16].Visible = true;
            dataGridView1.Columns[17].Visible = true;
            dataGridView1.Columns[18].Visible = true;
            dataGridView1.Columns[19].Visible = true;
            dataGridView1.Columns[20].Visible = true;
        }

        private void dataGridView1_DoubleClick(object sender, System.EventArgs e)
        {
            if (lbltype.Text == "Update")
            {
                try
                {
                    DataTable dt = new DataTable();
                    string ShedID = dataGridView1.SelectedRows[0].Cells["ShedID"].Value.ToString();
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
                    string OLDSchedDay = dataGridView1.SelectedRows[0].Cells["OldShedDay"].Value.ToString();
                    string OLdDRoom = dataGridView1.SelectedRows[0].Cells["OldRoom"].Value.ToString();
                    string OLDTimeStart = dataGridView1.SelectedRows[0].Cells["OldTimeStart"].Value.ToString();
                    string OLDTmeEnd = dataGridView1.SelectedRows[0].Cells["OldTimeEnd"].Value.ToString();

                    string NewTimeStart = dataGridView1.SelectedRows[0].Cells["NewTimeStart"].Value.ToString();
                    string NewTimeEnd = dataGridView1.SelectedRows[0].Cells["NewTimeEnd"].Value.ToString();
                    string NewShedDay = dataGridView1.SelectedRows[0].Cells["NewShedDay"].Value.ToString();
                    string NewRoom = dataGridView1.SelectedRows[0].Cells["NewRoom"].Value.ToString();


                    AdminConfirmUpdate input = new AdminConfirmUpdate(SubjectCode, SchoolYear, Semester, Subject, Units, TeacherIDCode,
                        TFirstname, TLastname, TDepartment, TCourse, OLDSchedDay, OLdDRoom, OLDTimeStart, OLDTmeEnd, ShedID, NewTimeStart, NewTimeEnd,
                        NewShedDay, NewRoom);
                    input.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {

                try
                {
                    DataTable dt = new DataTable();
                    string ShedID = dataGridView1.SelectedRows[0].Cells["ShedID"].Value.ToString();
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
                    string OLDSchedDay = dataGridView1.SelectedRows[0].Cells["OldShedDay"].Value.ToString();
                    string OLDRoom = dataGridView1.SelectedRows[0].Cells["OldRoom"].Value.ToString();
                    string OLDTimeStart = dataGridView1.SelectedRows[0].Cells["OldTimeStart"].Value.ToString();
                    string OLDTmeEnd = dataGridView1.SelectedRows[0].Cells["OldTimeEnd"].Value.ToString();

                    string NewTimeStart = dataGridView1.SelectedRows[0].Cells["NewTimeStart"].Value.ToString();
                    string NewTimeEnd = dataGridView1.SelectedRows[0].Cells["NewTimeEnd"].Value.ToString();
                    string NewShedDay = dataGridView1.SelectedRows[0].Cells["NewShedDay"].Value.ToString();
                    string NewRoom = dataGridView1.SelectedRows[0].Cells["NewRoom"].Value.ToString();


                    AdminConfirmSplit input = new AdminConfirmSplit(SubjectCode, SchoolYear, Semester, Subject, Units, TeacherIDCode,
                        TFirstname, TLastname, TDepartment, TCourse, OLDSchedDay, OLDRoom, OLDTimeStart, OLDTmeEnd, ShedID, NewTimeStart, NewTimeEnd,
                        NewShedDay, NewRoom);
                    input.Show();


                } catch(Exception){
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbltype.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void AdminTeacherShedConfirm_Activated(object sender, System.EventArgs e)
        {
            DisplayRecord();
        }

        private void AdminTeacherShedConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAdminMain user = new frmAdminMain();
            user.Show();
            this.Hide();
        }

       
    }
}
