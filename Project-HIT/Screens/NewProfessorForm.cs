using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project_HIT.Screens
{
    public partial class NewProfessorForm : Form
    {
        SchoolMain school;
        MinhalaForm back;
        bool uploadedProfilePicture = false;
        string profilePicPath;
        public NewProfessorForm(SchoolMain school, MinhalaForm back)
        {
            this.back = back;
            this.school = school;
            InitializeComponent();
            init();
        }

        private void init()
        {
            this.back.Hide();
            foreach (Degree d in this.school.Degrees) { this.degreeCmb.Items.Add(d.Name); }
            this.Show();
        }
        private void degreeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.coursesCheckBoxList.Items.Clear();
            foreach (string course in this.school.getDegreeByName(this.degreeCmb.Text).Courses.Keys)
            {
                this.coursesCheckBoxList.Items.Add(course);
            }
        }

        private void coursesCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                this.profilePicPath = opnfd.FileName;
                this.uploadedProfilePicture = true;
            }
            this.profilePictureBox.Image = Image.FromFile(this.profilePicPath);
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (this.coursesCheckBoxList.CheckedItems.Count == 0)
            {
                MessageBox.Show("נא לבחור קורס אחד לפחות");
            }
            else
            {
                if (this.uploadedProfilePicture)
                {
                    string fileName = this.idTextBox.Text;
                    string workingDirectory = Environment.CurrentDirectory;
                    string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\ProfilePictures\\");

                    File.Copy(this.profilePicPath, path + fileName + ".bmp");
                }
                List<Student> studentList = new List<Student>();

                foreach (var course in this.coursesCheckBoxList.CheckedItems.Cast<string>().ToList())
                {
                    studentList.AddRange(this.school.getAllStudentsForCourse(course));

                }

                Professor professor = new Professor(this.coursesCheckBoxList.CheckedItems.Cast<string>().ToList(), studentList);
                professor.Name = this.nameTextBox.Text;
                professor.Id = Int32.Parse(this.idTextBox.Text);
                this.school.Users.Add(professor, this.passTextBox.Text);
                this.Close();
                this.back.Show();

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.back.Show();
        }

        private void NewProfessorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
