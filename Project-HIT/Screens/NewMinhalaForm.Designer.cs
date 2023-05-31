namespace Project_HIT.Screens
{
    partial class NewMinhalaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMinhalaForm));
            nameLabel = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            idTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            passTextBox = new System.Windows.Forms.TextBox();
            doneBtn = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            backBtn = new System.Windows.Forms.Button();
            errorDoneBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(445, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameLabel.Size = new System.Drawing.Size(24, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "שם";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(146, 85);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameTextBox.Size = new System.Drawing.Size(209, 23);
            nameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            idTextBox.Location = new System.Drawing.Point(146, 144);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new System.Drawing.Size(209, 23);
            idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(431, 147);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(68, 15);
            idLabel.TabIndex = 3;
            idLabel.Text = "תעודת זהות";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(445, 200);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "סיסמה";
            // 
            // passTextBox
            // 
            passTextBox.Location = new System.Drawing.Point(146, 197);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new System.Drawing.Size(209, 23);
            passTextBox.TabIndex = 5;
            // 
            // doneBtn
            // 
            doneBtn.Location = new System.Drawing.Point(211, 296);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new System.Drawing.Size(75, 23);
            doneBtn.TabIndex = 6;
            doneBtn.Text = "סיום";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(610, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 114);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new System.Drawing.Point(65, 35);
            backBtn.Name = "backBtn";
            backBtn.Size = new System.Drawing.Size(75, 23);
            backBtn.TabIndex = 8;
            backBtn.Text = "חזרה";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // errorDoneBtn
            // 
            errorDoneBtn.AutoSize = true;
            errorDoneBtn.ForeColor = System.Drawing.Color.IndianRed;
            errorDoneBtn.Location = new System.Drawing.Point(159, 339);
            errorDoneBtn.Name = "errorDoneBtn";
            errorDoneBtn.Size = new System.Drawing.Size(127, 15);
            errorDoneBtn.TabIndex = 9;
            errorDoneBtn.Text = "יש למלא את כל השדות";
            // 
            // NewMinhalaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(errorDoneBtn);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(doneBtn);
            Controls.Add(passTextBox);
            Controls.Add(label1);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "NewMinhalaForm";
            Text = "NewMinhalaForm";
            Load += NewMinhalaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label errorDoneBtn;
    }
}