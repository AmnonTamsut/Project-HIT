using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_HIT.Screens;
using Project_HIT;

namespace Project_HIT
{
    public partial class Form1 : Form
    {
        private SchoolMain school;
        public Form1(SchoolMain school)
        {
            InitializeComponent();
            this.school = school;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ////comboBox1_test1_dictionary.DataSource = new BindingSource(this.school.Degrees[0].Courses, null);
            ////comboBox1_test1_dictionary.ValueMember = "Value";
            ////comboBox1_test1_dictionary.DisplayMember = "Key";
            //Professor f = new Professor(this.school.Degrees[0].Courses.Keys.ToList(), null);

            //Form x = new ProfessorForm(f, this);
            //x.Show();
        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.password_text.BackColor = Color.FromArgb(100, 0, 0, 0);
        }



        private void id_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.id_data.Clear();
            this.password_data.Clear();

        }
        public void clearPassword() 
        {
            this.password_data.Clear();

        }

        private void login_send_Click(object sender, EventArgs e)
        {
            Person p;
            p = school.findUserById(int.Parse(this.id_data.Text), this.password_data.Text);
            Form formX;
            if (p == null)
            {
                MessageBox.Show("שם משתמש או סיסמא לא תקינים");
                this.password_data.Clear();
            }
            else
            {
                if (p is Student)
                {
                    formX = new StudentForm((Student)p, this);
                    formX.Show();
                    this.Hide();
                }
                else if (p is Professor)
                {
                    formX = new ProfessorForm((Professor)p, this);
                    formX.Show();
                    this.Hide();

                }
                else if (p is MinhalaEmployee)
                {
                    formX = new MihalaForm((MinhalaEmployee)p);
                    formX.Show();
                    this.Hide();

                }

            }
        }

        private void id_login_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_test1_dictionary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
