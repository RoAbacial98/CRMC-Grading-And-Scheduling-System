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
    public partial class TeacherGrading : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");
        public TeacherGrading(string Department, string Course, string SubjectCode, string Title, string Units, string SchedDay,
            string TimeStart, string TmeEnd, string SY, string Sem, string IDNo, string Tlastname, string Firstname)
        {
            InitializeComponent();
            lblDepartment.Text = Department;
            lblCourse.Text = Course;
            lblSC.Text = SubjectCode;
            lblSubject.Text = Title;
            lblunits.Text = Units;
            txtSchoolYear.Text = SY;
            txtSemester.Text = Sem;

            lblSD.Text = SchedDay;
            lblTS.Text = TimeStart;
            lblTE.Text = TmeEnd;

            lblIDno.Text = IDNo;
            cherLastname.Text = Tlastname;
            cherfirstname.Text = Firstname;
        }

        private void TeacherGrading_Load(object sender, EventArgs e)
        {
            SearchDisplay();
            
        }
        public void SearchDisplay()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from Grade where Subject like '" + lblSubject.Text + "%' AND SchoolYear like '" + txtSchoolYear.Text + "%' AND Semester like '" + txtSemester.Text + "%'AND TeacherIDCode like '" + lblIDno.Text + "%' AND TDepartment like '" + lblDepartment.Text + "%'AND TCourse like '" + lblCourse.Text + "%'AND SchedDay like '" + lblSD.Text + "%'AND TimeStart like '" + lblTS.Text + "%'AND TmeEnd like '" + lblTE.Text + "%'", con);
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

        

        private void cbABoard_CheckedChanged(object sender, System.EventArgs e)
        {
            if (txtAbsences.Text.ToString().Length == 0)
            {
                //MessageBox.Show("Abasenses day  is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // txtAbsences.Focus();
                cbABoard.Checked = false;
                return;
            }
            
            double score = Convert.ToDouble(txtAbsences.Text);
            //int i1 = Convert.ToInt32(score);

            if (cbABoard.Checked)
            {
                if (txtAbsences.Text == "0")
                {
                    txt10.Text = "10";
                }
                else if (txtAbsences.Text == "1")
                {
                    txt10.Text = "9.70";
                }
                else if (txtAbsences.Text == "1.5")
                {
                    txt10.Text = "9.55";
                }
                else if (txtAbsences.Text == "2")
                {
                    txt10.Text = "9.40";
                }
                else if (txtAbsences.Text == "2.5")
                {
                    txt10.Text = "9.25";
                }
                else if (txtAbsences.Text == "3")
                {
                    txt10.Text = "9.10";
                }
                else if (txtAbsences.Text == "3.5")
                {
                    txt10.Text = "8.95";
                }
                else if (txtAbsences.Text == "4")
                {
                    txt10.Text = "8.80";
                }
                else if (txtAbsences.Text == "4.5")
                {
                    txt10.Text = "8.60";
                }
                else if (txtAbsences.Text == "5")
                {
                    txt10.Text = "8.50";
                }
                else if (txtAbsences.Text == "5.5")
                {
                    txt10.Text = "8.35";
                }
                else if (txtAbsences.Text == "6")
                {
                    txt10.Text = "8.20";
                }
                else if (txtAbsences.Text == "6.5")
                {
                    txt10.Text = "8.05";
                }
                else if (txtAbsences.Text == "7")
                {
                    txt10.Text = "7.90";
                }
                else if (txtAbsences.Text == "7.5")
                {
                    txt10.Text = "7.75";
                }
                else if (txtAbsences.Text == "8")
                {
                    txt10.Text = "7.60";
                }
                else if (txtAbsences.Text == "8.5")
                {
                    txt10.Text = "7.45";
                }
                else if (txtAbsences.Text == "9")
                {
                    txt10.Text = "7.30";
                }
                else if (txtAbsences.Text == "9.5")
                {
                    txt10.Text = "7.15";
                }
                else if (txtAbsences.Text == "10")
                {
                    txt10.Text = "7.0";
                }
                else if (score >= 11)
                {
                    txt10.Text = "Dropped";
                }
              
                
              
               

            }
            else
            {
                txtAbsences.Text = "";
                txt10.Text = "";
            }

          
        }

        private void cbANonBoard_CheckedChanged(object sender, System.EventArgs e)
        {
            if (txtAbsences.Text.ToString().Length == 0)
            {
             //   MessageBox.Show("Abasenses day  is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // txtAbsences.Focus();
                cbANonBoard.Checked = false;
                return;
            }
            if (cbANonBoard.Checked)
            {
                if (txtAbsences.Text == "0")
                {
                    txt10.Text = "10";
                }
                else if (txtAbsences.Text == "1")
                {
                    txt10.Text = "9.6";
                }
                else if (txtAbsences.Text == "1.5")
                {
                    txt10.Text = "9.4";
                }
                else if (txtAbsences.Text == "2")
                {
                    txt10.Text = "9.2";
                }
                else if (txtAbsences.Text == "2.5")
                {
                    txt10.Text = "9.0";
                }
                else if (txtAbsences.Text == "3")
                {
                    txt10.Text = "8.8";
                }
                else if (txtAbsences.Text == "3.5")
                {
                    txt10.Text = "8.6";
                }
                else if (txtAbsences.Text == "4")
                {
                    txt10.Text = "8.4";
                }
                else if (txtAbsences.Text == "4.5")
                {
                    txt10.Text = "8.2";
                }
                else if (txtAbsences.Text == "5")
                {
                    txt10.Text = "8.0";
                }
                else if (txtAbsences.Text == "5.5")
                {
                    txt10.Text = "7.8";
                }
                else if (txtAbsences.Text == "6")
                {
                    txt10.Text = "7.6";
                }
                else if (txtAbsences.Text == "6.5")
                {
                    txt10.Text = "7.4";
                }
                else if (txtAbsences.Text == "7")
                {
                    txt10.Text = "7.2";
                }
                else if (txtAbsences.Text == "7.5")
                {
                    txt10.Text = "7.0";
                }
                else if (txtAbsences.Text == "8")
                {
                    txt10.Text = "6.8";
                }
                else if (txtAbsences.Text == "8.5")
                {
                    txt10.Text = "6.6";
                }
                else if (txtAbsences.Text == "9")
                {
                    txt10.Text = "6.4";
                }
                else if (txtAbsences.Text == "9.5")
                {
                    txt10.Text = "6.2";
                }
                else if (txtAbsences.Text == "10")
                {
                    txt10.Text = "6.0";
                }
                else if (double.Parse(txtAbsences.Text) >= 11)
                {
                    txt10.Text = "SDroped";
                }

            }
            else
            {
                txtAbsences.Text = "";
                txt10.Text = "";
            }
        }

        private void cbSBoard_CheckedChanged(object sender, System.EventArgs e)
        {

            if (cbSBoard.Checked)
            {
                if (txtPrelim.Text.ToString().Length == 0 || txtMidterm.Text.ToString().Length == 0 || txtSemifinal.Text.ToString().Length == 0
                || txtFinals.Text.ToString().Length == 0 || txtAbsences.Text.ToString().Length == 0 || txtWdAve.Text.ToString().Length == 0)
                {
                    txtRemarks.Text = "INC";
                }
                else
                {
                    double ro = double.Parse(txtSum.Text);
                    if (ro >= 0 && ro <= 1.99)
                    {
                        txtFR.Text = "5.0";
                        txtRemarks.Text = "FAILED";
                    }
                    else if (ro >= 2 && ro <= 5.99)
                    {
                        txtFR.Text = "4.9";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 6 && ro <= 8.99)
                    {
                        txtFR.Text = "4.8";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 9 && ro <= 12.99)
                    {
                        txtFR.Text = "4.7";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 13 && ro <= 15.99)
                    {
                        txtFR.Text = "4.6";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 16 && ro <= 19.99)
                    {
                        txtFR.Text = "4.5";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 20 && ro <= 22.99)
                    {
                        txtFR.Text = "4.4";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 23 && ro <= 26.99)
                    {
                        txtFR.Text = "4.3";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 27 && ro <= 29.99)
                    {
                        txtFR.Text = "4.2";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 30 && ro <= 33.99)
                    {
                        txtFR.Text = "4.1";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 34 && ro <= 36.99)
                    {
                        txtFR.Text = "4.0";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 37 && ro <= 40.99)
                    {
                        txtFR.Text = "3.9";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 41 && ro <= 43.99)
                    {
                        txtFR.Text = "3.8";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 44 && ro <= 47.99)
                    {
                        txtFR.Text = "3.7";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 48 && ro <= 50.99)
                    {
                        txtFR.Text = "3.6";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 51 && ro <= 54.99)
                    {
                        txtFR.Text = "3.5";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 55 && ro <= 57.99)
                    {
                        txtFR.Text = "3.4";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 58 && ro <= 61.99)
                    {
                        txtFR.Text = "3.3";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 62 && ro <= 64.99)
                    {
                        txtFR.Text = "3.2";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 65 && ro <= 68.99)
                    {
                        txtFR.Text = "3.1";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (ro >= 69 && ro <= 70.99)
                    {
                        txtFR.Text = "3.0";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 71 && ro <= 72.99)
                    {
                        txtFR.Text = "2.9";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 73 && ro <= 73.99)
                    {
                        txtFR.Text = "2.8";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 74 && ro <= 75.99)
                    {
                        txtFR.Text = "2.7";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 76 && ro <= 76.99)
                    {
                        txtFR.Text = "2.6";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 77 && ro <= 78.99)
                    {
                        txtFR.Text = "2.5";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 79 && ro <= 79.99)
                    {
                        txtFR.Text = "2.4";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 80 && ro <= 81.99)
                    {
                        txtFR.Text = "2.3";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 82 && ro <= 82.99)
                    {
                        txtFR.Text = "2.2";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 83 && ro <= 84.99)
                    {
                        txtFR.Text = "2.1";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 85 && ro <= 85.99)
                    {
                        txtFR.Text = "2.0";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 86 && ro <= 87.99)
                    {
                        txtFR.Text = "1.9";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 88 && ro <= 88.99)
                    {
                        txtFR.Text = "1.8";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 89 && ro <= 90.99)
                    {
                        txtFR.Text = "1.7";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 91 && ro <= 91.99)
                    {
                        txtFR.Text = "1.6";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 92 && ro <= 93.99)
                    {
                        txtFR.Text = "1.5";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 94 && ro <= 94.99)
                    {
                        txtFR.Text = "1.4";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 95 && ro <= 96.99)
                    {
                        txtFR.Text = "1.3";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 97 && ro <= 97.99)
                    {
                        txtFR.Text = "1.2";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 98 && ro <= 99.99)
                    {
                        txtFR.Text = "1.1";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (ro >= 100)
                    {
                        txtFR.Text = "1.0";
                        txtRemarks.Text = "PASSED";

                    }

                    else
                    {
                        txtSum.Text = "";
                        txtFR.Text = "";

                    }

                }

            }
            else
            {
                txtRemarks.Text = "";
                txtFR.Text = "";
            }
        }

        private void cbSNonBoard_CheckedChanged(object sender, System.EventArgs e)
        {
            if (cbSNonBoard.Checked)
            {


                if (txtPrelim.Text.ToString().Length == 0 || txtMidterm.Text.ToString().Length == 0 || txtSemifinal.Text.ToString().Length == 0
                  || txtFinals.Text.ToString().Length == 0 || txtAbsences.Text.ToString().Length == 0 || txtWdAve.Text.ToString().Length == 0)
                {
                    txtRemarks.Text = "INC";
                }
                else {  double rs = double.Parse(txtSum.Text);
                    if (rs >= 0 && rs <= 1.99)
                    {
                        txtFR.Text = "5.0";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 2 && rs <= 4.99)
                    {
                        txtFR.Text = "4.9";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 5 && rs <= 7.99)
                    {
                        txtFR.Text = "4.8";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 8 && rs <= 10.99)
                    {
                        txtFR.Text = "4.7";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 11 && rs <= 13.99)
                    {
                        txtFR.Text = "4.6";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 14 && rs <= 16.99)
                    {
                        txtFR.Text = "4.5";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 17 && rs <= 19.99)
                    {
                        txtFR.Text = "4.4";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 20 && rs <= 22.99)
                    {
                        txtFR.Text = "4.3";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 23 && rs <= 25.99)
                    {
                        txtFR.Text = "4.2";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 26 && rs <= 28.99)
                    {
                        txtFR.Text = "4.1";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 29 && rs <= 31.99)
                    {
                        txtFR.Text = "4.0";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 32 && rs <= 34.99)
                    {
                        txtFR.Text = "3.9";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 35 && rs <= 37.99)
                    {
                        txtFR.Text = "3.8";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 38 && rs <= 40.99)
                    {
                        txtFR.Text = "3.7";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 41 && rs <= 43.99)
                    {
                        txtFR.Text = "3.6";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 44 && rs <= 46.99)
                    {
                        txtFR.Text = "3.5";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 47 && rs <= 49.99)
                    {
                        txtFR.Text = "3.4";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 50 && rs <= 52.99)
                    {
                        txtFR.Text = "3.3";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 53 && rs <= 55.99)
                    {
                        txtFR.Text = "3.2";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 56 && rs <= 58.99)
                    {
                        txtFR.Text = "3.1";
                        txtRemarks.Text = "FAILED";

                    }
                    else if (rs >= 59 && rs <= 61.99)
                    {
                        txtFR.Text = "3.0";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 62 && rs <= 63.99)
                    {
                        txtFR.Text = "2.9";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 64 && rs <= 65.99)
                    {
                        txtFR.Text = "2.8";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 66 && rs <= 67.99)
                    {
                        txtFR.Text = "2.7";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 68 && rs <= 69.99)
                    {
                        txtFR.Text = "2.6";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 70 && rs <= 71.99)
                    {
                        txtFR.Text = "2.5";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 72 && rs <= 73.99)
                    {
                        txtFR.Text = "2.4";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 74 && rs <= 75.99)
                    {
                        txtFR.Text = "2.3";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 76 && rs <= 77.99)
                    {
                        txtFR.Text = "2.2";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 78 && rs <= 79.99)
                    {
                        txtFR.Text = "2.1";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 80 && rs <= 81.99)
                    {
                        txtFR.Text = "2.0";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 82 && rs <= 83.99)
                    {
                        txtFR.Text = "1.9";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 84 && rs <= 85.99)
                    {
                        txtFR.Text = "1.8";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 86 && rs <= 87.99)
                    {
                        txtFR.Text = "1.7";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 88 && rs <= 89.99)
                    {
                        txtFR.Text = "1.6";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 90 && rs <= 91.99)
                    {
                        txtFR.Text = "1.5";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 92 && rs <= 93.99)
                    {
                        txtFR.Text = "1.4";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 94 && rs <= 95.99)
                    {
                        txtFR.Text = "1.3";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 96 && rs <= 97.99)
                    {
                        txtFR.Text = "1.2";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 98 && rs <= 99.99)
                    {
                        txtFR.Text = "1.1";
                        txtRemarks.Text = "PASSED";

                    }
                    else if (rs >= 100)
                    {
                        txtFR.Text = "1.0";
                        txtRemarks.Text = "PASSED";

                    }
                else
                {
                    txtSum.Text = "";
                    txtFR.Text = "";
                    
                }
                
                }

            }
            else
            {
                txtRemarks.Text = "";
                txtFR.Text = "";
            }
            
            
        }

        private void txtMidterm_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                txtAverage.Text = ((float.Parse(txtPrelim.Text) + float.Parse(txtMidterm.Text)) / 2).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txtSemifinal_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                txtAverage.Text = ((float.Parse(txtPrelim.Text) + float.Parse(txtMidterm.Text) + float.Parse(txtSemifinal.Text)) / 3).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txtAverage_TextChanged(object sender, System.EventArgs e)
        {
           

            try
            {
                txt70.Text = (float.Parse(txtAverage.Text) * 0.7).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txtFinals_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                txtAverage.Text = ((float.Parse(txtPrelim.Text) + float.Parse(txtMidterm.Text) + float.Parse(txtSemifinal.Text) + float.Parse(txtFinals.Text)) / 4).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txt70_TextChanged(object sender, System.EventArgs e)
        {
            if (txtWdAve.Text.ToString().Length == 0 || txt10.Text.ToString().Length == 0)
            {

            }
            else
            {

                try
                {
                    txtSum.Text = (float.Parse(txt70.Text) + float.Parse(txt10.Text) + float.Parse(txt20.Text)).ToString("0.00");
                }
                catch
                {
                }
            }
        }

        private void txtPrelim_KeyDown(object sender, KeyEventArgs e)
        {
            txtAverage.Text = "";
            txt70.Text = "";
            txtSum.Text = "";
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;
        }

        private void txtMidterm_KeyDown(object sender, KeyEventArgs e)
        {
            txtAverage.Text = "";
            txt70.Text = "";
            txtSum.Text = "";
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;
        }

        private void txtWdAve_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                txt20.Text = (float.Parse(txtWdAve.Text) * 0.2).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txtWdAve_KeyDown(object sender, KeyEventArgs e)
        {
            txt20.Text = "";
            txtSum.Text = "";
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;
        }

        private void txtSum_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void txt20_TextChanged(object sender, System.EventArgs e)
        {
            if (txtPrelim.Text.ToString().Length == 0 || txtMidterm.Text.ToString().Length == 0 || txtSemifinal.Text.ToString().Length == 0
             || txtFinals.Text.ToString().Length == 0 || txt10.Text.ToString().Length == 0)
            {

            }

            else {
                try
                {
                    txtSum.Text = (float.Parse(txt70.Text) + float.Parse(txt10.Text) + float.Parse(txt20.Text)).ToString("0.00");
                }
                catch
                {
                }
            }
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.RowHeadersVisible = true;

            lblID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFirstname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtLastname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            txtPrelim.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            txtMidterm.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            txtSemifinal.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            txtFinals.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            txtAverage.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            txt70.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
            txtAbsences.Text = dataGridView1.CurrentRow.Cells[25].Value.ToString();
            txt10.Text = dataGridView1.CurrentRow.Cells[26].Value.ToString();
            txtWdAve.Text = dataGridView1.CurrentRow.Cells[27].Value.ToString();
            txt20.Text = dataGridView1.CurrentRow.Cells[28].Value.ToString();
            txtSum.Text = dataGridView1.CurrentRow.Cells[29].Value.ToString();
            txtFR.Text = dataGridView1.CurrentRow.Cells[30].Value.ToString();
            txtRemarks.Text = dataGridView1.CurrentRow.Cells[31].Value.ToString();
           
            
        }

        private void txtSum_KeyDown(object sender, KeyEventArgs e)
        {
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (txtRemarks.Text.ToString().Length == 0)
            {
                MessageBox.Show("Remarks day  is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRemarks.Focus();
                
                return;
            }

            if (MessageBox.Show("Do you want to Save Grade info?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {


                    SqlConnection connection = new SqlConnection(connectionstring.Trim());

                    string insertStatement = "UPDATE Grade SET Prelim=@Prelim,Midterm=@Midterm,Semfinal=@Semfinal,Finals=@Finals,Average=@Average,Pts70p=@Pts70p,Absent=@Absent,Pts10p=@Pts10p,Quizzes=@Quizzes,Pts20p=@Pts20p,Sum=@Sum,FinalRating=@FinalRating,Remarks=@Remarks  WHERE SubjectID=@SubjectID";

                    SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                    insertCommand.Parameters.Add("@SubjectID", SqlDbType.VarChar).Value = lblID.Text;
                    insertCommand.Parameters.Add("@Prelim", SqlDbType.VarChar).Value = txtPrelim.Text;
                    insertCommand.Parameters.Add("@Midterm", SqlDbType.VarChar).Value = txtMidterm.Text;
                    insertCommand.Parameters.Add("@Semfinal", SqlDbType.VarChar).Value = txtSemifinal.Text;
                    insertCommand.Parameters.Add("@Finals", SqlDbType.VarChar).Value = txtFinals.Text;
                    insertCommand.Parameters.Add("@Average", SqlDbType.VarChar).Value = txtAverage.Text;
                    insertCommand.Parameters.Add("@Pts70p", SqlDbType.VarChar).Value = txt70.Text;
                    insertCommand.Parameters.Add("@Absent", SqlDbType.VarChar).Value = txtAbsences.Text;
                    insertCommand.Parameters.Add("@Pts10p", SqlDbType.VarChar).Value = txt10.Text;
                    insertCommand.Parameters.Add("@Quizzes", SqlDbType.VarChar).Value = txtWdAve.Text;
                    insertCommand.Parameters.Add("@Pts20p", SqlDbType.VarChar).Value = txt20.Text;
                    insertCommand.Parameters.Add("@Sum", SqlDbType.VarChar).Value = txtSum.Text;
                    insertCommand.Parameters.Add("@FinalRating", SqlDbType.VarChar).Value = txtFR.Text;
                    insertCommand.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txtRemarks.Text;
                   

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
                        SearchDisplay();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


             lblID.Text = "";
             txtFirstname.Text = "";
             txtLastname.Text = "";
             txtPrelim.Text = "";
             txtMidterm.Text = "";
             txtSemifinal.Text = "";
             txtFinals.Text = "";
             txtAverage.Text = "";
             txt70.Text = "";
             txtAbsences.Text = "";
             txt10.Text = "";
             txtWdAve.Text = "";
             txt20.Text = "";
             txtSum.Text = "";
             txtFR.Text = "";
             txtRemarks.Text = "";
             cbABoard.Checked = false;
             cbANonBoard.Checked = false;
             cbSBoard.Checked = false;
             cbSNonBoard.Checked = false;

      
        }

        private void txtAbsences_KeyDown(object sender, KeyEventArgs e)
        {
            txt10.Text = "";
            txtSum.Text = "";
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbABoard.Checked = false;
            cbANonBoard.Checked = false;
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;
        }

        private void txtRemarks_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void txtAbsences_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txt10_TextChanged(object sender, System.EventArgs e)
        {
            if (txtPrelim.Text.ToString().Length == 0 || txtMidterm.Text.ToString().Length == 0 || txtSemifinal.Text.ToString().Length == 0
              || txtFinals.Text.ToString().Length == 0 || txtWdAve.Text.ToString().Length == 0)
            {

            }
            else {

                try
                {
                    txtSum.Text = (float.Parse(txt70.Text) + float.Parse(txt10.Text) + float.Parse(txt20.Text)).ToString("0.00");
                }
                catch
                {
                }
            
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
            catch(Exception) { }
            
        }

        private void txtPrelim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMidterm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSemifinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFinals_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAbsences_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtWdAve_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrelim_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                txtAverage.Text = ((float.Parse(txtPrelim.Text) + float.Parse(txtMidterm.Text)) / 2).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txtSemifinal_KeyDown(object sender, KeyEventArgs e)
        {
            txtAverage.Text = "";
            txt70.Text = "";
            txtSum.Text = "";
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;
        }

        private void txtFinals_KeyDown(object sender, KeyEventArgs e)
        {
            txtAverage.Text = "";
            txt70.Text = "";
            txtSum.Text = "";
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;
        }

        private void TeacherGrading_Activated(object sender, System.EventArgs e)
        {
           
        }

        private void TeacherGrading_FormClosing(object sender, FormClosingEventArgs e)
        {
            string Firstname = cherfirstname.Text;
            string Tlastname = cherLastname.Text;
            string IDNo = lblIDno.Text;

            TeacherMain user = new TeacherMain(Tlastname, IDNo, Firstname);
            user.Show();
            this.Hide();
        }

       
    }
}
