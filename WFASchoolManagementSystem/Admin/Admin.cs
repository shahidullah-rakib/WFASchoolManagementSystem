using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Admin;
using WFASchoolManagementSystem.Grid_View;

namespace WFASchoolManagementSystem.Admin
{
    public partial class formAdmin : Form
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        public formAdmin()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void btnAdminLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                formLogin login3 = new formLogin();
                this.Hide();
                login3.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void customizeDesing()
        {
            try
            {
                paneInsert.Visible = false;
                panelUpdate.Visible = false;
                panelDelete.Visible = false;
                panelPassword.Visible = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void hideSubMenu()
        {
            try
            {
                if (paneInsert.Visible == true)
                    paneInsert.Visible = false;
                if (panelUpdate.Visible == true)
                    panelUpdate.Visible = false;
                if (panelDelete.Visible == true)
                    panelDelete.Visible = false;
                if (panelPassword.Visible == true)
                    panelPassword.Visible = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void showSubMenu(Panel subMenu)
        {
            try
            {
                if (subMenu.Visible == false)
                {
                    this.hideSubMenu();
                    subMenu.Visible = true;
                }
                else
                    subMenu.Visible = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void btnInsertInfo_Click(object sender, EventArgs e)
        {
            showSubMenu(paneInsert);
        }

        private void StudentInsert_Click(object sender, EventArgs e)
        {
            FormStudentInfo sinfo = new FormStudentInfo();
            sinfo.Show();
            hideSubMenu();
            
        }

        private void TeacherInsert_Click(object sender, EventArgs e)
        {
            FormTeacherInfo teacherinsert = new FormTeacherInfo();
            teacherinsert.Show();
            hideSubMenu();
            
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUpdate);
        }

        private void btnTeacherUpdate_Click(object sender, EventArgs e)
        {
            FormTeacherInfo teacherinsert = new FormTeacherInfo();
            teacherinsert.Show();
            hideSubMenu();
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            FormStudentInfo sinfo = new FormStudentInfo();
            sinfo.Show();
            hideSubMenu();
        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDelete);
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            FormTeacherInfo teacherinsert = new FormTeacherInfo();
            teacherinsert.Show();
            hideSubMenu();
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            FormStudentInfo sinfo = new FormStudentInfo();
            sinfo.Show();
            hideSubMenu();
        }

        private void bthPassword_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPassword);
        }

        private void bthTeacherPassword_Click(object sender, EventArgs e)
        {
            PasswordIssu pi = new PasswordIssu();
            pi.Show();
            hideSubMenu();
        }

        private void bthStudentPassword_Click(object sender, EventArgs e)
        {
            PasswordIssu pi = new PasswordIssu();
            pi.Show();
            hideSubMenu();
        }

        private void btnStudentGridView_Click(object sender, EventArgs e)
        {
            FormStudentInfo sinfo = new FormStudentInfo();
            sinfo.Show();

        }

        private void formAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bthTeacherGridView_Click(object sender, EventArgs e)
        {
            FormTeacherInfo tinfo = new FormTeacherInfo();
            tinfo.Show();
        }

        private void bthAdminGridView_Click(object sender, EventArgs e)
        {
            FormAdminInfo ainfo = new FormAdminInfo();
            ainfo.Show();

        }

        public formAdmin(string id) : this()
        {
            this.lblWelcome.Text += id;
        }








        





    }
}
