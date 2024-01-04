using FinalProject_Part2_DanielScholtz.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_Part2_DanielScholtz.GUI
{
    public partial class CourseAssignmentForm_Teacher : Form
    {
        public CourseAssignmentForm_Teacher()
        {
            InitializeComponent();
        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findTeacher = from t in context.Teachers
                                      where t.TeacherID.ToString() == txtTeacherID.Text
                                      select t;
                    if (findTeacher.Any())
                    {
                        foreach (var teacher in findTeacher)
                        {
                            lblTeacherID.Text = teacher.TeacherID.ToString();
                            lblTeacherFName.Text = teacher.FirstName;
                            lblTeacherLName.Text = teacher.LastName;
                            lblTeacherEmail.Text = teacher.Email;
                        }
                        txtTeacherID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Teacher id don't exist.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearchCourse_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findCourse = from c in context.Courses
                                     where c.CourseNumber.ToString() == txtSearchCourse.Text
                                     select c;
                    if (findCourse.Any())
                    {
                        foreach (var course in findCourse)
                        {
                            lblCourseNumber.Text = course.CourseNumber.ToString();
                            lblCourseTitle.Text = course.CourseTitle;
                            lblCourseDuration.Text = course.Duration.ToString();
                        }
                        txtSearchCourse.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Course Number don't exist.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadCourses()
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findAllCourses = from c in context.Courses
                                         select c;

                    listView_Courses.Items.Clear();

                    foreach (var course in findAllCourses)
                    {
                        ListViewItem item = new ListViewItem(course.CourseNumber.ToString());
                        item.SubItems.Add(course.CourseTitle);
                        item.SubItems.Add(course.Duration.ToString());

                        listView_Courses.Items.Add(item);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void buttonListAllCourses_Click(object sender, EventArgs e)
        {
            loadCourses();
        }

        private void btnSeachTeachersCourses_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findTC = from tc in context.TeacherCourses
                                 where tc.TeacherCourseID.ToString() == txtSearch_TC.Text
                                 select tc;
                    if (findTC.Any())
                    {
                        foreach (var tc in findTC)
                        {
                            lblTC_ID.Text = tc.TeacherCourseID.ToString();
                            lblTeacherID_TC.Text = tc.TeacherID.ToString();
                            lblCourseNum_TC.Text = tc.CourseNumber.ToString();
                        }
                        txtSearch_TC.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Enrollment id don't exist.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTC()
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findAllTC = from tc in context.TeacherCourses
                                    select tc;

                    listViewTC.Items.Clear();

                    foreach (var tc in findAllTC)
                    {
                        ListViewItem item = new ListViewItem(tc.TeacherCourseID.ToString());
                        item.SubItems.Add(tc.TeacherID.ToString());
                        item.SubItems.Add(tc.CourseNumber.ToString());

                        listViewTC.Items.Add(item);
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            LoadTC();
        }
    }
}
