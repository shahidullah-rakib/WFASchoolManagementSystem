using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Student
{
    public partial class Resultinfo : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private string sql { get; set; }

        public Resultinfo()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from Student;";
            this.PopulateGridView(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvResult.AutoGenerateColumns = false;
            this.dgvResult.DataSource = this.ds.Tables[0];
        }

        private void ClearAll()
        {
            this.txtStudentId.Clear();
            this.txtStudentId.ReadOnly = false;
            this.txtResult.Clear();
        }

        private void btnAlluser_Click(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void Resultinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Student where userId like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void dgvResult_DoubleClick(object sender, EventArgs e)
        {
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Text = this.dgvResult.CurrentRow.Cells["userId"].Value.ToString();
            this.txtResult.Text = this.dgvResult.CurrentRow.Cells["result"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"update Student set result = " + this.txtResult.Text + @" where userId = '" + this.txtStudentId.Text + "';";


                int count = this.da.ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Update Failed");
                }
                string sql2 = "select * from Student;";
                this.PopulateGridView(sql2);
                this.ClearAll();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

       

       

        
    }
}
