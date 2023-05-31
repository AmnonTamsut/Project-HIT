namespace Project_HIT.Screens
{
    partial class StudentManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManageForm));
            studentsList = new System.Windows.Forms.ListView();
            nameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            idTextBox = new System.Windows.Forms.TextBox();
            degreeCmb = new System.Windows.Forms.ComboBox();
            backBtn = new System.Windows.Forms.Button();
            doneBtn = new System.Windows.Forms.Button();
            errorLabel = new System.Windows.Forms.Label();
            profilePicBox = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            signaturPictureBox = new System.Windows.Forms.PictureBox();
            deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)profilePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signaturPictureBox).BeginInit();
            SuspendLayout();
            // 
            // studentsList
            // 
            studentsList.HideSelection = false;
            studentsList.Location = new System.Drawing.Point(429, 57);
            studentsList.Name = "studentsList";
            studentsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            studentsList.RightToLeftLayout = true;
            studentsList.Size = new System.Drawing.Size(346, 293);
            studentsList.TabIndex = 1;
            studentsList.UseCompatibleStateImageBehavior = false;
            studentsList.SelectedIndexChanged += studentsList_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(339, 88);
            nameLabel.Name = "nameLabel";
            nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameLabel.Size = new System.Drawing.Size(24, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "שם";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(295, 139);
            idLabel.Name = "idLabel";
            idLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            idLabel.Size = new System.Drawing.Size(68, 15);
            idLabel.TabIndex = 3;
            idLabel.Text = "תעודת זהות";
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(327, 195);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            degreeLabel.Size = new System.Drawing.Size(34, 15);
            degreeLabel.TabIndex = 4;
            degreeLabel.Text = "תואר";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(123, 85);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameTextBox.Size = new System.Drawing.Size(127, 23);
            nameTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            idTextBox.Location = new System.Drawing.Point(123, 131);
            idTextBox.Name = "idTextBox";
            idTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            idTextBox.Size = new System.Drawing.Size(127, 23);
            idTextBox.TabIndex = 6;
            // 
            // degreeCmb
            // 
            degreeCmb.FormattingEnabled = true;
            degreeCmb.Location = new System.Drawing.Point(123, 187);
            degreeCmb.Name = "degreeCmb";
            degreeCmb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            degreeCmb.Size = new System.Drawing.Size(127, 23);
            degreeCmb.TabIndex = 7;
            degreeCmb.SelectedIndexChanged += degreeCmb_SelectedIndexChanged;
            // 
            // backBtn
            // 
            backBtn.Location = new System.Drawing.Point(42, 27);
            backBtn.Name = "backBtn";
            backBtn.Size = new System.Drawing.Size(75, 23);
            backBtn.TabIndex = 8;
            backBtn.Text = "חזרה";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // doneBtn
            // 
            doneBtn.Location = new System.Drawing.Point(151, 359);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new System.Drawing.Size(75, 23);
            doneBtn.TabIndex = 9;
            doneBtn.Text = "שמירה";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            errorLabel.Location = new System.Drawing.Point(77, 396);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new System.Drawing.Size(127, 15);
            errorLabel.TabIndex = 10;
            errorLabel.Text = "יש למלא את כל השדות";
            errorLabel.Click += label1_Click;
            // 
            // profilePicBox
            // 
            profilePicBox.Image = (System.Drawing.Image)resources.GetObject("profilePicBox.Image");
            profilePicBox.Location = new System.Drawing.Point(263, 235);
            profilePicBox.Name = "profilePicBox";
            profilePicBox.Size = new System.Drawing.Size(100, 106);
            profilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            profilePicBox.TabIndex = 11;
            profilePicBox.TabStop = false;
            profilePicBox.Click += profilePicBox_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            label3.Location = new System.Drawing.Point(82, 299);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(76, 29);
            label3.TabIndex = 13;
            label3.Text = "חתימה";
            // 
            // signaturPictureBox
            // 
            signaturPictureBox.Image = (System.Drawing.Image)resources.GetObject("signaturPictureBox.Image");
            signaturPictureBox.Location = new System.Drawing.Point(30, 256);
            signaturPictureBox.Name = "signaturPictureBox";
            signaturPictureBox.Size = new System.Drawing.Size(174, 72);
            signaturPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            signaturPictureBox.TabIndex = 12;
            signaturPictureBox.TabStop = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new System.Drawing.Point(267, 359);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(96, 23);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "מחיקה";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // StudentManageForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(deleteBtn);
            Controls.Add(label3);
            Controls.Add(signaturPictureBox);
            Controls.Add(profilePicBox);
            Controls.Add(errorLabel);
            Controls.Add(doneBtn);
            Controls.Add(backBtn);
            Controls.Add(degreeCmb);
            Controls.Add(idTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(degreeLabel);
            Controls.Add(idLabel);
            Controls.Add(nameLabel);
            Controls.Add(studentsList);
            Name = "StudentManageForm";
            Text = "StudentManageForm";
            Load += StudentManageForm_Load;
            ((System.ComponentModel.ISupportInitialize)profilePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)signaturPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView studentsList;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox degreeCmb;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox signaturPictureBox;
        private System.Windows.Forms.Button deleteBtn;
    }
}