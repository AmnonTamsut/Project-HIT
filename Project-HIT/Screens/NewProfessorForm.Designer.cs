namespace Project_HIT.Screens
{
    partial class NewProfessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProfessorForm));
            label1 = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            idTextBox = new System.Windows.Forms.TextBox();
            degreeCmb = new System.Windows.Forms.ComboBox();
            degreeLabel = new System.Windows.Forms.Label();
            coursesCheckBoxList = new System.Windows.Forms.CheckedListBox();
            doneBtn = new System.Windows.Forms.Button();
            profilePictureBox = new System.Windows.Forms.PictureBox();
            passLabel = new System.Windows.Forms.Label();
            passTextBox = new System.Windows.Forms.TextBox();
            backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(415, 119);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "שם:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(167, 111);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameTextBox.Size = new System.Drawing.Size(188, 23);
            nameTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(380, 73);
            idLabel.Name = "idLabel";
            idLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            idLabel.Size = new System.Drawing.Size(71, 15);
            idLabel.TabIndex = 2;
            idLabel.Text = "תעודת זהות:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new System.Drawing.Point(167, 65);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new System.Drawing.Size(188, 23);
            idTextBox.TabIndex = 0;
            // 
            // degreeCmb
            // 
            degreeCmb.FormattingEnabled = true;
            degreeCmb.Location = new System.Drawing.Point(167, 188);
            degreeCmb.Name = "degreeCmb";
            degreeCmb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            degreeCmb.Size = new System.Drawing.Size(188, 23);
            degreeCmb.TabIndex = 2;
            degreeCmb.SelectedIndexChanged += degreeCmb_SelectedIndexChanged;
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(408, 196);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new System.Drawing.Size(34, 15);
            degreeLabel.TabIndex = 5;
            degreeLabel.Text = "תואר";
            // 
            // coursesCheckBoxList
            // 
            coursesCheckBoxList.CheckOnClick = true;
            coursesCheckBoxList.FormattingEnabled = true;
            coursesCheckBoxList.Location = new System.Drawing.Point(167, 226);
            coursesCheckBoxList.Name = "coursesCheckBoxList";
            coursesCheckBoxList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            coursesCheckBoxList.Size = new System.Drawing.Size(188, 94);
            coursesCheckBoxList.TabIndex = 3;
            coursesCheckBoxList.SelectedIndexChanged += coursesCheckBoxList_SelectedIndexChanged;
            // 
            // doneBtn
            // 
            doneBtn.Location = new System.Drawing.Point(167, 362);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new System.Drawing.Size(188, 23);
            doneBtn.TabIndex = 6;
            doneBtn.Text = "סיום";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            profilePictureBox.Image = (System.Drawing.Image)resources.GetObject("profilePictureBox.Image");
            profilePictureBox.Location = new System.Drawing.Point(576, 73);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new System.Drawing.Size(128, 123);
            profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            profilePictureBox.TabIndex = 7;
            profilePictureBox.TabStop = false;
            profilePictureBox.Click += profilePictureBox_Click;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(419, 152);
            passLabel.Name = "passLabel";
            passLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            passLabel.Size = new System.Drawing.Size(42, 15);
            passLabel.TabIndex = 8;
            passLabel.Text = "סיסמה";
            // 
            // passTextBox
            // 
            passTextBox.Location = new System.Drawing.Point(167, 149);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new System.Drawing.Size(188, 23);
            passTextBox.TabIndex = 9;
            // 
            // backBtn
            // 
            backBtn.Location = new System.Drawing.Point(74, 23);
            backBtn.Name = "backBtn";
            backBtn.Size = new System.Drawing.Size(75, 23);
            backBtn.TabIndex = 10;
            backBtn.Text = "חזרה";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // NewProfessorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(passTextBox);
            Controls.Add(passLabel);
            Controls.Add(profilePictureBox);
            Controls.Add(doneBtn);
            Controls.Add(coursesCheckBoxList);
            Controls.Add(degreeCmb);
            Controls.Add(degreeLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "NewProfessorForm";
            Text = "NewProfessorForm";
            Load += NewProfessorForm_Load;
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox degreeCmb;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.CheckedListBox coursesCheckBoxList;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button backBtn;
    }
}