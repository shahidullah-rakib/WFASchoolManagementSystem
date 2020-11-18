using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Library
{
    public partial class formLibrary : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public formLibrary()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from Library;";
            this.PopulateGridView(sql);
        }

        private void Library_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvLibrary.AutoGenerateColumns = false;
            this.dgvLibrary.DataSource = this.ds.Tables[0];
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Library;";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Library where bookname like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql); 
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
             
        }
    }
}
