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
    public partial class StudentManageForm : Form
    {
        Dictionary<string, Student> students;
        Form back;
        List<Degree> degrees;
        Dictionary<string, Degree> degreeNameMap = new Dictionary<string, Degree>();
        string profilePicPath;
        bool uploadedProfilePic = false;
        public StudentManageForm(Dictionary<string, Student> students, Form back, List<Degree> degrees)
        {
            InitializeComponent();
            this.students = students;
            this.back = back;
            this.degrees = degrees;
            init();
        }

        private void init()
        {
            this.Show();


            this.errorLabel.Hide();
            this.studentsList.Columns.Add("תעודת זהות");
            this.studentsList.Columns.Add("שם");
            this.studentsList.Columns.Add("תואר");

            foreach (Student student in this.students.Values)
            {

                ListViewItem item = new ListViewItem(new[] { student.Id.ToString(), student.Name, student.D.Name });
                this.studentsList.Items.Add(item);
            }


            this.studentsList.View = View.Details;
            this.studentsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.studentsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            this.studentsList.MultiSelect = false;

            foreach (Degree d in this.degrees) { this.degreeNameMap.Add(d.Name, d); }

        }


        private void studentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            var profilePicturePath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\ProfilePictures\\";
            var signaturePath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Signatures\\";
            if (this.studentsList.SelectedItems.Count > 0)
            {
                string studentId = this.studentsList.SelectedItems[0].Text;
                this.idTextBox.Text = studentId;
                this.nameTextBox.Text = this.students[studentId].Name;
                this.degreeCmb.Text = this.students[studentId].D.Name;

                if (this.signaturPictureBox.Image != null)
                {
                    this.signaturPictureBox.Image.Dispose();

                }

                this.profilePicBox.Image.Dispose();
                this.students[studentId].ProfilePictureInit(profilePicturePath, this.profilePicBox);
                this.students[studentId].signatureInit(signaturePath, this.signaturPictureBox);



            }
            else { return; }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.back.Show();
        }

        private void degreeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.degreeCmb.Items.Clear();
            foreach (Degree degree in this.degrees)
            {
                this.degreeCmb.Items.Add(degree.Name);
            }



        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profilePicBox_Click(object sender, EventArgs e)
        {
            if (this.studentsList.SelectedItems.Count > 0)
            {
                this.profilePicBox.Image.Dispose();
                string studentID = this.studentsList.SelectedItems[0].Text;
                this.profilePicPath = this.students[studentID].getPathOfTempImage(this.profilePicBox);
                this.profilePicBox.Image = Image.FromFile(this.profilePicPath);

            }
            else { return; }

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (this.studentsList.SelectedItems.Count > 0)
            {
                if (this.profilePicPath != null)
                {
                    this.profilePicBox.Dispose();
                    string fileName = this.idTextBox.Text;
                    string workingDirectory = Environment.CurrentDirectory;
                    string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\ProfilePictures\\");

                    this.profilePicBox.Image.Dispose();
                    this.profilePicBox.Dispose();

                    File.Copy(this.profilePicPath, path + fileName + ".bmp", true);
                }

                string studentID = this.studentsList.SelectedItems[0].Text;
                this.students[studentID].Name = this.nameTextBox.Text;

                this.students[studentID].Id = Int32.Parse(this.idTextBox.Text);
                this.students[studentID].D = this.degreeNameMap[this.degreeCmb.Text];
                this.Close();
                this.back.Show();
            }
            else
            {
                this.errorLabel.Show();
                return;
            }

        }

        private void studentsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string studentId = this.studentsList.SelectedItems[0].Text;


            this.students.Remove(studentsList.SelectedItems[0].Text);
            this.studentsList.Items.Remove(studentsList.SelectedItems[0]);
        }

        private void StudentManageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
