
namespace Project_HIT.Screens
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            welcomeNameLabel = new System.Windows.Forms.Label();
            avg_label = new System.Windows.Forms.Label();
            signatue_picturebox = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            profilePicture = new System.Windows.Forms.PictureBox();
            logout = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            degreeLabelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signatue_picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(1, 130, 135);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.Enabled = false;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(1, 130, 135);
            dataGridView1.Location = new System.Drawing.Point(73, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(393, 183);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // welcomeNameLabel
            // 
            welcomeNameLabel.AutoSize = true;
            welcomeNameLabel.Location = new System.Drawing.Point(539, 39);
            welcomeNameLabel.Name = "welcomeNameLabel";
            welcomeNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            welcomeNameLabel.Size = new System.Drawing.Size(54, 15);
            welcomeNameLabel.TabIndex = 2;
            welcomeNameLabel.Text = "שלום שם";
            welcomeNameLabel.Click += label1_Click;
            // 
            // avg_label
            // 
            avg_label.AutoSize = true;
            avg_label.Location = new System.Drawing.Point(319, 30);
            avg_label.Name = "avg_label";
            avg_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            avg_label.Size = new System.Drawing.Size(27, 15);
            avg_label.TabIndex = 3;
            avg_label.Text = "gpa";
            // 
            // signatue_picturebox
            // 
            signatue_picturebox.BackColor = System.Drawing.Color.FromArgb(1, 130, 135);
            signatue_picturebox.Location = new System.Drawing.Point(539, 246);
            signatue_picturebox.Name = "signatue_picturebox";
            signatue_picturebox.Size = new System.Drawing.Size(210, 105);
            signatue_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            signatue_picturebox.TabIndex = 4;
            signatue_picturebox.TabStop = false;
            signatue_picturebox.Click += signatue_picturebox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            label1.Location = new System.Drawing.Point(606, 322);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(76, 29);
            label1.TabIndex = 5;
            label1.Text = "חתימה";
            // 
            // profilePicture
            // 
            profilePicture.BackColor = System.Drawing.Color.FromArgb(1, 130, 135);
            profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            profilePicture.Image = (System.Drawing.Image)resources.GetObject("profilePicture.Image");
            profilePicture.Location = new System.Drawing.Point(581, 91);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new System.Drawing.Size(122, 120);
            profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 6;
            profilePicture.TabStop = false;
            profilePicture.Click += profilePicture_Click;
            // 
            // logout
            // 
            logout.Location = new System.Drawing.Point(12, 22);
            logout.Name = "logout";
            logout.Size = new System.Drawing.Size(75, 23);
            logout.TabIndex = 7;
            logout.Text = "התנתק/י";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(364, 91);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 8;
            label2.Text = "תואר:";
            // 
            // degreeLabelInfo
            // 
            degreeLabelInfo.AutoSize = true;
            degreeLabelInfo.Location = new System.Drawing.Point(287, 91);
            degreeLabelInfo.Name = "degreeLabelInfo";
            degreeLabelInfo.Size = new System.Drawing.Size(38, 15);
            degreeLabelInfo.TabIndex = 9;
            degreeLabelInfo.Text = "label3";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(degreeLabelInfo);
            Controls.Add(label2);
            Controls.Add(logout);
            Controls.Add(profilePicture);
            Controls.Add(label1);
            Controls.Add(signatue_picturebox);
            Controls.Add(avg_label);
            Controls.Add(welcomeNameLabel);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)signatue_picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label welcomeNameLabel;
        private System.Windows.Forms.Label avg_label;
        private System.Windows.Forms.PictureBox signatue_picturebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label degreeLabelInfo;
    }
}