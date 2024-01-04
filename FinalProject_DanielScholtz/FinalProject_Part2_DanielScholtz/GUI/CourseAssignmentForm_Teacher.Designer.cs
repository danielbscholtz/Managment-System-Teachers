namespace FinalProject_Part2_DanielScholtz.GUI
{
    partial class CourseAssignmentForm_Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonListAllCourses = new System.Windows.Forms.Button();
            this.listView_Courses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.lblCourseNumber = new System.Windows.Forms.Label();
            this.lblCourseDuration = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchCourse = new System.Windows.Forms.Button();
            this.txtSearchCourse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTeacherFName = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lblTeacherLName = new System.Windows.Forms.Label();
            this.lblTeacherEmail = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.listViewTC = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxSearchStudent = new System.Windows.Forms.GroupBox();
            this.lblTeacherID_TC = new System.Windows.Forms.Label();
            this.lblTC_ID = new System.Windows.Forms.Label();
            this.lblCourseNum_TC = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.btnSeachTeachersCourses = new System.Windows.Forms.Button();
            this.txtSearch_TC = new System.Windows.Forms.TextBox();
            this.lblSearchStudID = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxSearchStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 588);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonListAllCourses);
            this.tabPage1.Controls.Add(this.listView_Courses);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(590, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Course Managment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonListAllCourses
            // 
            this.buttonListAllCourses.Location = new System.Drawing.Point(105, 295);
            this.buttonListAllCourses.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListAllCourses.Name = "buttonListAllCourses";
            this.buttonListAllCourses.Size = new System.Drawing.Size(318, 41);
            this.buttonListAllCourses.TabIndex = 14;
            this.buttonListAllCourses.Text = "List All Courses";
            this.buttonListAllCourses.UseVisualStyleBackColor = true;
            this.buttonListAllCourses.Click += new System.EventHandler(this.buttonListAllCourses_Click);
            // 
            // listView_Courses
            // 
            this.listView_Courses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Courses.GridLines = true;
            this.listView_Courses.HideSelection = false;
            this.listView_Courses.LabelEdit = true;
            this.listView_Courses.Location = new System.Drawing.Point(28, 355);
            this.listView_Courses.Name = "listView_Courses";
            this.listView_Courses.Size = new System.Drawing.Size(470, 119);
            this.listView_Courses.TabIndex = 13;
            this.listView_Courses.UseCompatibleStateImageBehavior = false;
            this.listView_Courses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course Number";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Title";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duration";
            this.columnHeader3.Width = 155;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCourseTitle);
            this.groupBox1.Controls.Add(this.lblCourseNumber);
            this.groupBox1.Controls.Add(this.lblCourseDuration);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonSearchCourse);
            this.groupBox1.Controls.Add(this.txtSearchCourse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(470, 250);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Course";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Location = new System.Drawing.Point(182, 167);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(58, 17);
            this.lblCourseTitle.TabIndex = 21;
            this.lblCourseTitle.Text = "----------";
            // 
            // lblCourseNumber
            // 
            this.lblCourseNumber.AutoSize = true;
            this.lblCourseNumber.Location = new System.Drawing.Point(182, 137);
            this.lblCourseNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseNumber.Name = "lblCourseNumber";
            this.lblCourseNumber.Size = new System.Drawing.Size(58, 17);
            this.lblCourseNumber.TabIndex = 20;
            this.lblCourseNumber.Text = "----------";
            // 
            // lblCourseDuration
            // 
            this.lblCourseDuration.AutoSize = true;
            this.lblCourseDuration.Location = new System.Drawing.Point(182, 204);
            this.lblCourseDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseDuration.Name = "lblCourseDuration";
            this.lblCourseDuration.Size = new System.Drawing.Size(58, 17);
            this.lblCourseDuration.TabIndex = 19;
            this.lblCourseDuration.Text = "----------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Duration:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Course Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Course Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 3;
            // 
            // buttonSearchCourse
            // 
            this.buttonSearchCourse.Location = new System.Drawing.Point(308, 86);
            this.buttonSearchCourse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchCourse.Name = "buttonSearchCourse";
            this.buttonSearchCourse.Size = new System.Drawing.Size(115, 31);
            this.buttonSearchCourse.TabIndex = 2;
            this.buttonSearchCourse.Text = "Search";
            this.buttonSearchCourse.UseVisualStyleBackColor = true;
            this.buttonSearchCourse.Click += new System.EventHandler(this.buttonSearchCourse_Click);
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Location = new System.Drawing.Point(77, 42);
            this.txtSearchCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(346, 23);
            this.txtSearchCourse.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(590, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teacher Managment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTeacherFName);
            this.groupBox4.Controls.Add(this.lblTeacherID);
            this.groupBox4.Controls.Add(this.lblTeacherLName);
            this.groupBox4.Controls.Add(this.lblTeacherEmail);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.buttonSearchEmployee);
            this.groupBox4.Controls.Add(this.txtTeacherID);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(18, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(496, 388);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Teacher";
            // 
            // lblTeacherFName
            // 
            this.lblTeacherFName.AutoSize = true;
            this.lblTeacherFName.Location = new System.Drawing.Point(222, 198);
            this.lblTeacherFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherFName.Name = "lblTeacherFName";
            this.lblTeacherFName.Size = new System.Drawing.Size(58, 17);
            this.lblTeacherFName.TabIndex = 18;
            this.lblTeacherFName.Text = "----------";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Location = new System.Drawing.Point(222, 168);
            this.lblTeacherID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(58, 17);
            this.lblTeacherID.TabIndex = 17;
            this.lblTeacherID.Text = "----------";
            // 
            // lblTeacherLName
            // 
            this.lblTeacherLName.AutoSize = true;
            this.lblTeacherLName.Location = new System.Drawing.Point(222, 235);
            this.lblTeacherLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherLName.Name = "lblTeacherLName";
            this.lblTeacherLName.Size = new System.Drawing.Size(58, 17);
            this.lblTeacherLName.TabIndex = 15;
            this.lblTeacherLName.Text = "----------";
            // 
            // lblTeacherEmail
            // 
            this.lblTeacherEmail.AutoSize = true;
            this.lblTeacherEmail.Location = new System.Drawing.Point(222, 265);
            this.lblTeacherEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherEmail.Name = "lblTeacherEmail";
            this.lblTeacherEmail.Size = new System.Drawing.Size(58, 17);
            this.lblTeacherEmail.TabIndex = 14;
            this.lblTeacherEmail.Text = "----------";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(90, 265);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 17);
            this.label23.TabIndex = 9;
            this.label23.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "LastName:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "FirstName:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(90, 168);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Teacher ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(152, 248);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 3;
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.Location = new System.Drawing.Point(330, 81);
            this.buttonSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(115, 37);
            this.buttonSearchEmployee.TabIndex = 2;
            this.buttonSearchEmployee.Text = "Search";
            this.buttonSearchEmployee.UseVisualStyleBackColor = true;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTeacherID.Location = new System.Drawing.Point(174, 50);
            this.txtTeacherID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(271, 23);
            this.txtTeacherID.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(86, 52);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Teacher Id:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.listViewTC);
            this.tabPage3.Controls.Add(this.groupBoxSearchStudent);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(590, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TeacherCourses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 301);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(318, 41);
            this.button4.TabIndex = 18;
            this.button4.Text = "List All Courses -> Teachers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listViewTC
            // 
            this.listViewTC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11});
            this.listViewTC.GridLines = true;
            this.listViewTC.HideSelection = false;
            this.listViewTC.LabelEdit = true;
            this.listViewTC.Location = new System.Drawing.Point(16, 360);
            this.listViewTC.Name = "listViewTC";
            this.listViewTC.Size = new System.Drawing.Size(532, 137);
            this.listViewTC.TabIndex = 14;
            this.listViewTC.UseCompatibleStateImageBehavior = false;
            this.listViewTC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "RegistrationID";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EmployeeID";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ProjectNumber";
            this.columnHeader11.Width = 224;
            // 
            // groupBoxSearchStudent
            // 
            this.groupBoxSearchStudent.Controls.Add(this.lblTeacherID_TC);
            this.groupBoxSearchStudent.Controls.Add(this.lblTC_ID);
            this.groupBoxSearchStudent.Controls.Add(this.lblCourseNum_TC);
            this.groupBoxSearchStudent.Controls.Add(this.label27);
            this.groupBoxSearchStudent.Controls.Add(this.label28);
            this.groupBoxSearchStudent.Controls.Add(this.label29);
            this.groupBoxSearchStudent.Controls.Add(this.label30);
            this.groupBoxSearchStudent.Controls.Add(this.lblStudentInfo);
            this.groupBoxSearchStudent.Controls.Add(this.btnSeachTeachersCourses);
            this.groupBoxSearchStudent.Controls.Add(this.txtSearch_TC);
            this.groupBoxSearchStudent.Controls.Add(this.lblSearchStudID);
            this.groupBoxSearchStudent.Location = new System.Drawing.Point(16, 16);
            this.groupBoxSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSearchStudent.Name = "groupBoxSearchStudent";
            this.groupBoxSearchStudent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSearchStudent.Size = new System.Drawing.Size(532, 261);
            this.groupBoxSearchStudent.TabIndex = 7;
            this.groupBoxSearchStudent.TabStop = false;
            this.groupBoxSearchStudent.Text = "TeacherCourses";
            // 
            // lblTeacherID_TC
            // 
            this.lblTeacherID_TC.AutoSize = true;
            this.lblTeacherID_TC.Location = new System.Drawing.Point(163, 173);
            this.lblTeacherID_TC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherID_TC.Name = "lblTeacherID_TC";
            this.lblTeacherID_TC.Size = new System.Drawing.Size(58, 17);
            this.lblTeacherID_TC.TabIndex = 25;
            this.lblTeacherID_TC.Text = "----------";
            // 
            // lblTC_ID
            // 
            this.lblTC_ID.AutoSize = true;
            this.lblTC_ID.Location = new System.Drawing.Point(163, 143);
            this.lblTC_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC_ID.Name = "lblTC_ID";
            this.lblTC_ID.Size = new System.Drawing.Size(58, 17);
            this.lblTC_ID.TabIndex = 24;
            this.lblTC_ID.Text = "----------";
            // 
            // lblCourseNum_TC
            // 
            this.lblCourseNum_TC.AutoSize = true;
            this.lblCourseNum_TC.Location = new System.Drawing.Point(163, 210);
            this.lblCourseNum_TC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseNum_TC.Name = "lblCourseNum_TC";
            this.lblCourseNum_TC.Size = new System.Drawing.Size(58, 17);
            this.lblCourseNum_TC.TabIndex = 23;
            this.lblCourseNum_TC.Text = "----------";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(31, 210);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(111, 17);
            this.label27.TabIndex = 22;
            this.label27.Text = "Course Number:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(31, 177);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 17);
            this.label28.TabIndex = 21;
            this.label28.Text = "Teacher Id:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(31, 143);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 17);
            this.label29.TabIndex = 20;
            this.label29.Text = "TC ID:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(93, 223);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(0, 17);
            this.label30.TabIndex = 19;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Location = new System.Drawing.Point(40, 224);
            this.lblStudentInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(0, 17);
            this.lblStudentInfo.TabIndex = 3;
            // 
            // btnSeachTeachersCourses
            // 
            this.btnSeachTeachersCourses.Location = new System.Drawing.Point(319, 64);
            this.btnSeachTeachersCourses.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeachTeachersCourses.Name = "btnSeachTeachersCourses";
            this.btnSeachTeachersCourses.Size = new System.Drawing.Size(115, 41);
            this.btnSeachTeachersCourses.TabIndex = 2;
            this.btnSeachTeachersCourses.Text = "Search";
            this.btnSeachTeachersCourses.UseVisualStyleBackColor = true;
            this.btnSeachTeachersCourses.Click += new System.EventHandler(this.btnSeachTeachersCourses_Click);
            // 
            // txtSearch_TC
            // 
            this.txtSearch_TC.Location = new System.Drawing.Point(177, 33);
            this.txtSearch_TC.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch_TC.Name = "txtSearch_TC";
            this.txtSearch_TC.Size = new System.Drawing.Size(257, 23);
            this.txtSearch_TC.TabIndex = 1;
            // 
            // lblSearchStudID
            // 
            this.lblSearchStudID.AutoSize = true;
            this.lblSearchStudID.Location = new System.Drawing.Point(31, 36);
            this.lblSearchStudID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchStudID.Name = "lblSearchStudID";
            this.lblSearchStudID.Size = new System.Drawing.Size(129, 17);
            this.lblSearchStudID.TabIndex = 0;
            this.lblSearchStudID.Text = "TeacherCourse Id :";
            // 
            // CourseAssignmentForm_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 662);
            this.Controls.Add(this.tabControl1);
            this.Name = "CourseAssignmentForm_Teacher";
            this.Text = "CourseAssignmentForm_Teacher";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBoxSearchStudent.ResumeLayout(false);
            this.groupBoxSearchStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonListAllCourses;
        private System.Windows.Forms.ListView listView_Courses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lblCourseNumber;
        private System.Windows.Forms.Label lblCourseDuration;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchCourse;
        private System.Windows.Forms.TextBox txtSearchCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTeacherFName;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblTeacherLName;
        private System.Windows.Forms.Label lblTeacherEmail;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonSearchEmployee;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listViewTC;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox groupBoxSearchStudent;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Button btnSeachTeachersCourses;
        private System.Windows.Forms.TextBox txtSearch_TC;
        private System.Windows.Forms.Label lblSearchStudID;
        private System.Windows.Forms.Label lblTeacherID_TC;
        private System.Windows.Forms.Label lblTC_ID;
        private System.Windows.Forms.Label lblCourseNum_TC;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
    }
}