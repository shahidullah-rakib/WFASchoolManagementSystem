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


namespace WFASchoolManagementSystem.Grid_View
{
    public partial class FormAdminInfo : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public FormAdminInfo()
        {
            InitializeComponent();

            this.da = new DataAccess();

            string sql = "select * from Admin;";
            this.PopulateGridView(sql);
        }

        private void bthBackAdminPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdminInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //formAdmin fa = new formAdmin();
            //fa.Show();
            this.Hide();
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = this.ds.Tables[0];
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Admin;";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
