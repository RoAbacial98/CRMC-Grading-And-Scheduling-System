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
    public partial class frmStudents : Form
    {
        private string status = "0";

        private string connectionstring = @"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=GS;Integrated Security=true;");

        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            FillDepartment();
        }

        public void FillDepartment()
        {


            SqlCommand cmd = new SqlCommand("Select  Department From Department", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            cbDepartment.Items.Clear();
            cbDepartment.Items.Add("---SELECT---");
            foreach (DataRow Row in table.Rows)
            {
                cbDepartment.Items.Add(Row["Department"].ToString());
            }

        }
        private void DisplayRecords()
        {
            SqlCommand cmd = new SqlCommand("Select *From Students", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            

            datagridStudent.AllowUserToAddRows = false;
            datagridStudent.DataSource = table;

            datagridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Read Only and Enable

            txtStudentID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            cbDepartment.Text = null;
            txtStudentIDNo.Text = "";
            cbCourse.Text = null;
            cbGender.Text = null;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtContacts.Text = "";
            txtSearch.Text = "";



            txtStudentID.ReadOnly = true;
            txtFirstname.ReadOnly = true;
            txtLastname.ReadOnly = true;
            cbDepartment.Enabled = false;
            txtStudentIDNo.ReadOnly = true;
            cbCourse.Enabled = false;
            cbGender.Enabled = false;
            txtAddress.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContacts.ReadOnly = true;
            


            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
        

        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            this.status = "0";
            //Read Only and Enable

            txtStudentID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            cbDepartment.Text = null;
            txtStudentIDNo.Text = "";
            cbCourse.Text = null;
            cbGender.Text = null;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtContacts.Text = "";
            txtSearch.Text = "";



            txtStudentID.ReadOnly = false;
            txtFirstname.ReadOnly = false;
            txtLastname.ReadOnly = false;
            cbDepartment.Enabled = true;
            txtStudentIDNo.ReadOnly = false;
            cbCourse.Enabled = true;
            cbGender.Enabled = true;
            txtAddress.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtContacts.ReadOnly = false;



            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        

            con.Open();
            SqlCommand cmd = new SqlCommand("Scode", con);
            cmd.CommandType = CommandType.StoredProcedure;
            object obj = cmd.ExecuteScalar();
            this.txtStudentID.Text = obj.ToString();
            con.Close();

        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            this.status = "1";
            //Read Only and Enable

            txtSearch.Text = "";



            txtStudentID.ReadOnly = false;
            txtFirstname.ReadOnly = false;
            txtLastname.ReadOnly = false;
            cbDepartment.Enabled = true;
            txtStudentIDNo.ReadOnly = false;
            cbCourse.Enabled = true;
            cbGender.Enabled = true;
            txtAddress.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtContacts.ReadOnly = false;



            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
          

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (this.status.Trim().Equals("0"))
            {


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
                if (txtStudentIDNo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("ID No. is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStudentIDNo.Focus();
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

                if (txtAddress.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Address is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddress.Focus();
                    return;
                }
                if (cbDepartment.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Department is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbDepartment.Focus();
                    return;
                }

                //duplicate
                SqlCommand cmd = new SqlCommand("Select * from Students where Firstname = '" + txtFirstname.Text + "' AND Lastname = '" + txtLastname.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Student already Existed!1");
                    ds.Clear();
                    DisplayRecords();
                }
                else
                {
                    if (MessageBox.Show("Do you want to Save Students info?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        try
                        {


                            SqlConnection connection = new SqlConnection(connectionstring.Trim());

                            string insertStatement = "Insert into Students(StudentId,Firstname,Lastname,Department,StudentIDNo,Course,Gender,Address,Email,Contacts) VALUES (@StudentId,@Firstname,@Lastname,@Department,@StudentIDNo,@Course,@Gender,@Address,@Email,@Contacts)";

                            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                            insertCommand.Parameters.Add("@StudentId", SqlDbType.VarChar).Value = txtStudentID.Text;
                            insertCommand.Parameters.Add("@Firstname", SqlDbType.VarChar).Value = txtFirstname.Text;
                            insertCommand.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = txtLastname.Text;
                            insertCommand.Parameters.Add("@Department", SqlDbType.VarChar).Value = cbDepartment.Text;
                            insertCommand.Parameters.Add("@StudentIDNo", SqlDbType.VarChar).Value = txtStudentIDNo.Text;
                            insertCommand.Parameters.Add("@Course", SqlDbType.VarChar).Value = cbCourse.Text;
                            insertCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cbGender.Text;
                            insertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text;
                            insertCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                            insertCommand.Parameters.Add("@Contacts", SqlDbType.VarChar).Value = txtContacts.Text;


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
                if (txtStudentIDNo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("ID No. is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStudentIDNo.Focus();
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

                if (txtAddress.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Address is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddress.Focus();
                    return;
                }
                if (cbDepartment.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Department is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbDepartment.Focus();
                    return;
                }

                
                if (MessageBox.Show("Do you want to update Students info?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {

                        SqlConnection connection = new SqlConnection(connectionstring.Trim());

                        string insertStatement = "UPDATE Students SET Firstname=@Firstname,Lastname=@Lastname,Department=@Department,StudentIDNo=@StudentIDNo,Course=@Course,Gender=@Gender,Address=@Address,Email=@Email,Contacts=@Contacts,StudentId=@StudentId WHERE StudentId=@StudentId";


                        SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                        insertCommand.Parameters.Add("@StudentId", SqlDbType.VarChar).Value = txtStudentID.Text;
                        insertCommand.Parameters.Add("@Firstname", SqlDbType.VarChar).Value = txtFirstname.Text;
                        insertCommand.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = txtLastname.Text;
                        insertCommand.Parameters.Add("@Department", SqlDbType.VarChar).Value = cbDepartment.Text;
                        insertCommand.Parameters.Add("@StudentIDNo", SqlDbType.VarChar).Value = txtStudentIDNo.Text;
                        insertCommand.Parameters.Add("@Course", SqlDbType.VarChar).Value = cbCourse.Text;
                        insertCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cbGender.Text;
                        insertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text;
                        insertCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                        insertCommand.Parameters.Add("@Contacts", SqlDbType.VarChar).Value = txtContacts.Text;

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

       

        private void datagridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridStudent.RowHeadersVisible = true;

            txtStudentID.Text = datagridStudent.CurrentRow.Cells[0].Value.ToString();
            txtFirstname.Text = datagridStudent.CurrentRow.Cells[1].Value.ToString();
            txtLastname.Text = datagridStudent.CurrentRow.Cells[2].Value.ToString();
            cbDepartment.Text = datagridStudent.CurrentRow.Cells[3].Value.ToString();
            txtStudentIDNo.Text = datagridStudent.CurrentRow.Cells[4].Value.ToString();
            cbCourse.Text = datagridStudent.CurrentRow.Cells[5].Value.ToString();
            cbGender.Text = datagridStudent.CurrentRow.Cells[6].Value.ToString();
            txtAddress.Text = datagridStudent.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = datagridStudent.CurrentRow.Cells[8].Value.ToString();
            txtContacts.Text = datagridStudent.CurrentRow.Cells[9].Value.ToString();

            //Read Only and Enable

          
            txtSearch.Text = "";



            txtStudentID.ReadOnly = true;
            txtFirstname.ReadOnly = true;
            txtLastname.ReadOnly = true;
            cbDepartment.Enabled = false;
            txtStudentIDNo.ReadOnly = true;
            cbCourse.Enabled = false;
            cbGender.Enabled = false;
            txtAddress.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContacts.ReadOnly = true;



            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
          
           
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Students where FirstName like '" + txtSearch.Text + "%' OR Lastname like '" + txtSearch.Text + "%' OR Department like '" + txtSearch.Text + "%' OR Course like '" + txtSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            datagridStudent.DataSource = dt;
            con.Close();
        }

        private void txtStudentIDNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtContacts_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbDepartment_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select  Course From Course where Department = '" + cbDepartment.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            cbCourse.Items.Clear();
            foreach (DataRow ab in table.Rows)
            {
                cbCourse.Items.Add(ab["Course"].ToString());
            }
        }

        private void txtContacts_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void frmStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAdminMain user = new frmAdminMain();
            user.Show();
            this.Hide();
        }

        private void datagridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
