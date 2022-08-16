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
    public partial class AdminDeleteFailed : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public AdminDeleteFailed()
        {
            InitializeComponent();
        }

        private void AdminDeleteFailed_Load(object sender, EventArgs e)
        {
            SearchDisplay();
        }

        public void SearchDisplay()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from Grade where Remarks like '" + lblFAILED.Text + "%'", con);
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

            dataGridView1.Columns[2].HeaderText = "Firstname";
            dataGridView1.Columns[3].HeaderText = "Lastname";
            dataGridView1.Columns[5].HeaderText = "Course";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.Close();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (lblFAILED.Text.Trim().Length > 0)
            {

                if (MessageBox.Show("Do you want to delete this Student with an Failed " + lblFAILED.Text.Trim() + " ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionstring.Trim());

                        string insertStatement = "Delete FROM Grade WHERE Remarks ='" + lblFAILED.Text.Trim() + "'";

                        SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                        int row = 0;

                        try
                        {
                            connection.Open();
                            row = insertCommand.ExecuteNonQuery();

                            SearchDisplay();
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

            }
        }

        private void AdminDeleteFailed_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAdminMain user = new frmAdminMain();
            user.Show();
            this.Hide();
        }
    }
}
