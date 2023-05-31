namespace Project_HIT.Screens
{
    partial class NewStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStudentForm));
            nameLabel = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            degreeCmb = new System.Windows.Forms.ComboBox();
            sendBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            idTextBox = new System.Windows.Forms.TextBox();
            profilePictureBox = new System.Windows.Forms.PictureBox();
            passwordTextBox = new System.Windows.Forms.TextBox();
            passLabel = new System.Windows.Forms.Label();
            fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(434, 137);
            nameLabel.Name = "nameLabel";
            nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameLabel.Size = new System.Drawing.Size(27, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "שם:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(186, 129);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameTextBox.Size = new System.Drawing.Size(188, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(427, 182);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "תואר";
            // 
            // degreeCmb
            // 
            degreeCmb.FormattingEnabled = true;
            degreeCmb.Location = new System.Drawing.Point(186, 174);
            degreeCmb.Name = "degreeCmb";
            degreeCmb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            degreeCmb.Size = new System.Drawing.Size(188, 23);
            degreeCmb.TabIndex = 2;
            // 
            // sendBtn
            // 
            sendBtn.Location = new System.Drawing.Point(362, 290);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new System.Drawing.Size(75, 23);
            sendBtn.TabIndex = 4;
            sendBtn.Text = "סיום";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(390, 92);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 5;
            label2.Text = "תעודת זהות:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new System.Drawing.Point(186, 84);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new System.Drawing.Size(188, 23);
            idTextBox.TabIndex = 0;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            profilePictureBox.Image = (System.Drawing.Image)resources.GetObject("profilePictureBox.Image");
            profilePictureBox.Location = new System.Drawing.Point(597, 84);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new System.Drawing.Size(100, 113);
            profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            profilePictureBox.TabIndex = 7;
            profilePictureBox.TabStop = false;
            profilePictureBox.Click += profilePictureBox_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(186, 220);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(188, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(416, 228);
            passLabel.Name = "passLabel";
            passLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            passLabel.Size = new System.Drawing.Size(45, 15);
            passLabel.TabIndex = 9;
            passLabel.Text = "סיסמא:";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // backButton
            // 
            backButton.Location = new System.Drawing.Point(48, 34);
            backButton.Name = "backButton";
            backButton.Size = new System.Drawing.Size(75, 23);
            backButton.TabIndex = 10;
            backButton.Text = "חזרה";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // NewStudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(passLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(profilePictureBox);
            Controls.Add(idTextBox);
            Controls.Add(label2);
            Controls.Add(sendBtn);
            Controls.Add(degreeCmb);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "NewStudentForm";
            Text = "NewStudentForm";
            Load += NewStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox degreeCmb;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button backButton;
    }
}