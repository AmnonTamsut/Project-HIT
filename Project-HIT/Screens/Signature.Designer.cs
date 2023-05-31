
namespace Project_HIT.Screens
{
    partial class Signature
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
            clear_btn = new System.Windows.Forms.Button();
            save_signature = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)panel1).BeginInit();
            SuspendLayout();
            // 
            // clear_btn
            // 
            clear_btn.Location = new System.Drawing.Point(107, 345);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new System.Drawing.Size(176, 56);
            clear_btn.TabIndex = 1;
            clear_btn.Text = "מחק/י";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // save_signature
            // 
            save_signature.Location = new System.Drawing.Point(529, 345);
            save_signature.Name = "save_signature";
            save_signature.Size = new System.Drawing.Size(176, 56);
            save_signature.TabIndex = 2;
            save_signature.Text = "סיום";
            save_signature.UseVisualStyleBackColor = true;
            save_signature.Click += save_signature_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(148, 84);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(472, 210);
            panel1.TabIndex = 3;
            panel1.TabStop = false;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // Signature
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(save_signature);
            Controls.Add(clear_btn);
            Name = "Signature";
            Text = "Signature";
            Load += Signature_Load;
            ((System.ComponentModel.ISupportInitialize)panel1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button save_signature;
        private System.Windows.Forms.PictureBox panel1;
    }
}