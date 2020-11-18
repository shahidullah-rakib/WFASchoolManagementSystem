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
    public partial class formStudentInindividualInfo : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public formStudentInindividualInfo()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.DataSource = this.ds.Tables[0];
        }

        private void formStudentInindividualInfo_FormClosed(object sender, FormClosedEventArgs e)
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
                         Student.fullname, 
                         Student.email, 
                         Student.gender, 
                         Student.dateofbirth,
                         Student.nationality,
                         Student.religion,
                         Student.bloodgroup,
                         Student.fathername,
                         Student.mothername,
                         Student.admissiondate,
                         Student.graduationdate,
                         Student.paymentstatus,
                         Student.result,
                         Student.parmanentaddress,
                         Student.presentaddress,
                         Student.contactnumber
                         FROM AllUser
                         INNER JOIN Student ON AllUser.userId=Student.userId where password = '" + this.textBoxPassword.Text + "';";

                //string gdvsql = "select * from AllUser where password = '" + this.textBoxPassword.Text + "';";
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
