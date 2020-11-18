using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Library;
using WFASchoolManagementSystem.AcademicCalendar;
using WFASchoolManagementSystem.Courses;
using WFASchoolManagementSystem.Information;

namespace WFASchoolManagementSystem
{
    public partial class formStudent : Form
    {
        public formStudent()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void btnStudentLogOut_Click(object sender, EventArgs e)
        {
            formLogin login1 = new formLogin();
            this.Hide();
            login1.Show();
        }

        private void customizeDesing()
        {
            panelAcademics.Visible = false;
            panelLibrary.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelAcademics.Visible == true)
                panelAcademics.Visible = false;
            if (panelLibrary.Visible == true)
                panelLibrary.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                this.hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnAcademics_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAcademics);
        }

        private void bthCourses_Click(object sender, EventArgs e)
        {
            formCourses c = new formCourses();
            c.Show();
            hideSubMenu();
        }

        private void bthResult_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnFinancials_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            formAcademicCalendar ac = new formAcademicCalendar();
            ac.Show();
            hideSubMenu();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLibrary);
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            formLibrary l1 = new formLibrary();
            l1.Show();
            hideSubMenu();
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            formLibrary l1 = new formLibrary();
            l1.Show();
            hideSubMenu();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            formStudentInindividualInfo si = new formStudentInindividualInfo();
            si.Show();
        }

        private void formStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public formStudent(string id) : this()
        {
            this.lblWelcome.Text += id;
        }



    }
}
