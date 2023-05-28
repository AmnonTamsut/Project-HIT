
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
			this.clear_btn = new System.Windows.Forms.Button();
			this.save_signature = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
			this.SuspendLayout();
			// 
			// clear_btn
			// 
			this.clear_btn.Location = new System.Drawing.Point(107, 345);
			this.clear_btn.Name = "clear_btn";
			this.clear_btn.Size = new System.Drawing.Size(176, 56);
			this.clear_btn.TabIndex = 1;
			this.clear_btn.Text = "מחק/י";
			this.clear_btn.UseVisualStyleBackColor = true;
			this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
			// 
			// save_signature
			// 
			this.save_signature.Location = new System.Drawing.Point(529, 345);
			this.save_signature.Name = "save_signature";
			this.save_signature.Size = new System.Drawing.Size(176, 56);
			this.save_signature.TabIndex = 2;
			this.save_signature.Text = "סיום";
			this.save_signature.UseVisualStyleBackColor = true;
			this.save_signature.Click += new System.EventHandler(this.save_signature_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(148, 84);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(472, 210);
			this.panel1.TabIndex = 3;
			this.panel1.TabStop = false;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// Signature
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.save_signature);
			this.Controls.Add(this.clear_btn);
			this.Name = "Signature";
			this.Text = "Signature";
			((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button clear_btn;
		private System.Windows.Forms.Button save_signature;
		private System.Windows.Forms.PictureBox panel1;
	}
}