using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_HIT
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_login_text_TextChanged(object sender, EventArgs e)
        {
            id_login_text.BackColor = Color.Transparent;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            password_login_text.BackColor = Color.Transparent;

        }

        private void login_send_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_data_TextChanged(object sender, EventArgs e)
        {

        }


        private void password_data_TextChanged(object sender, EventArgs e)
        {

        }



        private void clear_TextChanged(object sender, EventArgs e)
        {
            id_data.Clear();
            password_data.Clear();
            this.clear.BackColor = Color.Transparent;
        }
    }
}
