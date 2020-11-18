using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Teachers;
using WFASchoolManagementSystem.Admin;

namespace WFASchoolManagementSystem
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUserId.Text == "")
                {
                    MessageBox.Show("Please Enter User ID");
                }
                else if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Enter Password");
                }
                else
                {
                    string sql = "select type from AllUser where userId = '" + this.textBoxUserId.Text + "' and password = '" + this.textBoxPassword.Text + "';";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);

                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("Login approve for " + this.textBoxUserId.Text);
                        if (ds.Tables[0].Rows[0][0].ToString() == "student")
                        {
                            formStudent s = new formStudent(this.textBoxUserId.Text);
                            this.Hide();
                            s.Show();

                        }
                        else if (ds.Tables[0].Rows[0][0].ToString() == "teacher")
                        {
                            formTeachers t = new formTeachers(this.textBoxUserId.Text);
                            this.Hide();
                            t.Show();



                        }
                        else if (ds.Tables[0].Rows[0][0].ToString() == "admin")
                        {
                            formAdmin a = new formAdmin(this.textBoxUserId.Text);
                            this.Hide();
                            a.Show();

                        }
                        else
                        {
                            MessageBox.Show("not done");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login invlalid");
                    }
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }

        private void buttenExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Contact With Your Administrator");
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
