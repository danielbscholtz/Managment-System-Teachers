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

namespace FinalProject_Part2_DanielScholtz.GUI
{
    public partial class CourseAssignmentForm_Coordinator : Form
    {
        //================================================ COURSES ===========================================================
        public CourseAssignmentForm_Coordinator()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void CourseAssignmentForm_Load(object sender, EventArgs e)
        {
       

        }

        private void loadCourses()
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findAllCourses = from c in context.Courses
                                         select c;

                    listView_TC.Items.Clear();

                    foreach (var course in findAllCourses)
                    {
                        ListViewItem item = new ListViewItem(course.CourseNumber.ToString());
                        item.SubItems.Add(course.CourseTitle);
                        item.SubItems.Add(course.Duration.ToString());

                        listView_TC.Items.Add(item);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public bool existingCourse()
        {
            using (var context = new TeacherCourseDBEntities())
            {
                var findCourse = from course in context.Courses
                                  where course.CourseNumber.ToString() == txtCourseNumber.Text
                                  select course;
                if (findCourse.Any())
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }
        //============================== Buttons of Course Part ===================================
        private void buttonListAllCourses_Click(object sender, EventArgs e)
        {
            loadCourses();
        }

        private void buttonExitCourse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close the App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (!existingCourse())
                {
                    if (!string.IsNullOrEmpty(txtCourseNumber.Text) && !string.IsNullOrEmpty(txtCourseTitle.Text) && !string.IsNullOrEmpty(txtCourseDuration.Text))
                    {
                        using (var context = new TeacherCourseDBEntities())
                        {
                            var newCourse = new Cours
                            {
                                CourseNumber = Convert.ToInt32(txtCourseNumber.Text),
                                CourseTitle = txtCourseTitle.Text,
                                Duration = Convert.ToInt32(txtCourseDuration.Text)
                            };
                            context.Courses.Add(newCourse);
                            context.SaveChanges();
                            txtCourseNumber.Text = "";
                            txtCourseTitle.Text = "";
                            txtCourseDuration.Text = "";
                            listView_TC.Items.Clear();
                            MessageBox.Show("New Course Add with Success!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill all that is necessary.");
                    }
                }
                else
                {
                    MessageBox.Show("Course with the same number already exists. Cannot add duplicate course.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when try adding a new course: " + ex.Message);
            }
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var existingCourse = context.Courses.SingleOrDefault(c => c.CourseNumber.ToString() == txtCourseNumber.Text);

                    if (existingCourse != null)
                    {

                        existingCourse.CourseTitle = txtCourseTitle.Text;
                        existingCourse.Duration = Convert.ToInt32(txtCourseDuration.Text);

                        context.SaveChanges();
                        txtCourseNumber.Text = "";
                        txtCourseTitle.Text = "";
                        txtCourseDuration.Text = "";
                        listView_TC.Items.Clear();
                        MessageBox.Show("Course updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Course not found. Unable to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when trying to update course: " + ex.Message);
            }
        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var courseToDelete = context.Courses.SingleOrDefault(c => c.CourseNumber.ToString() == txtCourseNumber.Text);

                    if (courseToDelete != null)
                    {
                        context.Courses.Remove(courseToDelete);
                        context.SaveChanges();
                        txtCourseNumber.Text = "";
                        txtCourseTitle.Text = "";
                        txtCourseDuration.Text = "";
                        listView_TC.Items.Clear();
                        MessageBox.Show("Course deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Course not found. Unable to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when trying to delete course: " + ex.Message);
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
                        MessageBox.Show("Project Number don't exist.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //=================================================== TEACHER =========================================================

        private void LoadATeachers()
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findAllTeachers = from t in context.Teachers
                                         select t;

                    listViewTeachers.Items.Clear();

                    foreach (var teacher in findAllTeachers)
                    {
                        ListViewItem item = new ListViewItem(teacher.TeacherID.ToString());
                        item.SubItems.Add(teacher.FirstName);
                        item.SubItems.Add(teacher.LastName);
                        item.SubItems.Add(teacher.Email);

                        listViewTeachers.Items.Add(item);
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public bool existingTeacher()
        {
            using (var context = new TeacherCourseDBEntities())
            {
                var findTeacher = from t in context.Teachers
                                 where t.TeacherID.ToString() == txtTeacherID.Text
                                 select t;
                if (findTeacher.Any())
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //Button Exit Teacher
        {
            if (MessageBox.Show("Do you want close the App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void buttonSearchTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var findTeacher = from t in context.Teachers
                                     where t.TeacherID.ToString() == txtSearchTeacher.Text
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
                        txtSearchTeacher.Text = "";
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

        private void buttonListAllTeachers_Click(object sender, EventArgs e)
        {
            LoadATeachers();
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (!existingTeacher())
                {
                    if (!string.IsNullOrEmpty(txtTeacherID.Text) && !string.IsNullOrEmpty(txtTeacherFName.Text) && !string.IsNullOrEmpty(txtTeacherLName.Text))
                    {
                        using (var context = new TeacherCourseDBEntities())
                        {
                            var newTeacher = new Teacher
                            {
                                TeacherID = Convert.ToInt32(txtTeacherID.Text),
                                FirstName = txtTeacherFName.Text,
                                LastName = txtTeacherLName.Text,
                                Email = txtTeacherEmail.Text,
                            };
                            context.Teachers.Add(newTeacher);
                            context.SaveChanges();
                            txtTeacherID.Text = "";
                            txtTeacherFName.Text = "";
                            txtTeacherLName.Text = "";
                            txtTeacherEmail.Text = "";
                            listViewTeachers.Items.Clear();
                            MessageBox.Show("New Teacher Add with Success!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill all that is necessary.");
                    }
                }
                else
                {
                    MessageBox.Show("Teacher with the same id already exists. Cannot add duplicate teacher.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when try adding a new teacher: " + ex.Message);
            }
        }

        private void buttonEditTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var existingTeacher = context.Teachers.SingleOrDefault(t => t.TeacherID.ToString() == txtTeacherID.Text);

                    if (existingTeacher != null)
                    {
                        existingTeacher.FirstName = txtTeacherFName.Text;
                        existingTeacher.LastName = txtTeacherLName.Text;
                        existingTeacher.Email = txtTeacherEmail.Text;
                        context.SaveChanges();
                        txtTeacherID.Text = "";
                        txtTeacherFName.Text = "";
                        txtTeacherLName.Text = "";
                        txtTeacherEmail.Text = "";
                        listViewTeachers.Items.Clear();
                        MessageBox.Show("Teacher updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Teacher not found. Unable to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when trying to update teacher: " + ex.Message);
            }
        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var teacherToDelete = context.Teachers.SingleOrDefault(t => t.TeacherID.ToString() == txtTeacherID.Text);

                    if (teacherToDelete != null)
                    {
                        context.Teachers.Remove(teacherToDelete);
                        context.SaveChanges();
                        txtTeacherID.Text = "";
                        txtTeacherFName.Text = "";
                        txtTeacherLName.Text = "";
                        txtTeacherEmail.Text = "";
                        listViewTeachers.Items.Clear();
                        MessageBox.Show("Teacher deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Teacher not found. Unable to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when trying to delete teacher: " + ex.Message);
            }
        }
        //==========================================TEACHER COURSE=================================

        public bool existingTC()
        {
            using (var context = new TeacherCourseDBEntities())
            {
                var findTC = from tc in context.TeacherCourses
                                  where tc.TeacherCourseID.ToString() == txtTC_ID.Text
                                  select tc;
                var findTeacher = from t in context.Teachers
                                 where t.TeacherID.ToString() == txtTC_TeacherID.Text
                                 select t;
                var findCourse = from c in context.Courses
                                 where c.CourseNumber.ToString() == txtTC_CourseNum.Text
                                 select c;
                if (!findTC.Any() && findTeacher.Any() && findCourse.Any())
                {  
                    return true;  
                }
                else
                {
                    return false;
                }
            }
        }
        public bool checkingMoreThanFourTC(string idToCheck)
        {
            using (var context = new TeacherCourseDBEntities())
            {
                List<Teacher> listTeacherId = new List<Teacher>();

                var listTC = from tc in context.TeacherCourses
                                  select tc;
                foreach (var tid in listTC)
                {
                    listTeacherId.Add(new Teacher { TeacherID = Convert.ToInt32(tid.TeacherID) });
                }

                int idToCheckInt = int.Parse(idToCheck);

                var idCount = listTeacherId
                .Where(t => t.TeacherID == idToCheckInt)
                .Count();

                return idCount >= 4;
            }
        }


        public bool checkingTxt_Null()
        {
            if (!string.IsNullOrEmpty(txtTC_ID.Text) && !string.IsNullOrEmpty(txtTC_TeacherID.Text) && !string.IsNullOrEmpty(txtTC_CourseNum.Text))
            {
                return true;
            }
            else
            {
                return false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close the App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void buttonAddTC_Click(object sender, EventArgs e)
        {
            try
            {
                if (existingTC())
                {
                    if (!checkingMoreThanFourTC(txtTC_TeacherID.Text))
                    {
                        if (checkingTxt_Null())
                        {
                            using (var context = new TeacherCourseDBEntities())
                            {
                                var newTC = new TeacherCours
                                {
                                    TeacherCourseID = Convert.ToInt32(txtTC_ID.Text),
                                    TeacherID = Convert.ToInt32(txtTC_TeacherID.Text),
                                    CourseNumber = Convert.ToInt32(txtTC_CourseNum.Text),

                                };
                                context.TeacherCourses.Add(newTC);
                                context.SaveChanges();
                                txtTC_ID.Text = "";
                                txtTC_TeacherID.Text = "";
                                txtTC_CourseNum.Text = "";
                                listViewTC.Items.Clear();
                                MessageBox.Show("Teacher enrolled in course with sucess!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fill all that is necessary.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Teacher has assigned more than 4 courses.");
                    }
                }
                else
                {
                    MessageBox.Show("Enrollment with the same id already exists or can't find teacher or course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when try adding a new Enrollment: " + ex.Message);
            }
        }

        private void buttonListAllTC_Click(object sender, EventArgs e)
        {
            LoadTC();
        }

        private void buttonEdit_TC_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var existingTeacher = context.TeacherCourses.SingleOrDefault(tc => tc.TeacherCourseID.ToString() == txtTC_ID.Text);

                    if (existingTeacher != null)
                    {
                        existingTeacher.TeacherID = Convert.ToInt32(txtTC_TeacherID.Text);
                        existingTeacher.CourseNumber = Convert.ToInt32(txtTC_CourseNum.Text);
                        context.SaveChanges();
                        txtTC_ID.Text = "";
                        txtTC_TeacherID.Text = "";
                        txtTC_CourseNum.Text = "";
                        listViewTC.Items.Clear();
                        MessageBox.Show("Enrollment updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Enrollment not found. Unable to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonDelete_TC_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var tcToDelete = context.TeacherCourses.SingleOrDefault(tc => tc.TeacherCourseID.ToString() == txtTC_ID.Text);

                    if (tcToDelete != null)
                    {
                        context.TeacherCourses.Remove(tcToDelete);
                        context.SaveChanges();
                        txtTC_ID.Text = "";
                        txtTC_TeacherID.Text = "";
                        txtTC_CourseNum.Text = "";
                        listViewTC.Items.Clear();
                        MessageBox.Show("Enrollment deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Enrollment not found. Unable to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonSearch_TC_Click(object sender, EventArgs e)
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
    }
}
