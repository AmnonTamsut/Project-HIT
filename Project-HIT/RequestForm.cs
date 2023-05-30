using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Project_HIT.Screens
{
    public partial class RequestForm : Form
    {
        String path;
        Request request;
        Student student;
        List<Request> requests;
        public RequestForm(Student s)
        {
            request = new Request();
            student = s;
            InitializeComponent();
            Init();
        }
        public RequestForm(Student s, Request req, List<Request> requests)
        {
            request = req == null ? request = new Request() : req;
            student = s;
            this.requests = requests;
            InitializeComponent();
            Init();
        }

        void Init()
        {


            path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources\\Requests\\";
            if (!Directory.Exists(path))
            {

                Directory.CreateDirectory(path);
                path = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources\\Requests\\" + this.student.Name) + ".xml";

                File.Create(path);

                return;
            }
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Request));
                using (var reader = new StreamReader(path + this.student.Name + ".xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    if (obj != null) request = (Request)obj;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            lecturerCmb.Text = request.Lecturer;
            subjectText.Text = request.Subject;
            contentTxtBox.Text = request.Content;
        }

        private void RequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.request.Lecturer = lecturerCmb.Text;
            request.Subject = subjectText.Text;
            request.Content = contentTxtBox.Text;

            if (request.IsEmpty())
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Request));
            using (var writer = new StreamWriter(path + this.student.Name + ".xml"))
            {
                serializer.Serialize(writer, request);
            }
        }

        private void lecturerCmb_Leave(object sender, EventArgs e)
        {
            this.request.Lecturer = lecturerCmb.Text;
        }

        private void subjectText_Leave(object sender, EventArgs e)
        {
            request.Subject = subjectText.Text;
        }

        private void contentTxtBox_Leave(object sender, EventArgs e)
        {
            request.Content = contentTxtBox.Text;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            this.requests.Add(this.request);

            this.request.Clear();
            MessageBox.Show("הפנייה נשלחה");
            this.Close();
        }
        private void lectureCmp_Load()
        {

        }
        private void lecturerCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
