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
    public partial class TeacherStudentsINC : Form
    {
        private string status = "0";
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public TeacherStudentsINC(string Firstname,string Tlastname,string IDNo)
        {    
            InitializeComponent();
            Tfirstname.Text = Firstname;
            tlastname.Text = Tlastname;
            TIDNo.Text = IDNo;
        }

        private void TeacherStudentsINC_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {

            if (txtSearch.Text.ToString().Length == 0)
            {
                MessageBox.Show("Search is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSearch.Focus();
                return;

            }

            this.status = "1";


            SearchDisplay();



            try
            {
                string sqlQuery = "SELECT *FROM Grade WHERE StudentIDCode ='" + txtSearch.Text + "' OR SFirstname ='" + txtSearch.Text + "' OR SLastname ='" + txtSearch.Text + "' ";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sda.Fill(table);


                lblFirstname.Text = table.Rows[0][2].ToString();
                lblLastname.Text = table.Rows[0][3].ToString();
                lblDept.Text = table.Rows[0][4].ToString();
                lblCourse.Text = table.Rows[0][5].ToString();




                sda.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Connot be found!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSearch.Text = "";
            }
                
            
        }

        public void SearchDisplay() {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Grade where  StudentIDCode like '" + txtSearch.Text + "%'  AND Remarks like '" + label1.Text + "%' OR SFirstname like '" + txtSearch.Text + "%'  AND Remarks like '" + label1.Text + "%' OR SLastname like '" + txtSearch.Text + "%'  AND Remarks like '" + label1.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = true;
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

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }
        private void dataGridView1_DoubleClick(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            string SubjectID = dataGridView1.SelectedRows[0].Cells["SubjectID"].Value.ToString();
            string SFirstname = dataGridView1.SelectedRows[0].Cells["SFirstname"].Value.ToString();
            string SLastname = dataGridView1.SelectedRows[0].Cells["SLastname"].Value.ToString();
            string Prelim = dataGridView1.SelectedRows[0].Cells["Prelim"].Value.ToString();
            string Midterm = dataGridView1.SelectedRows[0].Cells["Midterm"].Value.ToString();
            string Semfinal = dataGridView1.SelectedRows[0].Cells["Semfinal"].Value.ToString();
            string Finals = dataGridView1.SelectedRows[0].Cells["Finals"].Value.ToString();
            string Average = dataGridView1.SelectedRows[0].Cells["Average"].Value.ToString();
            string Pts70p = dataGridView1.SelectedRows[0].Cells["Pts70p"].Value.ToString();
            string Absent = dataGridView1.SelectedRows[0].Cells["Absent"].Value.ToString();
            string Pts10p = dataGridView1.SelectedRows[0].Cells["Pts10p"].Value.ToString();
            string Quizzes = dataGridView1.SelectedRows[0].Cells["Quizzes"].Value.ToString();
            string Pts20p = dataGridView1.SelectedRows[0].Cells["Pts20p"].Value.ToString();
            string Sum = dataGridView1.SelectedRows[0].Cells["Sum"].Value.ToString();
            string FinalRating = dataGridView1.SelectedRows[0].Cells["FinalRating"].Value.ToString();
            string Remarks = dataGridView1.SelectedRows[0].Cells["Remarks"].Value.ToString();

            TeacherUpdateINC input = new TeacherUpdateINC(SubjectID, SFirstname, SLastname, Prelim, Midterm, Semfinal, Finals, Average, Pts70p
                , Absent, Pts10p, Quizzes, Pts20p, Sum, FinalRating, Remarks);
            input.Show();
        }

        private void TeacherStudentsINC_Activated(object sender, System.EventArgs e)
        {

            if (this.status.Trim().Equals("1"))
            {

                SearchDisplay();

            }


            txtSearch.Text = "";
        }

        private void TeacherStudentsINC_FormClosing(object sender, FormClosingEventArgs e)
        {
            string Firstname = Tfirstname.Text;
            string Tlastname = tlastname.Text;
            string IDNo = TIDNo.Text;

            TeacherMain user = new TeacherMain(Tlastname,IDNo,Firstname);
            user.Show();
            this.Hide();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
           
            Clear();
        }


        private void Clear() {

            lblLastname.Text = "";
            lblFirstname.Text = "";
            lblCourse.Text = "";
            lblDept.Text = "";
            
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

       
    }
}
