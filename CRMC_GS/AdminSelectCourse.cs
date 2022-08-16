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
    public partial class AdminSelectCourse : Form
    {
        public AdminSelectCourse()
        {
            InitializeComponent();
        }

        private void AdminSelectCourse_Load(object sender, EventArgs e)
        {
            panelCCS.Visible = false;
            panelcje.Visible = false;
            panelcoc.Visible = false;
            panelcte.Visible = false;
            panelpsy.Visible = false;
        
        }

        private void btnccs_Click(object sender, EventArgs e)
        {
            panelCCS.Visible = true;
            panelcje.Visible = false;
            panelcoc.Visible = false;
            panelcte.Visible = false;
            panelpsy.Visible = false;
          
        }

        private void btncoc_Click(object sender, EventArgs e)
        {
            panelCCS.Visible = false;
            panelcje.Visible = false;
            panelcoc.Visible = true;
            panelcte.Visible = false;
            panelpsy.Visible = false;
          
        }

        private void btncte_Click(object sender, EventArgs e)
        {
            panelCCS.Visible = false;
            panelcje.Visible = false;
            panelcoc.Visible = false;
            panelcte.Visible = true;
            panelpsy.Visible = false;
        }

        private void btncje_Click(object sender, EventArgs e)
        {
            panelCCS.Visible = false;
            panelcje.Visible = true;
            panelcoc.Visible = false;
            panelcte.Visible = false;
            panelpsy.Visible = false;
       
        }

        private void btnpsy_Click(object sender, EventArgs e)
        {
            panelCCS.Visible = false;
            panelcje.Visible = false;
            panelcoc.Visible = false;
            panelcte.Visible = false;
            panelpsy.Visible = true;
        }

        private void btnbsma_Click(object sender, EventArgs e)
        {
            AdminBSMA_Pros user = new AdminBSMA_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbshm_Click(object sender, EventArgs e)
        {
            AdminBSHM_Pros user = new AdminBSHM_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbshmfb_Click(object sender, EventArgs e)
        {
            BSHM_FB_Pros user = new BSHM_FB_Pros();
            user.Show();
            this.Hide();
        }

        private void btntm_Click(object sender, EventArgs e)
        {
            AdminBSTM_Pros user = new AdminBSTM_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbsa_Click(object sender, EventArgs e)
        {

            AdminBSA_Pros user = new AdminBSA_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbm_Click(object sender, EventArgs e)
        {

            AdminBA_Pros user = new AdminBA_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbsefilipino_Click(object sender, EventArgs e)
        {
            AdminBSE_Filipino_Pros user = new AdminBSE_Filipino_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbsescience_Click(object sender, EventArgs e)
        {
            BSE_SCIENCE_Pros user = new BSE_SCIENCE_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbsemath_Click(object sender, EventArgs e)
        {
            AdminBSE_MATH_Pros user = new AdminBSE_MATH_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbseenglish_Click(object sender, EventArgs e)
        {
            BSE_ENGLISH_Pros user = new BSE_ENGLISH_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbsesocialscience_Click(object sender, EventArgs e)
        {
            BSE_SCIENCE_Pros user = new BSE_SCIENCE_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbece_Click(object sender, EventArgs e)
        {
            AdminBECE_Pros user = new AdminBECE_Pros();
            user.Show();
            this.Hide();
        }

        private void btnbscje_Click(object sender, EventArgs e)
        {
            AdminCRIMINOLOGY_Pros user = new AdminCRIMINOLOGY_Pros();
            user.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPSYCHOLOGY_Pros user = new AdminPSYCHOLOGY_Pros();
            user.Show();
            this.Hide();
        }


        private void btnbsit_Click_1(object sender, EventArgs e)
        {
            AdminBSIT_Pros user = new AdminBSIT_Pros();
            user.Show();
            this.Hide();
            this.Hide();
        }

        private void btnbscs_Click(object sender, EventArgs e)
        {
            AdminBSIT_Pros user = new AdminBSIT_Pros();
            user.Show();
            this.Hide();
        }

        private void AdminSelectCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAdminMain user = new frmAdminMain();
            user.Show();
            this.Hide();
        }

        private void panelcoc_Paint(object sender, PaintEventArgs e)
        {

        }

      

       
       
    }
}
