using FinalProject_Part2_DanielScholtz.DAO;
using FinalProject_Part2_DanielScholtz.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Part2_DanielScholtz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findUser = from user in context.Users
                                   where user.UserID.ToString() == txtUserID.Text &&
                                   user.Password == txtPassword.Text
                                   select user;
                    if (findUser.Any())
                    {
                        var jobtitle = "Program Coordinator";

                        foreach (var user in findUser)
                        {
                            if(user.JobTitle.ToString() == jobtitle)
                            {
                                MessageBox.Show("Welcome Coordinator!");
                                CourseAssignmentForm_Coordinator form2 = new CourseAssignmentForm_Coordinator();
                                form2.FormClosed += (s, args) => this.Close();
                                form2.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Welcome Teacher!");
                                CourseAssignmentForm_Teacher form3 = new CourseAssignmentForm_Teacher();
                                form3.FormClosed += (s, args) => this.Close();
                                form3.Show();
                                this.Hide();
                            }
                        }
                      

                    }
                    else
                    {
                        MessageBox.Show("UserID or password incorrect.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close the App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
