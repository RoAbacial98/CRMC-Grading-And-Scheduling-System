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
    public partial class TeacherUpdateINC : Form
    {

        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");
        public TeacherUpdateINC(string SubjectID, string SFirstname, string SLastname, string Prelim, string Midterm, string Semfinal, string Finals, string Average
            , string Pts70p, string Absent, string Pts10p, string Quizzes, string Pts20p, string Sum, string FinalRating, string Remarks)
        {
            InitializeComponent();
            lblID.Text = SubjectID;
            txtFirstname.Text = SFirstname;
            txtLastname.Text = SLastname;
            txtPrelim.Text = Prelim;
            txtMidterm.Text = Midterm;
            txtSemifinal.Text = Semfinal;
            txtFinals.Text = Finals;
            txtAverage.Text = Average;
            txt70.Text = Pts70p;
            txtAbsences.Text = Absent;
            txt10.Text = Pts10p;
            txtWdAve.Text = Quizzes;
            txt20.Text = Pts20p;
            txtSum.Text = Sum;
            txtFR.Text = FinalRating;
            txtRemarks.Text = Remarks;
        }

        private void TeacherUpdateINC_Load(object sender, EventArgs e)
        {

           
        }

        private void cbABoard_CheckedChanged(object sender, EventArgs e)
        {
            if (txtAbsences.Text.ToString().Length == 0)
            {
              //  MessageBox.Show("Abasenses day  is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void cbANonBoard_CheckedChanged(object sender, EventArgs e)
        {
            if (txtAbsences.Text.ToString().Length == 0)
            {
               // MessageBox.Show("Abasenses day  is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              //  txtAbsences.Focus();
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

        private void cbSBoard_CheckedChanged(object sender, EventArgs e)
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

        private void cbSNonBoard_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSNonBoard.Checked)
            {


                if (txtPrelim.Text.ToString().Length == 0 || txtMidterm.Text.ToString().Length == 0 || txtSemifinal.Text.ToString().Length == 0
                  || txtFinals.Text.ToString().Length == 0 || txtAbsences.Text.ToString().Length == 0 || txtWdAve.Text.ToString().Length == 0)
                {
                    txtRemarks.Text = "INC";
                }
                else
                {
                    double rs = double.Parse(txtSum.Text);
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

        private void txtMidterm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAverage.Text = ((float.Parse(txtPrelim.Text) + float.Parse(txtMidterm.Text)) / 2).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txtSemifinal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAverage.Text = ((float.Parse(txtPrelim.Text) + float.Parse(txtMidterm.Text) + float.Parse(txtSemifinal.Text)) / 3).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txtFinals_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAverage.Text = ((float.Parse(txtPrelim.Text) + float.Parse(txtMidterm.Text) + float.Parse(txtSemifinal.Text) + float.Parse(txtFinals.Text)) / 4).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txtAverage_TextChanged(object sender, EventArgs e)
        {

            try
            {
                txt70.Text = (float.Parse(txtAverage.Text) * 0.7).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txt70_TextChanged(object sender, EventArgs e)
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

        private void txtAbsences_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWdAve_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt20.Text = (float.Parse(txtWdAve.Text) * 0.2).ToString("0.00");
            }
            catch
            {
            }
        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {
            if (txtPrelim.Text.ToString().Length == 0 || txtMidterm.Text.ToString().Length == 0 || txtSemifinal.Text.ToString().Length == 0
              || txtFinals.Text.ToString().Length == 0 || txt10.Text.ToString().Length == 0)
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

        private void txt10_TextChanged(object sender, EventArgs e)
        {
            if (txtPrelim.Text.ToString().Length == 0 || txtMidterm.Text.ToString().Length == 0 || txtSemifinal.Text.ToString().Length == 0
             || txtFinals.Text.ToString().Length == 0 || txtWdAve.Text.ToString().Length == 0)
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

        private void txtAbsences_KeyDown(object sender, KeyEventArgs e)
        {
            txt10.Text = "";
            txt10.Text = "";
            txtSum.Text = "";
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbABoard.Checked = false;
            cbANonBoard.Checked = false;

            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;
        }

        private void txtSum_KeyDown(object sender, KeyEventArgs e)
        {
            txtFR.Text = "";
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAbsences.Text.ToString().Length == 0)
            {
                MessageBox.Show("Absences day  is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWdAve.Focus();

                return;
            }

            if (txtWdAve.Text.ToString().Length == 0)
            {
                MessageBox.Show("Quizzes day  is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWdAve.Focus();

                return;
            }
            if (txtRemarks.Text == "INC")
            {
                MessageBox.Show("INC has not been change", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            
            this.Close();

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

        private void txtWdAve_KeyDown(object sender, KeyEventArgs e)
        {
            txt20.Text = "";
            txtSum.Text = "";
            txtFR.Text = "";
            txtRemarks.Text = "";
            cbSBoard.Checked = false;
            cbSNonBoard.Checked = false;

            
        }

        private void txt10_KeyDown(object sender, KeyEventArgs e)
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
    }
}
