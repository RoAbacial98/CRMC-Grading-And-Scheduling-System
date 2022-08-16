using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRMC_GS
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            frmTeachers user = new frmTeachers();
            user.Show();
            this.Hide();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {

            frmStudents user = new frmStudents();
            user.Show();
            this.Hide();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            AdminSelectCourse user = new AdminSelectCourse();
            user.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            AdminScheduleView user = new AdminScheduleView();
            user.Show();
            this.Hide();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPrintPros user = new AdminPrintPros();
            user.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDeleteFailed user = new AdminDeleteFailed();
            user.Show();
            this.Hide();
        }

        private void frmAdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin user = new frmLogin();
            user.Show();
            this.Hide();
        }

        private void btnSched_Click(object sender, EventArgs e)
        {
          
            AdminTeacherShedConfirm user = new AdminTeacherShedConfirm();
            user.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminTeacherShedConfirm user = new AdminTeacherShedConfirm();
            user.Show();
            this.Hide();
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {

        }

       
    }
}
