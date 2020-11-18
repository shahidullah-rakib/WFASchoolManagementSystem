using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Student;
using WFASchoolManagementSystem.Library;
using WFASchoolManagementSystem.Information;

namespace WFASchoolManagementSystem.Teachers
{
    public partial class formTeachers : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public formTeachers()
        {
            InitializeComponent();
            customizeDesing();
            this.da = new DataAccess();

            string sql = "select * from Student;";
            this.PopulateGridView(sql);
        }

        private void btnTeacherLogOut_Click(object sender, EventArgs e)
        {
            formLogin login2 = new formLogin();
            this.Hide();
            login2.Show();
        }

        private void btnStudentLogOut_Click(object sender, EventArgs e)
        {
            formLogin login1 = new formLogin();
            this.Hide();
            login1.Show();
        }

        private void customizeDesing()
        {
            panelStudentResult.Visible = false;
            panelLibrary.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelStudentResult.Visible == true)
                panelStudentResult.Visible = false;
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

        private void btnStudentResult_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentResult);
        }

        private void bthShowAllResult_Click(object sender, EventArgs e)
        {
            Resultinfo ri = new Resultinfo();
            ri.Show();
            hideSubMenu();
        }

        private void bthInsertResult_Click(object sender, EventArgs e)
        {
            Resultinfo ri = new Resultinfo();
            ri.Show();
            hideSubMenu();
        }

        private void btnUpdateResult_Click(object sender, EventArgs e)
        {
            Resultinfo ri = new Resultinfo();
            ri.Show();
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

        private void formTeachers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnStudentGridView_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Student;";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
            
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = this.ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql = "select * from Student where fullname = '" + this.txtSearch.Text + "';";
                string sql = "select * from Student where fullname like '" + this.txtSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            formTeacherInindividualInfo ti = new formTeacherInindividualInfo();
            ti.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        public formTeachers(string id) : this()
        {
            this.lblWelcome.Text += id;
        }




    }
}
