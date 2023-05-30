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

    public partial class NewMinhalaForm : Form
    {
        SchoolMain school;

        Form back;
        string picPath;
        bool uploadedProfilePicture = false;
        public NewMinhalaForm(SchoolMain school, Form back)
        {
            InitializeComponent();
            this.school = school;
            this.back = back;
            init();
        }

        private void init()
        {
            this.Show();
            this.errorDoneBtn.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                this.picPath = opnfd.FileName;
                this.uploadedProfilePicture = true;
            }
            this.pictureBox1.Image = Image.FromFile(this.picPath);
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idTextBox.Text) || string.IsNullOrEmpty(this.nameTextBox.Text) || string.IsNullOrEmpty(this.idTextBox.Text) || string.IsNullOrEmpty(this.passTextBox.Text)) { this.errorDoneBtn.Show(); }
            else
            {
                if (this.uploadedProfilePicture)
                {
                    string fileName = this.idTextBox.Text;
                    string workingDirectory = Environment.CurrentDirectory;
                    string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\ProfilePictures\\");

                    File.Copy(this.picPath, path + fileName + ".bmp");
                }
                MinhalaEmployee m = new MinhalaEmployee(this.school);
                m.Name = this.nameTextBox.Text;
                m.Id = Int32.Parse(this.idTextBox.Text);
                this.school.Users.Add(m, this.passTextBox.Text);

                this.Hide();
                this.back.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.back.Show();
        }
    }
}

