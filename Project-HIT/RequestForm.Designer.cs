namespace Project_HIT.Screens
{
    partial class RequestForm
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
            label1 = new System.Windows.Forms.Label();
            lecturerCmb = new System.Windows.Forms.ComboBox();
            subjetTitle = new System.Windows.Forms.Label();
            subjectText = new System.Windows.Forms.TextBox();
            contentTxtBox = new System.Windows.Forms.RichTextBox();
            contentTitle = new System.Windows.Forms.Label();
            submitBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(279, 21);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "מרצה";
            // 
            // lecturerCmb
            // 
            lecturerCmb.FormattingEnabled = true;
            lecturerCmb.Location = new System.Drawing.Point(132, 19);
            lecturerCmb.Margin = new System.Windows.Forms.Padding(2);
            lecturerCmb.Name = "lecturerCmb";
            lecturerCmb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lecturerCmb.Size = new System.Drawing.Size(129, 23);
            lecturerCmb.TabIndex = 1;
            lecturerCmb.SelectedIndexChanged += lecturerCmb_SelectedIndexChanged;
            lecturerCmb.Leave += lecturerCmb_Leave;
            // 
            // subjetTitle
            // 
            subjetTitle.AutoSize = true;
            subjetTitle.Location = new System.Drawing.Point(284, 55);
            subjetTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            subjetTitle.Name = "subjetTitle";
            subjetTitle.Size = new System.Drawing.Size(32, 15);
            subjetTitle.TabIndex = 2;
            subjetTitle.Text = "נושא";
            // 
            // subjectText
            // 
            subjectText.Location = new System.Drawing.Point(18, 55);
            subjectText.Margin = new System.Windows.Forms.Padding(2);
            subjectText.Name = "subjectText";
            subjectText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            subjectText.Size = new System.Drawing.Size(242, 23);
            subjectText.TabIndex = 3;
            subjectText.Leave += subjectText_Leave;
            // 
            // contentTxtBox
            // 
            contentTxtBox.Location = new System.Drawing.Point(18, 113);
            contentTxtBox.Margin = new System.Windows.Forms.Padding(2);
            contentTxtBox.Name = "contentTxtBox";
            contentTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            contentTxtBox.Size = new System.Drawing.Size(299, 196);
            contentTxtBox.TabIndex = 4;
            contentTxtBox.Text = "";
            contentTxtBox.Leave += contentTxtBox_Leave;
            // 
            // contentTitle
            // 
            contentTitle.AutoSize = true;
            contentTitle.Location = new System.Drawing.Point(284, 91);
            contentTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contentTitle.Name = "contentTitle";
            contentTitle.Size = new System.Drawing.Size(29, 15);
            contentTitle.TabIndex = 5;
            contentTitle.Text = "תוכן";
            // 
            // submitBtn
            // 
            submitBtn.Location = new System.Drawing.Point(18, 326);
            submitBtn.Margin = new System.Windows.Forms.Padding(2);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new System.Drawing.Size(78, 20);
            submitBtn.TabIndex = 6;
            submitBtn.Text = "שליחה";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(337, 360);
            Controls.Add(submitBtn);
            Controls.Add(contentTitle);
            Controls.Add(contentTxtBox);
            Controls.Add(subjectText);
            Controls.Add(subjetTitle);
            Controls.Add(lecturerCmb);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "RequestForm";
            Text = "טופס פנייה";
            FormClosing += RequestForm_FormClosing;
            Load += RequestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lecturerCmb;
        private System.Windows.Forms.Label subjetTitle;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.RichTextBox contentTxtBox;
        private System.Windows.Forms.Label contentTitle;
        private System.Windows.Forms.Button submitBtn;
    }
}