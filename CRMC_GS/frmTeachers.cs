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
    public partial class frmTeachers : Form
    {
        private string status = "0";

        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public frmTeachers()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

      

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.status.Trim().Equals("0"))
            {

                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("pictureBox is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    pictureBox1.Focus();
                    return;
                }



                if (txtFirstname.Text.ToString().Length == 0)
                {
                    MessageBox.Show("Firstname is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFirstname.Focus();
                    return;
                }

                if (txtLastname.Text.ToString().Length == 0)
                {
                    MessageBox.Show("Lastname is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLastname.Focus();
                    return;
                }
                if (cbDepartment.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Department is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbDepartment.Focus();
                    return;
                }
                if (txtIDNo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("ID No. is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIDNo.Focus();
                    return;
                }
                if (cbGender.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Gender is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbGender.Focus();
                    return;
                }
                if (txtEmail.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Email is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                    return;
                }
                if (txtContacts.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Contacts is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContacts.Focus();
                    return;
                }
                if (dtpBirthday.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Birthday is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpBirthday.Focus();
                    return;
                }
                if (txtAddress.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Address is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddress.Focus();
                    return;
                }
                  

                //start of duplicate
                SqlCommand cmd = new SqlCommand("Select * from Teachers where Firstname = '" + txtFirstname.Text + "' AND Lastname = '" + txtLastname.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Teacher already Existed!1");
                    ds.Clear();
                    DisplayRecords();
                }
                else
                {


                    if (MessageBox.Show("Do you want to Save Teacher info?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        try
                        {
                            MemoryStream ms = new MemoryStream();
                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            SqlConnection connection = new SqlConnection(connectionstring.Trim());

                            string insertStatement = "Insert into Teachers(ID,Firstname,Lastname,Department,IDNo,Gender,Address,Email,Contacts,Birthday,Image) VALUES (@ID,@Firstname,@Lastname,@Department,@IDNo,@Gender,@Address,@Email,@Contacts,@Birthday,@img)";

                            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                            insertCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = txtID.Text;
                            insertCommand.Parameters.Add("@Firstname", SqlDbType.VarChar).Value = txtFirstname.Text;
                            insertCommand.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = txtLastname.Text;
                            insertCommand.Parameters.Add("@Department", SqlDbType.VarChar).Value = cbDepartment.Text;
                            insertCommand.Parameters.Add("@IDNo", SqlDbType.VarChar).Value = txtIDNo.Text;
                            insertCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cbGender.Text;
                            insertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text;
                            insertCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                            insertCommand.Parameters.Add("@Contacts", SqlDbType.VarChar).Value = txtContacts.Text;
                            insertCommand.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = dtpBirthday.Text;
                            insertCommand.Parameters.Add("@img", SqlDbType.Image).Value = img;

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
                                DisplayRecords();
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

            else
            {

                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("pictureBox is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    pictureBox1.Focus();
                    return;
                }



                if (txtFirstname.Text.ToString().Length == 0)
                {
                    MessageBox.Show("Firstname is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFirstname.Focus();
                    return;
                }

                if (txtLastname.Text.ToString().Length == 0)
                {
                    MessageBox.Show("Lastname is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLastname.Focus();
                    return;
                }
                if (cbDepartment.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Department is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbDepartment.Focus();
                    return;
                }
                if (txtIDNo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("ID No. is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIDNo.Focus();
                    return;
                }
                if (cbGender.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Gender is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbGender.Focus();
                    return;
                }
                if (txtEmail.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Gender is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbGender.Focus();
                    return;
                }
                if (txtContacts.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Contacts is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContacts.Focus();
                    return;
                }
                if (dtpBirthday.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Birthday is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpBirthday.Focus();
                    return;
                }
                if (txtAddress.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Address is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddress.Focus();
                    return;
                }

                if (MessageBox.Show("Do you want to update Teacher info?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] img = ms.ToArray();

                        SqlConnection connection = new SqlConnection(connectionstring.Trim());

                        string insertStatement = "UPDATE Teachers SET Firstname=@Firstname,Lastname=@Lastname,Department=@Department,IDNo=@IDNo,Gender=@Gender,Address=@Address,Email=@Email,Contacts=@Contacts,Birthday=@Birthday,Image=@img,ID=@ID WHERE ID=@ID";


                        SqlCommand insertCommand = new SqlCommand(insertStatement, connection);


                        insertCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = txtID.Text;
                        insertCommand.Parameters.Add("@Firstname", SqlDbType.VarChar).Value = txtFirstname.Text;
                        insertCommand.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = txtLastname.Text;
                        insertCommand.Parameters.Add("@Department", SqlDbType.VarChar).Value = cbDepartment.Text;
                        insertCommand.Parameters.Add("@IDNo", SqlDbType.VarChar).Value = txtIDNo.Text;
                        insertCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cbGender.Text;
                        insertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text;
                        insertCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                        insertCommand.Parameters.Add("@Contacts", SqlDbType.VarChar).Value = txtContacts.Text;
                        insertCommand.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = dtpBirthday.Text;
                        insertCommand.Parameters.Add("@img", SqlDbType.Image).Value = img;

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
                            DisplayRecords();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.status = "0";
            //Read Only and Enable
            this.dtpBirthday.Value = DateTime.Now;

            txtID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            cbDepartment.Text = null;
            txtIDNo.Text = "";
            cbGender.Text = null;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtContacts.Text = "";
            dtpBirthday.Text = "";
            txtSearch.Text = "";
            pictureBox1.Image = null;


            txtID.ReadOnly = false;
            txtFirstname.ReadOnly = false;
            txtLastname.ReadOnly = false;
            cbDepartment.Enabled = true;
            txtEmail.ReadOnly = false;
            txtIDNo.ReadOnly = false;
            cbGender.Enabled = true;
            txtAddress.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtContacts.ReadOnly = false;
            dtpBirthday.Enabled = true;
            btnImage.Enabled = true;


            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
          
            con.Open();
            SqlCommand cmd = new SqlCommand("TScode", con);
            cmd.CommandType = CommandType.StoredProcedure;
            object obj = cmd.ExecuteScalar();
            this.txtID.Text = obj.ToString();
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.status = "1";
            //Read Only and Enable
            this.dtpBirthday.Value = DateTime.Now;

            txtSearch.Text = "";


            txtID.ReadOnly = false;
            txtFirstname.ReadOnly = false;
            txtLastname.ReadOnly = false;
            cbDepartment.Enabled = true;
            txtEmail.ReadOnly = false;
            txtIDNo.ReadOnly = false;
            cbGender.Enabled = true;
            txtAddress.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtContacts.ReadOnly = false;
            dtpBirthday.Enabled = true;
            btnImage.Enabled = true;


            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
          


        }

      

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void DisplayRecords()
        {
            SqlCommand cmd = new SqlCommand("Select *From Teachers", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            datagridTeachers.AllowUserToAddRows = false;
            datagridTeachers.DataSource = table;

            datagridTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datagridTeachers.Columns[10].Visible = false;

            //Read Only and Enable
            this.dtpBirthday.Value = DateTime.Now;

            txtID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            cbDepartment.Text = null;
            txtIDNo.Text = "";
            cbGender.Text = null;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtContacts.Text = "";
            dtpBirthday.Text = "";
            dtpBirthday.Text = "";
            txtSearch.Text = "";
            pictureBox1.Image = null;


            txtID.ReadOnly = true;
            txtFirstname.ReadOnly = true;
            txtLastname.ReadOnly = true;
            cbDepartment.Enabled = false;
            txtEmail.ReadOnly = true;
            txtIDNo.ReadOnly = true;
            cbGender.Enabled = false;
            txtAddress.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContacts.ReadOnly = true;
            dtpBirthday.Enabled = false;
            btnImage.Enabled = false;


            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
          

   

        }

        private void datagridTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridTeachers.RowHeadersVisible = true;

            txtID.Text = datagridTeachers.CurrentRow.Cells[0].Value.ToString();
            txtFirstname.Text = datagridTeachers.CurrentRow.Cells[1].Value.ToString();
            txtLastname.Text = datagridTeachers.CurrentRow.Cells[2].Value.ToString();
            cbDepartment.Text = datagridTeachers.CurrentRow.Cells[3].Value.ToString();
            txtIDNo.Text = datagridTeachers.CurrentRow.Cells[4].Value.ToString();
            cbGender.Text = datagridTeachers.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = datagridTeachers.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = datagridTeachers.CurrentRow.Cells[7].Value.ToString();
            txtContacts.Text = datagridTeachers.CurrentRow.Cells[8].Value.ToString();
            dtpBirthday.Text = datagridTeachers.CurrentRow.Cells[9].Value.ToString();

            MemoryStream ms = new MemoryStream((byte[])datagridTeachers.CurrentRow.Cells[10].Value);
            pictureBox1.Image = Image.FromStream(ms);

            //Read Only and Enable
            this.dtpBirthday.Value = DateTime.Now;

           


            txtID.ReadOnly = true;
            txtFirstname.ReadOnly = true;
            txtLastname.ReadOnly = true;
            cbDepartment.Enabled = false;
            txtEmail.ReadOnly = true;
            txtIDNo.ReadOnly = true;
            cbGender.Enabled = false;
            txtAddress.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContacts.ReadOnly = true;
            dtpBirthday.Enabled = false;
            btnImage.Enabled = false;


            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
          

        }

       

        

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Teachers where FirstName like '" + txtSearch.Text + "%' OR Lastname like '" + txtSearch.Text + "%' OR IDNo like '" + txtSearch.Text + "%' OR Department like '" + txtSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            datagridTeachers.DataSource = dt;
            con.Close();
        }

        private void txtIDNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtContacts_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
        private void frmTeachers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAdminMain user = new frmAdminMain();
            user.Show();
            this.Hide();
        }

      
    }
}
