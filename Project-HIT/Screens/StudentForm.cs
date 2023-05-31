using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_HIT.Screens
{
    public partial class StudentForm : Form
    {
        Student student;
        Form1 back;
        public StudentForm(Student student, Form1 back)
        {
            InitializeComponent();
            this.student = student;
            this.back = back;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            StudentFormViewInit();
        }


        private void StudentFormViewInit()
        {
            this.welcomeNameLabel.Text = "שלום: " + student.Name;
            this.degreeLabelInfo.Text = student.D.Name;
            string fileName = student.Id.ToString();
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources");
            GradesDataFill();
            student.signatureInit(path + "\\Signatures\\", signatue_picturebox);
            student.ProfilePictureInit(path + "\\ProfilePictures\\", profilePicture);

        }

        private void GradesDataFill()
        {

            dataGridView1.DataSource = student.StudentBalanceToDataTable();
            student.updateGpa();
            this.avg_label.Text = "הממוצע שלך:" + student.GPA1.ToString("n2");

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signatue_picturebox_Click(object sender, EventArgs e)
        {
            this.student.signatueUpdater(signatue_picturebox);




        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            UploadProfilePicture();


        }
        private void UploadProfilePicture()
        {
            string fileName = student.Id.ToString();
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\ProfilePictures\\");


            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                if (!(opnfd.FileName.Equals(path + student.Id.ToString() + ".bmp")))
                {
                    profilePicture.Image.Dispose();
                    File.Copy(opnfd.FileName, path + student.Id.ToString() + ".bmp", true);
                }
                profilePicture.Image = new Bitmap(opnfd.FileName);
            }
            student.ProfileImage = student.Id.ToString() + ".bmp";
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.student.updateFiles();
            this.back.deRemember();
            this.back.Remembered = false;
            this.signatue_picturebox.Image.Dispose();
            this.Dispose();
            this.Close();
            this.back.clearPassword();
            this.back.Show();
        }

        private void request_form_btn_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            RequestForm rForm = new RequestForm(this.student);

            rForm.Show();


        }
    }
}
