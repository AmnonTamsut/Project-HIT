
namespace Project_HIT
{
    partial class MinhalaForm
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
            name_label = new System.Windows.Forms.Label();
            addStudentbtn = new System.Windows.Forms.Button();
            newProfBtn = new System.Windows.Forms.Button();
            newMinhala = new System.Windows.Forms.Button();
            manageWorkersBtn = new System.Windows.Forms.Button();
            manageStudentsBtn = new System.Windows.Forms.Button();
            logoutBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new System.Drawing.Point(671, 63);
            name_label.Name = "name_label";
            name_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            name_label.Size = new System.Drawing.Size(57, 15);
            name_label.TabIndex = 0;
            name_label.Text = "שלום: שם";
            // 
            // addStudentbtn
            // 
            addStudentbtn.Location = new System.Drawing.Point(453, 154);
            addStudentbtn.Name = "addStudentbtn";
            addStudentbtn.Size = new System.Drawing.Size(165, 23);
            addStudentbtn.TabIndex = 1;
            addStudentbtn.Text = "רישום סטודנט\\ית חדש\\ה";
            addStudentbtn.UseVisualStyleBackColor = true;
            addStudentbtn.Click += addStudentbtn_Click;
            // 
            // newProfBtn
            // 
            newProfBtn.Location = new System.Drawing.Point(293, 154);
            newProfBtn.Name = "newProfBtn";
            newProfBtn.Size = new System.Drawing.Size(154, 23);
            newProfBtn.TabIndex = 2;
            newProfBtn.Text = "רישום מרצה חדש\\ה";
            newProfBtn.UseVisualStyleBackColor = true;
            newProfBtn.Click += newProfBtn_Click_1;
            // 
            // newMinhala
            // 
            newMinhala.Location = new System.Drawing.Point(122, 154);
            newMinhala.Name = "newMinhala";
            newMinhala.Size = new System.Drawing.Size(165, 23);
            newMinhala.TabIndex = 3;
            newMinhala.Text = "עובד\\ת מנהלה חדש\\ה";
            newMinhala.UseVisualStyleBackColor = true;
            newMinhala.Click += newMinhala_Click;
            // 
            // manageWorkersBtn
            // 
            manageWorkersBtn.Location = new System.Drawing.Point(122, 205);
            manageWorkersBtn.Name = "manageWorkersBtn";
            manageWorkersBtn.Size = new System.Drawing.Size(165, 23);
            manageWorkersBtn.TabIndex = 4;
            manageWorkersBtn.Text = "ניהול עובדים";
            manageWorkersBtn.UseVisualStyleBackColor = true;
            manageWorkersBtn.Click += manageWorkersBtn_Click;
            // 
            // manageStudentsBtn
            // 
            manageStudentsBtn.Location = new System.Drawing.Point(453, 205);
            manageStudentsBtn.Name = "manageStudentsBtn";
            manageStudentsBtn.Size = new System.Drawing.Size(165, 23);
            manageStudentsBtn.TabIndex = 5;
            manageStudentsBtn.Text = "ניהול סטודנטים\\יות";
            manageStudentsBtn.UseVisualStyleBackColor = true;
            manageStudentsBtn.Click += manageStudentsBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new System.Drawing.Point(25, 25);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new System.Drawing.Size(75, 23);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "התנתק\\י";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // MinhalaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(logoutBtn);
            Controls.Add(manageStudentsBtn);
            Controls.Add(manageWorkersBtn);
            Controls.Add(newMinhala);
            Controls.Add(newProfBtn);
            Controls.Add(addStudentbtn);
            Controls.Add(name_label);
            Name = "MinhalaForm";
            Text = "Mihala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button addStudentbtn;
        private System.Windows.Forms.Button newProfBtn;
        private System.Windows.Forms.Button newMinhala;
        private System.Windows.Forms.Button manageWorkersBtn;
        private System.Windows.Forms.Button manageStudentsBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}