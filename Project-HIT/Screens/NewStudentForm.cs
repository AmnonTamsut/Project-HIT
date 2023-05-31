using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HIT.Screens
{
    public partial class NewStudentForm : Form
    {
        SchoolMain school;
        MinhalaForm backForm;
        bool uploadedProfilePic = false;
        string profilePicturePath;
        public NewStudentForm(SchoolMain school, MinhalaForm back)
        {
            InitializeComponent();
            this.school = school;
            this.backForm = back;
            init();
        }

        private void init()
        {
            this.backForm.Hide();
            foreach (Degree d in this.school.Degrees) { this.degreeCmb.Items.Add(d.Name); }
            this.Show();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {

            if (this.nameTextBox.Text.Equals("") || this.passLabel.Text.Equals("") || this.idTextBox.Text.Equals("")) { MessageBox.Show("נא למלא את כל הטופס"); }
            else
            {
                Student s = new Student(this.school.getDegreeByName(this.degreeCmb.SelectedItem.ToString()));
                s.Name = this.nameTextBox.Text;
                s.Id = Int32.Parse(this.idTextBox.Text);

                this.school.addUser(s, this.passwordTextBox.Text);
                this.school.Students.Add(s.Id.ToString(), s);

                if (this.uploadedProfilePic)
                {
                    string fileName = this.idTextBox.Text;
                    string workingDirectory = Environment.CurrentDirectory;
                    string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\ProfilePictures\\");

                    File.Copy(this.profilePicturePath, path + fileName + ".bmp");
                }

                this.Hide();
                this.backForm.Show();

            }
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                this.profilePicturePath = opnfd.FileName;
                this.uploadedProfilePic = true;
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.backForm.Show();
        }

        private void NewStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
