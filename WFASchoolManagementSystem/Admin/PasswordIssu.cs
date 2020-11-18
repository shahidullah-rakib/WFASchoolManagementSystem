using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Admin
{
    public partial class PasswordIssu : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private string sql { get; set; }

        public PasswordIssu()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from AllUser;";
            this.PopulateGridView(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvAlluser.AutoGenerateColumns = false;
            this.dgvAlluser.DataSource = this.ds.Tables[0];
        }

        private void ClearAll()
        {
            this.txtUserID.Clear();
            this.txtUserID.ReadOnly = false;
            this.txtPassword.Clear();
            this.cmbType.SelectedIndex = -1;
        }

        private void btnAlluser_Click(object sender, EventArgs e)
        {
            string sql = "select * from AllUser;";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            //string sql = "select * from AllUser where type = '" + this.comboBoxSearch.Text + "';";
            //this.PopulateGridView(this.sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"insert into AllUser 
                          values('" + this.txtUserID.Text + "', '" + this.txtPassword.Text + "', '" + this.cmbType.Text + "');";


                int count = this.da.ExecuteUpdateQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Data Added Properly");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }
                string sql2 = "select * from AllUser;";
                this.PopulateGridView(sql2);
                this.ClearAll();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            

        }

        private void PasswordIssu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from AllUser where type like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = this.dgvAlluser.CurrentRow.Cells[0].Value.ToString();


                string sql = @"delete from AllUser where userId = '" + userid + "';";
                int count = this.da.ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(userid + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Data deletion Failed");
                }
                string sql2 = "select * from AllUser;";
                this.PopulateGridView(sql2);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void dgvAlluser_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Text = this.dgvAlluser.CurrentRow.Cells["userId"].Value.ToString();
            this.cmbType.Text = this.dgvAlluser.CurrentRow.Cells["type"].Value.ToString();
            this.txtPassword.Text = this.dgvAlluser.CurrentRow.Cells["password"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"update AllUser
                        set password = '" + this.txtPassword.Text + @"',
                        type = '" + this.cmbType.Text + @"'
                        where userId = '" + this.txtUserID.Text + "';";
                int count = this.da.ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Update Failed");
                }
                string sql2 = "select * from AllUser;";
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
