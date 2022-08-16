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
    public partial class TeachersRoomSchedule : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public TeachersRoomSchedule(string IDNo,string Tlastname,string Firstname,string year,string sem)
        {
            InitializeComponent();
            label1.Text = year;
            label2.Text = sem;
            label3.Text = IDNo;
            label4.Text = Tlastname;
            label5.Text = Firstname;
        }

        private void TeachersRoomSchedule_Load(object sender, EventArgs e)
        {

        }

        public void SearchDisplay()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select Subject,TFirstname+ ' ' + TLastname as Name ,SchedDay,Room,TimeStart+ '-' +TmeEnd as Time  from TSchedule where  Room like '" + cbRoom.Text + "%' AND SchoolYear like '" + label1.Text + "%' AND Semester like '" + label2.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[2].HeaderText = "Schedule";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            con.Close();
        }

        private void TeachersRoomSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            string IDNo = label3.Text;
            string Tlastname = label4.Text;
            string Firstname = label5.Text;


            TeacherMain input = new TeacherMain(Tlastname, IDNo, Firstname);
            input.Show();
            this.Hide();
        }

        private void cbRoom_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SearchDisplay();
        }
    }
}
