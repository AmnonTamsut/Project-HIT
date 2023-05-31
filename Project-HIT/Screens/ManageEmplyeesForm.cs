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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_HIT.Screens
{
    public partial class ManageEmplyeesForm : Form
    {
        Dictionary<int, Employee> workers;
        Form owner;
        string profilePicPath;
        bool uploadedProfilePic = false;

        public ManageEmplyeesForm(Dictionary<int, Employee> workers, Form owner)
        {

            this.owner = owner;
            this.workers = workers;
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            this.Show();
            this.errorLabel.Hide();

            this.workerList.Columns.Add("מספר עובד");
            this.workerList.Columns.Add("שם");
            this.workerList.Columns.Add("שכר");
            this.workerList.View = View.Details;
            foreach (Employee employee in this.workers.Values)
            {

                ListViewItem item = new ListViewItem(new[] { employee.workerId.ToString(), employee.Name, employee.salary.ToString() });
                this.workerList.Items.Add(item);



            }
            this.workerList.MultiSelect = false;
        }

        private void workerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            var profilePicturePath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\ProfilePictures\\";
            var signaturePath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Signatures\\";

            if (this.workerList.SelectedItems.Count > 0)
            {
                this.errorLabel.Hide();
                int wId = Int32.Parse(this.workerList.SelectedItems[0].Text);
                Employee temp = this.workers[wId];
                this.nameTextBox.Text = temp.Name;
                this.idTextBox.Text = temp.Id.ToString();
                this.salaryTextBox.Text = temp.salary.ToString();
                this.employeeWokerId.Text = this.workerList.SelectedItems[0].Text;

                if (this.signaturPictureBox.Image != null)
                {
                    this.signaturPictureBox.Image.Dispose();

                }

                this.profilePictureBox.Image.Dispose();
                temp.ProfilePictureInit(profilePicturePath, this.profilePictureBox);
                temp.signatureInit(signaturePath, this.signaturPictureBox);

            }
            else { return; }
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            if (this.workerList.SelectedItems.Count > 0)
            {
                this.profilePictureBox.Image.Dispose();
                int wId = Int32.Parse(this.workerList.SelectedItems[0].Text);
                this.profilePicPath = this.workers[wId].getPathOfTempImage(this.profilePictureBox);
                this.profilePictureBox.Image = Image.FromFile(this.profilePicPath);






            }
            else { return; }
        }

        private void signaturPictureBox_Click(object sender, EventArgs e)
        {
            if (this.workerList.SelectedItems.Count > 0)
            {

                int wId = Int32.Parse(this.workerList.SelectedItems[0].Text);
                Employee temp = this.workers[wId];
                temp.signatueUpdater(this.signaturPictureBox);

            }
            else { return; }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (this.workerList.SelectedItems.Count > 0)
            {
            }
            int wId = Int32.Parse(this.workerList.SelectedItems[0].Text);
            Employee temp = this.workers[wId];
            temp.Name = this.nameTextBox.Text;
            temp.salary = Int32.Parse(this.salaryTextBox.Text);
            temp.Id = Int32.Parse(this.idTextBox.Text);
            this.owner.Show();
            this.Hide();
            if (this.profilePicPath != null)
            {

                string fileName = this.idTextBox.Text;
                string workingDirectory = Environment.CurrentDirectory;
                string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\ProfilePictures\\");
                this.profilePictureBox.Image.Dispose();

                this.profilePictureBox.Dispose();
                this.workerList.Dispose();



                File.Copy(this.profilePicPath, path + fileName + ".bmp", true);

            }
            else
            {
                this.errorLabel.Show();
                return;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.owner.Show();
        }

        private void ManageEmplyeesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
