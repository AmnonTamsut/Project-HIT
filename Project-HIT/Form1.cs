using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Project_HIT
{
    [Serializable()]

    public partial class Form1 : Form
    {

        private SchoolMain school;
        bool remembered = false;

        public bool Remembered { get => remembered; set => remembered = value; }

        public Form1(SchoolMain school)
        {
            InitializeComponent();
            this.school = school;



        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Serialization\\data.hit");

            if (File.Exists(path))
            {
                IFormatter formatter = new BinaryFormatter();

                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                RememberMe i = (RememberMe)formatter.Deserialize(stream);
                if (i.AskedToBeRemembered)
                {
                    this.remembered = true;
                    i.P.OpenForm(this);
                    //(this.school.findUserById(int.Parse(i.Id),i.Pass)).OpenForm(this);
                }
                stream.Close();
            }

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
            if (this.rememberMeCheckBox.Checked && school.findUserById(int.Parse(this.id_data.Text), this.password_data.Text) != null)
            {
                RememberMe i = new RememberMe();
                this.remembered = true;
                i.AskedToBeRemembered = true;
                string workingDirectory = Environment.CurrentDirectory;
                string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Serialization\\data.hit");
                i.P = school.findUserById(int.Parse(this.id_data.Text), this.password_data.Text);
                i.Id = this.id_data.Text;
                i.Pass = this.password_data.Text;
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, i);
                stream.Close();
            }

            p = school.findUserById(int.Parse(this.id_data.Text), this.password_data.Text);
            if (p == null)
            {
                MessageBox.Show("שם משתמש או סיסמא לא תקינים");
                this.password_data.Clear();
            }
            else
            {
                p.OpenForm(this);
                this.Hide();

            }
        }

        public void deRemember()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Serialization\\data.hit");

            File.Delete(path);
            this.Remembered = false;
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

        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            if (this.Remembered)
            {
                this.Hide();
            }

        }
    }
}
