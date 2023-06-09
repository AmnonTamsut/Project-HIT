﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project_HIT.Screens
{
    public partial class ProfessorForm : Form
    {
        private Professor Professor;
        Dictionary<string, Student> studentByName = new Dictionary<string, Student>();
        bool updateGradesWasClicked = false;
        ListViewItem temp;
        string lastCourseClicked;
        Form1 back;
        public ProfessorForm(Professor professor, Form1 back)
        {
            InitializeComponent();
            this.Professor = professor;
            welcomeNameLabel.Text = "שלום: " + professor.Name;
            this.back = back;

        }




        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            errorlabelUpdater.Hide();
            ProfessorFormInit();
            this.update_grade_button.Hide();
            this.update_grade_text.Hide();
            this.update_grade_textbox.Hide();
            this.back_to_courses_label.Hide();
            this.students_grades_view.View = View.Details;


            this.students_grades_view.Columns.Add("שם");
            this.students_grades_view.Columns.Add("תז");

            this.students_grades_view.Columns.Add("ציון");
            students_grades_view.Hide();


            ListViewItem x;


            this.professor_list.View = View.Details;
            this.professor_list.Columns.Add("קורס");
            this.professor_list.Columns.Add("מספר נרשמים");
            this.professor_list.Columns.Add("ממוצע");



            this.professor_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.professor_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            populateCourses();
            /*
            //foreach (string c in this.Professor.Courses)
            //{
            //    int counter = 0;
            //    float courseAvg = 0;

            //    if (this.Professor.MyStudents != null)
            //    {
            //        foreach (Student student in this.Professor.MyStudents)
            //        {
            //            studentByName.Add(student.Name, student);

            //            if (student.takesCourse(c)) counter++;
            //            courseAvg += student.Grades[c];
            //        }
            //        courseAvg = courseAvg / counter;
            //        x = new ListViewItem(new string[] { c, counter.ToString(), courseAvg.ToString() });
                    
            //        this.professor_list.Items.Add(x);

            //    }
            //}
            */
            this.professor_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.professor_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void populateCourses()
        {
            ListViewItem x;
            this.professor_list.Items.Clear();
            foreach (string c in this.Professor.Courses)
            {
                int counter = 0;
                float courseAvg = 0;

                if (this.Professor.MyStudents != null)
                {
                    foreach (Student student in this.Professor.MyStudents)
                    {

                        if (!(studentByName.ContainsKey(student.Name)))
                        {
                            studentByName.Add(student.Name, student);
                        }
                        if (student.takesCourse(c)) counter++;
                        courseAvg += student.Grades[c];
                    }
                    courseAvg = courseAvg / counter;
                    x = new ListViewItem(new string[] { c, counter.ToString(), courseAvg.ToString() });

                    this.professor_list.Items.Add(x);

                }
            }
        }


        private void ProfessorFormInit()
        {
            string fileName = Professor.Id.ToString();
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources");

            Professor.signatureInit(path + "\\Signatures\\", Professor_signatue_picturebox);

            Professor.ProfilePictureInit(path + "\\ProfilePictures\\", this.ProfessorProfilePictue);


        }

        private void Professor_signatue_picturebox_Click(object sender, EventArgs e)
        {
            this.Professor.signatueUpdater(Professor_signatue_picturebox);
        }

        private void ProfessorCoursesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void professor_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void professor_list_DoubleClick(object sender, EventArgs e)
        {

            this.back_to_courses_label.Show();
            this.professor_list.Hide();
            this.students_grades_view.Show();


            UpdateGradesInCourse();


        }


        private void UpdateGradesInCourse()
        {


            if (this.professor_list.SelectedItems.Count > 0)
            {
                this.lastCourseClicked = professor_list.SelectedItems[0].Text;

                ListViewItem item = professor_list.SelectedItems[0];

                populateStudentGradesView(item.Text);


            }
        }

        private void populateStudentGradesView(string course)
        {
            this.students_grades_view.Clear();
            this.students_grades_view.View = View.Details;


            this.students_grades_view.Columns.Add("שם");
            this.students_grades_view.Columns.Add("תז");

            this.students_grades_view.Columns.Add("ציון");
            ListViewItem x;

            foreach (Student student in Professor.MyStudents)
            {
                if (student.takesCourse(course))
                {
                    x = new ListViewItem(new string[] { student.Name, student.Id.ToString(), student.Grades[course].ToString() });



                    this.students_grades_view.Items.Add(x);

                }


            }

            this.students_grades_view.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.students_grades_view.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void back_to_courses_label_Click(object sender, EventArgs e)
        {
            populateCourses();
            this.students_grades_view.Hide();

            this.professor_list.Show();
            this.back_to_courses_label.Hide();

        }

        private void students_grades_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void students_grades_view_DoubleClick(object sender, EventArgs e)
        {
            if (this.students_grades_view.SelectedItems.Count > 0)
            {
                this.back_to_courses_label.Hide();
                this.temp = this.students_grades_view.SelectedItems[0];
                this.update_grade_textbox.Clear();
                this.students_grades_view.Hide();
                this.update_grade_button.Show();
                this.update_grade_text.Show();
                this.update_grade_textbox.Show();


            }

        }

        private void gradeUpdater(ListViewItem item)
        {
            if (this.updateGradesWasClicked)
            {
                updateStudentInGradeList(studentByName[item.Text], this.lastCourseClicked, this.update_grade_textbox.Text);

                populateStudentGradesView(this.lastCourseClicked);

                this.students_grades_view.Show();
                this.update_grade_button.Hide();
                this.update_grade_text.Hide();
                this.update_grade_textbox.Hide();

                foreach (Student s in this.Professor.MyStudents) s.updateFiles();

            }
        }

        private void updateStudentInGradeList(Student student, string course, string grade)
        {
            if (string.IsNullOrEmpty(grade)) { }
            else
            {
                student.Grades[course] = Int32.Parse(grade);
            }
        }

        private void update_grade_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.update_grade_textbox.Text)) { errorlabelUpdater.Show(); }
            else
            {
                this.updateGradesWasClicked = true;
                gradeUpdater(this.temp);
                this.updateGradesWasClicked = false;
                this.back_to_courses_label.Show();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {

            this.Professor_signatue_picturebox.Image.Dispose();
            this.Close();
            this.back.clearPassword();
            this.back.deRemember();


            this.back.Show();
        }

        private void ProfessorProfilePictue_Click(object sender, EventArgs e)
        {
            this.Professor.UploadProfilePicture("\\Resources\\ProfilePictures\\", this.ProfessorProfilePictue);
        }

        private void update_grade_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
