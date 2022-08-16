using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class AdminPSYCHOLOGY_Pros : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");
        public AdminPSYCHOLOGY_Pros()
        {
            InitializeComponent();
        }

        private void AdminPSYCHOLOGY_Pros_Load(object sender, EventArgs e)
        {
            DisplayRecord();
        }
        private void DisplayRecord()
        {
            SqlCommand cmd = new SqlCommand("Select *From PSYCHOLOGY_Pros", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

      
        public void browse() {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from PSYCHOLOGY_Pros where StudentsYear like '" + cbYearLevel.Text + "%' AND Semester like '" + cbsemester.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
 
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from PSYCHOLOGY_Pros where Title like '" + txtSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_DoubleClick(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            string Department = dataGridView1.SelectedRows[0].Cells["Department"].Value.ToString();
            string Course = dataGridView1.SelectedRows[0].Cells["Course"].Value.ToString();
            string SubjectCode = dataGridView1.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
            string Title = dataGridView1.SelectedRows[0].Cells["Title"].Value.ToString();
            string Units = dataGridView1.SelectedRows[0].Cells["Units"].Value.ToString();

            AdminSubject input = new AdminSubject(Department, Course, SubjectCode, Title, Units);
            input.Show();
            this.Hide();
        }

        private void AdminPSYCHOLOGY_Pros_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminSelectCourse user = new AdminSelectCourse();
            user.Show();
            this.Hide();
        }

        private void cbsemester_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            browse();
        }

    }
}
