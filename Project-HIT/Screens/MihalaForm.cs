using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HIT
{
    public partial class MihalaForm : Form
    {
        MinhalaEmployee Minhala;
        SchoolMain School;
        public MihalaForm(MinhalaEmployee minhala, SchoolMain school)
        {
            InitializeComponent();

            this.School = school;
            this.name_label.Text = this.Minhala.Name;
            this.Minhala = minhala;
        }
    }
}
