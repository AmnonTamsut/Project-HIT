
namespace Project_HIT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imageList1 = new System.Windows.Forms.ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            password_data = new System.Windows.Forms.TextBox();
            id_data = new System.Windows.Forms.TextBox();
            login_send = new System.Windows.Forms.Button();
            password_text = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ID_text = new System.Windows.Forms.Label();
            clear_btn = new System.Windows.Forms.Button();
            password_text.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // password_data
            // 
            password_data.Location = new System.Drawing.Point(282, 254);
            password_data.Name = "password_data";
            password_data.Size = new System.Drawing.Size(271, 23);
            password_data.TabIndex = 13;
            password_data.TextChanged += password_data_TextChanged;
            // 
            // id_data
            // 
            id_data.Location = new System.Drawing.Point(282, 180);
            id_data.Name = "id_data";
            id_data.Size = new System.Drawing.Size(271, 23);
            id_data.TabIndex = 12;
            id_data.TextChanged += id_data_TextChanged;
            // 
            // login_send
            // 
            login_send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            login_send.Location = new System.Drawing.Point(282, 323);
            login_send.Name = "login_send";
            login_send.Size = new System.Drawing.Size(271, 40);
            login_send.TabIndex = 11;
            login_send.Text = "התחבר/י";
            login_send.UseVisualStyleBackColor = false;
            login_send.Click += login_send_Click;
            // 
            // password_text
            // 
            password_text.Controls.Add(label1);
            password_text.Controls.Add(ID_text);
            password_text.Controls.Add(clear_btn);
            password_text.Location = new System.Drawing.Point(196, 112);
            password_text.Name = "password_text";
            password_text.Size = new System.Drawing.Size(427, 298);
            password_text.TabIndex = 15;
            password_text.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(315, 120);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "סיסמא";
            // 
            // ID_text
            // 
            ID_text.AutoSize = true;
            ID_text.ForeColor = System.Drawing.Color.White;
            ID_text.Location = new System.Drawing.Point(289, 40);
            ID_text.Name = "ID_text";
            ID_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ID_text.Size = new System.Drawing.Size(68, 15);
            ID_text.TabIndex = 1;
            ID_text.Text = "תעודת זהות";
            ID_text.Click += label1_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new System.Drawing.Point(86, 171);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new System.Drawing.Size(75, 23);
            clear_btn.TabIndex = 0;
            clear_btn.Text = "נקה/י הכל";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = Properties.Resources.HIT_logo_50_years_c;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(870, 489);
            Controls.Add(password_data);
            Controls.Add(id_data);
            Controls.Add(login_send);
            Controls.Add(password_text);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            password_text.ResumeLayout(false);
            password_text.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox password_data;
        private System.Windows.Forms.TextBox id_data;
        private System.Windows.Forms.Button login_send;
        private System.Windows.Forms.Panel password_text;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label ID_text;
        private System.Windows.Forms.Label label1;
    }
}

