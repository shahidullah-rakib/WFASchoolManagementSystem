using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Courses
{
    public partial class formCourses : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public formCourses()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from Courses;";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvLibrary.AutoGenerateColumns = false;
            this.dgvLibrary.DataSource = this.ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void formCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
