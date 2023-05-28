
namespace Project_HIT
{
    partial class MihalaForm
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
            // MihalaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(name_label);
            Name = "MihalaForm";
            Text = "Mihala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label name_label;
    }
}