using Project_HIT.Screens;
using System;
using System.Windows.Forms;

namespace Project_HIT
{
    public partial class MinhalaForm : Form
    {
        MinhalaEmployee Minhala;
        SchoolMain School;
        Form1 back;
        public MinhalaForm(MinhalaEmployee minhala, SchoolMain school, Form1 back)
        {
            InitializeComponent();

            this.School = school;
            this.Minhala = minhala;
            this.name_label.Text = this.Minhala.Name;
            this.back = back;
        }


        private void addStudentbtn_Click(object sender, EventArgs e)
        {
            Form newStudent = new NewStudentForm(this.School, this);
            this.Hide();
        }

        private void newProfBtn_Click_1(object sender, EventArgs e)
        {
            Form newStudent = new NewProfessorForm(this.School, this);
            this.Hide();
        }

        private void newMinhala_Click(object sender, EventArgs e)
        {
            Form newMinhala = new NewMinhalaForm(this.School, this);
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.back.deRemember();

            this.Close();
            this.back.Show();
        }

        private void manageWorkersBtn_Click(object sender, EventArgs e)
        {
            Form manageEmployees = new ManageEmplyeesForm(this.School.Workers, this);
            this.Hide();
        }

        private void manageStudentsBtn_Click(object sender, EventArgs e)
        {
            Form x = new StudentManageForm(this.School.Students, this, this.School.Degrees);
            this.Hide();
        }

        private void MinhalaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
