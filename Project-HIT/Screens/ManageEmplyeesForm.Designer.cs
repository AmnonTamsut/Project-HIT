namespace Project_HIT.Screens
{
    partial class ManageEmplyeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmplyeesForm));
            workerList = new System.Windows.Forms.ListView();
            nameLabel = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            idTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            salaryTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            profilePictureBox = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            employeeWokerId = new System.Windows.Forms.Label();
            signaturPictureBox = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            doneBtn = new System.Windows.Forms.Button();
            errorLabel = new System.Windows.Forms.Label();
            backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signaturPictureBox).BeginInit();
            SuspendLayout();
            // 
            // workerList
            // 
            workerList.HideSelection = false;
            workerList.Location = new System.Drawing.Point(480, 65);
            workerList.MultiSelect = false;
            workerList.Name = "workerList";
            workerList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            workerList.RightToLeftLayout = true;
            workerList.Size = new System.Drawing.Size(256, 293);
            workerList.TabIndex = 0;
            workerList.UseCompatibleStateImageBehavior = false;
            workerList.SelectedIndexChanged += workerList_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(288, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(24, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "שם";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(104, 57);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameTextBox.Size = new System.Drawing.Size(100, 23);
            nameTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            idTextBox.Location = new System.Drawing.Point(104, 109);
            idTextBox.Name = "idTextBox";
            idTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            idTextBox.Size = new System.Drawing.Size(100, 23);
            idTextBox.TabIndex = 4;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(274, 117);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(68, 15);
            idLabel.TabIndex = 3;
            idLabel.Text = "תעודת זהות";
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new System.Drawing.Point(104, 168);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            salaryTextBox.Size = new System.Drawing.Size(100, 23);
            salaryTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(288, 176);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "שכר";
            // 
            // profilePictureBox
            // 
            profilePictureBox.Image = (System.Drawing.Image)resources.GetObject("profilePictureBox.Image");
            profilePictureBox.Location = new System.Drawing.Point(259, 217);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new System.Drawing.Size(100, 101);
            profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            profilePictureBox.TabIndex = 7;
            profilePictureBox.TabStop = false;
            profilePictureBox.Click += profilePictureBox_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(274, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "מספר עובד";
            // 
            // employeeWokerId
            // 
            employeeWokerId.AutoSize = true;
            employeeWokerId.Location = new System.Drawing.Point(138, 21);
            employeeWokerId.Name = "employeeWokerId";
            employeeWokerId.Size = new System.Drawing.Size(35, 15);
            employeeWokerId.TabIndex = 9;
            employeeWokerId.Text = "####";
            // 
            // signaturPictureBox
            // 
            signaturPictureBox.Location = new System.Drawing.Point(30, 235);
            signaturPictureBox.Name = "signaturPictureBox";
            signaturPictureBox.Size = new System.Drawing.Size(174, 72);
            signaturPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            signaturPictureBox.TabIndex = 10;
            signaturPictureBox.TabStop = false;
            signaturPictureBox.Click += signaturPictureBox_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            label3.Location = new System.Drawing.Point(82, 278);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(76, 29);
            label3.TabIndex = 11;
            label3.Text = "חתימה";
            // 
            // doneBtn
            // 
            doneBtn.Location = new System.Drawing.Point(129, 379);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new System.Drawing.Size(75, 23);
            doneBtn.TabIndex = 12;
            doneBtn.Text = "עדכון";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            errorLabel.Location = new System.Drawing.Point(72, 405);
            errorLabel.Name = "errorLabel";
            errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            errorLabel.Size = new System.Drawing.Size(146, 15);
            errorLabel.TabIndex = 13;
            errorLabel.Text = "כדי לעדכן יש לבחור עובד/ת";
            // 
            // backBtn
            // 
            backBtn.Location = new System.Drawing.Point(12, 21);
            backBtn.Name = "backBtn";
            backBtn.Size = new System.Drawing.Size(75, 23);
            backBtn.TabIndex = 14;
            backBtn.Text = "חזרה";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // ManageEmplyeesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(errorLabel);
            Controls.Add(doneBtn);
            Controls.Add(label3);
            Controls.Add(signaturPictureBox);
            Controls.Add(employeeWokerId);
            Controls.Add(label2);
            Controls.Add(profilePictureBox);
            Controls.Add(salaryTextBox);
            Controls.Add(label1);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(workerList);
            Name = "ManageEmplyeesForm";
            Text = "ManageEmplyeesForm";
            Load += ManageEmplyeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)signaturPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView workerList;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label employeeWokerId;
        private System.Windows.Forms.PictureBox signaturPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button backBtn;
    }
}