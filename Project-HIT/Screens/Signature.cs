using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_HIT.Screens
{

    public partial class Signature : Form
    {
        Person p;
        struct Line
        {
            public float x;
            public float y;
            public float endX;
            public float endY;
        }
        string id;
        Graphics graphics;
        Bitmap bitmapLastUsed = new Bitmap(1, 1);


        List<Line> lines;
        public Signature(Person p)
        {
            this.p = p;
            this.id = p.Id.ToString();
            this.lines = new List<Line>();
            InitializeComponent();

            string fileName = this.id;
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Signatures\\");




        }




        float xPoint = 0;
        float yPoint = 0;
        float endX = 0;
        float endY = 0;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.graphics = panel1.CreateGraphics();
            graphics.DrawLine(Pens.Blue, xPoint, yPoint, endX, endY);
            Line l = new()
            {
                x = xPoint,
                y = yPoint,
                endX = endX,
                endY = endY
            };
            this.lines.Add(l);
            endX = xPoint;
            endY = yPoint;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xPoint = e.X;
                yPoint = e.Y;
                panel1_Paint(this, null);
            }
        }

        public void SignatureToPicture()
        {
            this.bitmapLastUsed.Dispose();
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);

            string fileName = this.id.ToString();
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Signatures", fileName + ".bmp");
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            foreach (Line l in this.lines)
            {
                g.DrawLine(Pens.Blue, l.x, l.y, l.endX, l.endY);
            }

            bmp.Save(path);
            this.bitmapLastUsed = bmp;

            bmp.Dispose();
            g.Dispose();



        }

        private void save_signature_Click(object sender, EventArgs e)
        {
            SignatureToPicture();

            this.Close();

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.graphics.Clear(Color.White);
            this.lines.Clear();
        }

        private void Signature_Load(object sender, EventArgs e)
        {

        }
    }
}
