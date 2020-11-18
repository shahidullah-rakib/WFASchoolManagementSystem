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
    public partial class FormStudentInfo : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public FormStudentInfo()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from Student;";
            this.PopulateGridView(sql);
            this.GenerateStudentID();
        }

        private void bthBackAdminPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStudentInformation_FormClosed(object sender, FormClosedEventArgs e)
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
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.DataSource = this.ds.Tables[0];
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
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

        

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Student where fullname like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
              
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"insert into Student 
                           values ('" + this.txtStudentId.Text + "','" + this.txtFullName.Text + "', '" + this.txtEmail.Text + "', '" + this.cmbGender.Text + "', '" + this.dtpdob.Text + "', '" + this.txtNationality.Text + "', '" + this.txtReligion.Text + "', '" + this.txtBloodGroup.Text + "', '" + this.txtFatherName.Text + "', '" + this.txtMotherName.Text + "', '" + this.dtpAdmissionDate.Text + "', '" + this.dtpGraduationDate.Text + "', '" + this.txtPaymentStatus.Text + "', " + this.txtResult.Text + ", '" + this.txtPresentAddress.Text + "', '" + this.txtParmanentAddress.Text + "', " + this.txtContactNumber.Text + ");";

                int count = this.da.ExecuteUpdateQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Data Added Properly. Please Add New Password");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string student_id = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();
                string fullname = this.dgvStudent.CurrentRow.Cells["fullname"].Value.ToString();

                string sql = @"delete from Student where userId = '" + student_id + "';";
                int count = this.da.ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(fullname + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Data deletion Failed");
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

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtStudentId.ReadOnly = true;
                this.txtStudentId.Text = this.dgvStudent.CurrentRow.Cells["userId"].Value.ToString();
                this.txtFullName.Text = this.dgvStudent.CurrentRow.Cells["fullname"].Value.ToString();
                this.txtEmail.Text = this.dgvStudent.CurrentRow.Cells["email"].Value.ToString();
                this.cmbGender.Text = this.dgvStudent.CurrentRow.Cells["gender"].Value.ToString();
                this.dtpdob.Text = this.dgvStudent.CurrentRow.Cells["dateofbirth"].Value.ToString();
                this.txtNationality.Text = this.dgvStudent.CurrentRow.Cells["nationality"].Value.ToString();
                this.txtReligion.Text = this.dgvStudent.CurrentRow.Cells["religion"].Value.ToString();
                this.txtBloodGroup.Text = this.dgvStudent.CurrentRow.Cells["bloodgroup"].Value.ToString();
                this.txtFatherName.Text = this.dgvStudent.CurrentRow.Cells["fathername"].Value.ToString();
                this.txtMotherName.Text = this.dgvStudent.CurrentRow.Cells["mothername"].Value.ToString();
                this.dtpAdmissionDate.Text = this.dgvStudent.CurrentRow.Cells["admissiondate"].Value.ToString();
                this.dtpGraduationDate.Text = this.dgvStudent.CurrentRow.Cells["graduationdate"].Value.ToString();
                this.txtPaymentStatus.Text = this.dgvStudent.CurrentRow.Cells["paymentstatus"].Value.ToString();
                this.txtResult.Text = this.dgvStudent.CurrentRow.Cells["result"].Value.ToString();
                this.txtPresentAddress.Text = this.dgvStudent.CurrentRow.Cells["presentaddress"].Value.ToString();
                this.txtParmanentAddress.Text = this.dgvStudent.CurrentRow.Cells["parmanentaddress"].Value.ToString();
                this.txtContactNumber.Text = this.dgvStudent.CurrentRow.Cells["contactnumber"].Value.ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"update Student 
                            set fullname = '" + this.txtFullName.Text + @"',
                            email = '" + this.txtEmail.Text + @"',
                            gender = '" + this.cmbGender.Text + @"',
                            dateofbirth = '" + this.dtpdob.Text + @"' ,
                            nationality = '" + this.txtNationality.Text + @"' ,
                            religion = '" + this.txtReligion.Text + @"' ,
                            bloodgroup = '" + this.txtBloodGroup.Text + @"' ,
                            fathername = '" + this.txtFatherName.Text + @"' ,
                            mothername =  '" + this.txtMotherName.Text + @"' ,
                            admissiondate = '" + this.dtpAdmissionDate.Text + @"' ,
                            graduationdate = '" + this.dtpGraduationDate.Text + @"' ,
                            paymentstatus = '" + this.txtPaymentStatus.Text + @"' ,
                            result = " + this.txtResult.Text + @" ,
                            presentaddress = '" + this.txtPresentAddress.Text + @"' ,
                            parmanentaddress = '" + this.txtParmanentAddress.Text + @"' ,
                            contactnumber = " + this.txtContactNumber.Text + @"
                            where userId = '" + this.txtStudentId.Text + "';";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll(); 
        }
        private void ClearAll()
        {
            try
            {
                this.txtStudentId.Clear();
                //this.txtStudentId.ReadOnly = false;
                this.txtFullName.Clear();
                this.txtEmail.Clear();
                this.cmbGender.SelectedIndex = -1;
                this.dtpdob.Text = "";
                this.txtNationality.Clear();
                this.txtReligion.Clear();
                this.txtBloodGroup.Clear();
                this.txtFatherName.Clear();
                this.txtMotherName.Clear();
                this.dtpAdmissionDate.Text = "";
                this.dtpGraduationDate.Text = "";
                this.txtPaymentStatus.Clear();
                this.txtResult.Clear();
                this.txtPresentAddress.Clear();
                this.txtParmanentAddress.Clear();
                this.txtContactNumber.Clear();
                this.GenerateStudentID();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void GenerateStudentID()
        {
            try
            {
                string sql = "select * from Student order by userId desc;";
                DataTable dt = this.da.ExecuteQueryTable(sql);
                string id = dt.Rows[0]["userId"].ToString();
                string[] str = id.Split('S');
                int number = Convert.ToInt32(str[1]);
                string newId = "S" + (++number).ToString("d4");

                this.txtStudentId.Text = newId;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

    }
}
