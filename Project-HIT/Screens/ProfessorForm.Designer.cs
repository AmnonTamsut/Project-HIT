
namespace Project_HIT.Screens
{
    partial class ProfessorForm
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
            components = new System.ComponentModel.Container();
            welcomeNameLabel = new System.Windows.Forms.Label();
            ProfessorProfilePictue = new System.Windows.Forms.PictureBox();
            Professor_signatue_picturebox = new System.Windows.Forms.PictureBox();
            schoolMainBindingSource = new System.Windows.Forms.BindingSource(components);
            professor_list = new System.Windows.Forms.ListView();
            students_grades_view = new System.Windows.Forms.ListView();
            back_to_courses_label = new System.Windows.Forms.Label();
            update_grade_text = new System.Windows.Forms.Label();
            update_grade_textbox = new System.Windows.Forms.TextBox();
            update_grade_button = new System.Windows.Forms.Button();
            logout = new System.Windows.Forms.Button();
            errorlabelUpdater = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)ProfessorProfilePictue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Professor_signatue_picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schoolMainBindingSource).BeginInit();
            SuspendLayout();
            // 
            // welcomeNameLabel
            // 
            welcomeNameLabel.AutoSize = true;
            welcomeNameLabel.Location = new System.Drawing.Point(654, 55);
            welcomeNameLabel.Name = "welcomeNameLabel";
            welcomeNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            welcomeNameLabel.Size = new System.Drawing.Size(54, 15);
            welcomeNameLabel.TabIndex = 3;
            welcomeNameLabel.Text = "שלום שם";
            // 
            // ProfessorProfilePictue
            // 
            ProfessorProfilePictue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ProfessorProfilePictue.Location = new System.Drawing.Point(611, 93);
            ProfessorProfilePictue.Name = "ProfessorProfilePictue";
            ProfessorProfilePictue.Size = new System.Drawing.Size(132, 128);
            ProfessorProfilePictue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ProfessorProfilePictue.TabIndex = 4;
            ProfessorProfilePictue.TabStop = false;
            ProfessorProfilePictue.Click += ProfessorProfilePictue_Click;
            // 
            // Professor_signatue_picturebox
            // 
            Professor_signatue_picturebox.BackColor = System.Drawing.Color.FromArgb(1, 130, 135);
            Professor_signatue_picturebox.Location = new System.Drawing.Point(562, 256);
            Professor_signatue_picturebox.Name = "Professor_signatue_picturebox";
            Professor_signatue_picturebox.Size = new System.Drawing.Size(210, 105);
            Professor_signatue_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Professor_signatue_picturebox.TabIndex = 5;
            Professor_signatue_picturebox.TabStop = false;
            Professor_signatue_picturebox.Click += Professor_signatue_picturebox_Click;
            // 
            // schoolMainBindingSource
            // 
            schoolMainBindingSource.DataSource = typeof(SchoolMain);
            // 
            // professor_list
            // 
            professor_list.HideSelection = false;
            professor_list.Location = new System.Drawing.Point(12, 55);
            professor_list.Name = "professor_list";
            professor_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            professor_list.RightToLeftLayout = true;
            professor_list.Size = new System.Drawing.Size(488, 306);
            professor_list.TabIndex = 7;
            professor_list.UseCompatibleStateImageBehavior = false;
            professor_list.SelectedIndexChanged += professor_list_SelectedIndexChanged;
            professor_list.DoubleClick += professor_list_DoubleClick;
            // 
            // students_grades_view
            // 
            students_grades_view.HideSelection = false;
            students_grades_view.Location = new System.Drawing.Point(12, 55);
            students_grades_view.Name = "students_grades_view";
            students_grades_view.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            students_grades_view.RightToLeftLayout = true;
            students_grades_view.Size = new System.Drawing.Size(488, 306);
            students_grades_view.TabIndex = 8;
            students_grades_view.UseCompatibleStateImageBehavior = false;
            students_grades_view.SelectedIndexChanged += students_grades_view_SelectedIndexChanged;
            students_grades_view.DoubleClick += students_grades_view_DoubleClick;
            // 
            // back_to_courses_label
            // 
            back_to_courses_label.AutoSize = true;
            back_to_courses_label.BackColor = System.Drawing.Color.Teal;
            back_to_courses_label.Cursor = System.Windows.Forms.Cursors.Hand;
            back_to_courses_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            back_to_courses_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            back_to_courses_label.Location = new System.Drawing.Point(59, 326);
            back_to_courses_label.Name = "back_to_courses_label";
            back_to_courses_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            back_to_courses_label.Size = new System.Drawing.Size(98, 15);
            back_to_courses_label.TabIndex = 9;
            back_to_courses_label.Text = "לרשימת הקורסים";
            back_to_courses_label.Click += back_to_courses_label_Click;
            // 
            // update_grade_text
            // 
            update_grade_text.AutoSize = true;
            update_grade_text.Location = new System.Drawing.Point(266, 152);
            update_grade_text.Name = "update_grade_text";
            update_grade_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            update_grade_text.Size = new System.Drawing.Size(68, 15);
            update_grade_text.TabIndex = 10;
            update_grade_text.Text = "הציון החדש:";
            // 
            // update_grade_textbox
            // 
            update_grade_textbox.Location = new System.Drawing.Point(161, 180);
            update_grade_textbox.Name = "update_grade_textbox";
            update_grade_textbox.Size = new System.Drawing.Size(270, 23);
            update_grade_textbox.TabIndex = 11;
            update_grade_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            update_grade_textbox.TextChanged += update_grade_textbox_TextChanged;
            // 
            // update_grade_button
            // 
            update_grade_button.Location = new System.Drawing.Point(259, 209);
            update_grade_button.Name = "update_grade_button";
            update_grade_button.Size = new System.Drawing.Size(75, 23);
            update_grade_button.TabIndex = 12;
            update_grade_button.Text = "עדכון";
            update_grade_button.UseVisualStyleBackColor = true;
            update_grade_button.Click += update_grade_button_Click;
            // 
            // logout
            // 
            logout.Location = new System.Drawing.Point(201, 19);
            logout.Name = "logout";
            logout.Size = new System.Drawing.Size(75, 23);
            logout.TabIndex = 13;
            logout.Text = "להתנתק";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // errorlabelUpdater
            // 
            errorlabelUpdater.AutoSize = true;
            errorlabelUpdater.BackColor = System.Drawing.Color.Transparent;
            errorlabelUpdater.ForeColor = System.Drawing.Color.IndianRed;
            errorlabelUpdater.Location = new System.Drawing.Point(238, 235);
            errorlabelUpdater.Name = "errorlabelUpdater";
            errorlabelUpdater.Size = new System.Drawing.Size(71, 15);
            errorlabelUpdater.TabIndex = 14;
            errorlabelUpdater.Text = "יש למלא ציון";
            // 
            // ProfessorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(errorlabelUpdater);
            Controls.Add(logout);
            Controls.Add(update_grade_button);
            Controls.Add(update_grade_textbox);
            Controls.Add(update_grade_text);
            Controls.Add(back_to_courses_label);
            Controls.Add(Professor_signatue_picturebox);
            Controls.Add(ProfessorProfilePictue);
            Controls.Add(welcomeNameLabel);
            Controls.Add(students_grades_view);
            Controls.Add(professor_list);
            Name = "ProfessorForm";
            Text = "ProfessorForm";
            Load += ProfessorForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProfessorProfilePictue).EndInit();
            ((System.ComponentModel.ISupportInitialize)Professor_signatue_picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)schoolMainBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label welcomeNameLabel;
        private System.Windows.Forms.PictureBox ProfessorProfilePictue;
        private System.Windows.Forms.PictureBox Professor_signatue_picturebox;
        private System.Windows.Forms.BindingSource schoolMainBindingSource;
        private System.Windows.Forms.ListView professor_list;
        private System.Windows.Forms.ListView students_grades_view;
        private System.Windows.Forms.Label back_to_courses_label;
        private System.Windows.Forms.Label update_grade_text;
        private System.Windows.Forms.TextBox update_grade_textbox;
        private System.Windows.Forms.Button update_grade_button;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label errorlabelUpdater;
    }
}