using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.AcademicCalendar
{
    public partial class formAcademicCalendar : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public formAcademicCalendar()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from AcademicCalendar;";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            try
            {
                this.ds = this.da.ExecuteQuery(sql);
                this.dgvLibrary.AutoGenerateColumns = false;
                this.dgvLibrary.DataSource = this.ds.Tables[0];
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void AcademicCalendar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
