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
    public partial class AdminScheduleView : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public AdminScheduleView()
        {
            InitializeComponent();
        }

        private void AdminScheduleView_Load(object sender, EventArgs e)
        {
            FillDepartment();
        }

        public void FillDepartment()
        {


            SqlCommand cmd = new SqlCommand("Select  Schoolyear From Schoolyear", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            cbSY.Items.Clear();
            foreach (DataRow Row in table.Rows)
            {
                cbSY.Items.Add(Row["Schoolyear"].ToString());
            }

        }

        private void cbSY_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select  Semester From Semester where SchoolYear = '" + cbSY.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            cbSem.Items.Clear();
            foreach (DataRow ab in table.Rows)
            {
                cbSem.Items.Add(ab["Semester"].ToString());
            }
        }

        private void cbSem_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
        }
        private void displaycbsubject() {

            SqlCommand cmd = new SqlCommand("Select  Subject From TSchedule where SchoolYear = '" + cbSY.Text + "' AND Semester = '" + cbSem.Text + "' AND TLastname = '" + ccbTeacher.Text + "' group by Subject", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            cbSubject.Items.Clear();

            foreach (DataRow ab in table.Rows)
            {
                cbSubject.Items.Add(ab["Subject"].ToString());
            }

        }


        private void ccbTeacher_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            displaycbsubject();

            try
            {


                string sqlQuery = "SELECT *FROM Teachers WHERE Lastname ='" + ccbTeacher.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);

                lblTeacherID.Text = table.Rows[0][4].ToString();
               





                sda.Dispose();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            SearchDisplay();
        }

        public void SearchDisplay()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from Grade where Subject like '" + cbSubject.Text + "%'  AND SchoolYear like '" + cbSY.Text + "%' AND Semester like '" + cbSem.Text + "%' AND TeacherIDCode like '" + lblTeacherID.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
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
            dataGridView1.Columns[19].Visible = true;
            dataGridView1.Columns[20].Visible = true;
            dataGridView1.Columns[21].Visible = true;
            dataGridView1.Columns[22].Visible = true;
            dataGridView1.Columns[23].Visible = true;
            dataGridView1.Columns[24].Visible = true;
            dataGridView1.Columns[25].Visible = true;
            dataGridView1.Columns[26].Visible = true;
            dataGridView1.Columns[27].Visible = true;
            dataGridView1.Columns[28].Visible = true;
            dataGridView1.Columns[29].Visible = true;
            dataGridView1.Columns[30].Visible = true;
            dataGridView1.Columns[31].Visible = true;

            dataGridView1.Columns[2].HeaderText = "Firstname";
            dataGridView1.Columns[3].HeaderText = "Lastname";
            dataGridView1.Columns[5].HeaderText = "Course";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }

        private void cbCourse_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select  Lastname From Teachers where Department = '" + cbCourse.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            ccbTeacher.Items.Clear();

            foreach (DataRow ab in table.Rows)
            {
                ccbTeacher.Items.Add(ab["Lastname"].ToString());
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow Myrow in dataGridView1.Rows)
                {            //Here 2 cell is target value and 1 cell is Volume
                    if (Myrow.Cells[31].Value.ToString() == "INC")// Or your condition 
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (Myrow.Cells[31].Value.ToString() == "FAILED")
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception) { }
        }

        private void AdminScheduleView_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAdminMain user = new frmAdminMain();
            user.Show();
            this.Hide();
        }
    }
}
