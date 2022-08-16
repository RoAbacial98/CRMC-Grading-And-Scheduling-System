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
    public partial class frmLogin : Form
    {
        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
           Environment.Exit(0);

        }

        public void firstname() {
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring.Trim());
                con.Open();

                string sqlQuery = "SELECT *FROM Teachers WHERE IDNo = " + int.Parse(txtPassword.Text);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblFirstname.Text = (dr["Firstname"].ToString());


                   

                }
                else
                {

                }
                con.Close();
            }catch(Exception ex){
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtusername.Text.ToString().Length == 0)
            {
                MessageBox.Show("Username is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtusername.Focus();
                return;
            }
            if (txtPassword.Text.ToString().Length == 0)
            {
                MessageBox.Show("Password is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }
           
            string user, pass;
            user = txtusername.Text;
            pass = txtPassword.Text;
            if (user == "admin" && pass == "admin")
            {
              
                frmAdminMain main = new frmAdminMain();
                main.Show();
                this.Hide();
            } 
            
            else
            {
                try
                {

                    firstname();
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");
                    string query = "Select *from Teachers where Lastname= '" + txtusername.Text.Trim() + "' and IDNo= '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {

                        string Tlastname = txtusername.Text;
                        string IDNo = txtPassword.Text;
                        string Firstname = lblFirstname.Text;



                        TeacherMain pro = new TeacherMain(Tlastname, IDNo, Firstname);
                        pro.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                    }
                } catch(Exception ex){
                    MessageBox.Show("Incorrect username or password");
                }

                txtPassword.Clear();
                txtusername.Clear();
            }
          

           
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txtusername.Text.ToString().Length == 0)
                {
                    MessageBox.Show("Username is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtusername.Focus();
                    return;
                }
                if (txtPassword.Text.ToString().Length == 0)
                {
                    MessageBox.Show("Password is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                    return;
                }

                string user, pass;
                user = txtusername.Text;
                pass = txtPassword.Text;
                if (user == "admin" && pass == "admin")
                {

                    frmAdminMain main = new frmAdminMain();
                    main.Show();
                    this.Hide();
                }

                else
                {
                    firstname();
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");
                    string query = "Select *from Teachers where Lastname= '" + txtusername.Text.Trim() + "' and IDNo= '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {

                        string Tlastname = txtusername.Text;
                        string IDNo = txtPassword.Text;
                        string Firstname = lblFirstname.Text;



                        TeacherMain pro = new TeacherMain(Tlastname, IDNo, Firstname);
                        pro.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                    }

                    txtPassword.Clear();
                    txtusername.Clear();
                }
          
            }
        }

       

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
        }

      

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            txtPassword.Text = "";
        }

       
        

      

     
      
    }
}
