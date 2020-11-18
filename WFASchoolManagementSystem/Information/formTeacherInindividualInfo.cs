using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Information
{
    public partial class formTeacherInindividualInfo : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public formTeacherInindividualInfo()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvTeacher.AutoGenerateColumns = false;
            this.dgvTeacher.DataSource = this.ds.Tables[0];
        }

        private void formTeacherInindividualInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"SELECT AllUser.userId, 
                         Teacher.fullname, 
                         Teacher.email, 
                         Teacher.gender, 
                         Teacher.dateofbirth,
                         Teacher.nationality,
                         Teacher.religion,
                         Teacher.bloodgroup,
                         Teacher.fathername,
                         Teacher.mothername,
                         Teacher.joiningdate,
                         Teacher.leftdate,
                         Teacher.salary,
                         Teacher.qualification,
                         Teacher.subject,
                         Teacher.parmanentaddress,
                         Teacher.presentaddress,
                         Teacher.contactnumber
                         FROM AllUser
                         INNER JOIN Teacher ON AllUser.userId=Teacher.userId where password = '" + this.textBoxPassword.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {

                    this.PopulateGridView(sql);

                }
                else
                {
                    MessageBox.Show("password invalied");
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }
    }
}
