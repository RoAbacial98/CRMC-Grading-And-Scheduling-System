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
    public partial class AdminPrintPros : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public AdminPrintPros()
        {
            InitializeComponent();
        }

        private void AdminPrintPros_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.ToString().Length == 0)
            {
                MessageBox.Show("Search is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSearch.Focus();
                return;
            }

            SearchDisplay();
        }
         
        private void SearchDisplay() {

            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Grade where StudentIDCode like '" + txtSearch.Text + "%' OR SFirstname like '" + txtSearch.Text + "%' OR SLastname like '" + txtSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = true;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = true;
            dataGridView1.Columns[10].Visible = true;
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
            dataGridView1.Columns[30].Visible = true;
            dataGridView1.Columns[31].Visible = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

           
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
           
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

        private void AdminPrintPros_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAdminMain user = new frmAdminMain();
            user.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.ToString().Length == 0)
            {
                MessageBox.Show("Search is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSearch.Focus();
                return;
            }
            

            CCSPrint user = new CCSPrint();
            user.Show();
            if(con.State != ConnectionState.Open){
                con.Open();
            }
            string s = "select * from Grade where StudentIDCode like '" + txtSearch.Text + "%' OR SFirstname like '" + txtSearch.Text + "%' OR SLastname like '" + txtSearch.Text + "%'";
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds,"Grade");
            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(ds);
            user.crystalReportViewer1.ReportSource = cr1;
            user.crystalReportViewer1.Refresh();
            con.Close();
        }
    }
}
