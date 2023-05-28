
namespace Project_HIT
{
	partial class login
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
			this.id_login_text = new System.Windows.Forms.TextBox();
			this.password_login_text = new System.Windows.Forms.TextBox();
			this.login_send = new System.Windows.Forms.Button();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.id_data = new System.Windows.Forms.TextBox();
			this.password_data = new System.Windows.Forms.TextBox();
			this.clear = new System.Windows.Forms.TextBox();
			this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
			this.SuspendLayout();
			// 
			// id_login_text
			// 
			this.id_login_text.BackColor = System.Drawing.SystemColors.Menu;
			this.id_login_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.id_login_text.Location = new System.Drawing.Point(469, 122);
			this.id_login_text.Name = "id_login_text";
			this.id_login_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.id_login_text.Size = new System.Drawing.Size(100, 16);
			this.id_login_text.TabIndex = 1;
			this.id_login_text.Text = "תעודת זהות";
			this.id_login_text.TextChanged += new System.EventHandler(this.id_login_text_TextChanged);
			// 
			// password_login_text
			// 
			this.password_login_text.BackColor = System.Drawing.SystemColors.Menu;
			this.password_login_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.password_login_text.Location = new System.Drawing.Point(469, 196);
			this.password_login_text.Name = "password_login_text";
			this.password_login_text.Size = new System.Drawing.Size(100, 16);
			this.password_login_text.TabIndex = 2;
			this.password_login_text.Text = "סיסמא";
			this.password_login_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.password_login_text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// login_send
			// 
			this.login_send.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.login_send.Location = new System.Drawing.Point(298, 287);
			this.login_send.Name = "login_send";
			this.login_send.Size = new System.Drawing.Size(271, 40);
			this.login_send.TabIndex = 4;
			this.login_send.Text = "התחבר/י";
			this.login_send.UseVisualStyleBackColor = false;
			this.login_send.Click += new System.EventHandler(this.login_send_Click);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// id_data
			// 
			this.id_data.Location = new System.Drawing.Point(298, 144);
			this.id_data.Name = "id_data";
			this.id_data.Size = new System.Drawing.Size(271, 23);
			this.id_data.TabIndex = 5;
			this.id_data.TextChanged += new System.EventHandler(this.id_data_TextChanged);
			// 
			// password_data
			// 
			this.password_data.Location = new System.Drawing.Point(298, 218);
			this.password_data.Name = "password_data";
			this.password_data.Size = new System.Drawing.Size(271, 23);
			this.password_data.TabIndex = 6;
			this.password_data.TextChanged += new System.EventHandler(this.password_data_TextChanged);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(298, 247);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(100, 23);
			this.clear.TabIndex = 8;
			this.clear.Text = "נקה/י הכל";
			this.clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.clear.TextChanged += new System.EventHandler(this.clear_TextChanged);
			// 
			// fileSystemWatcher2
			// 
			this.fileSystemWatcher2.EnableRaisingEvents = true;
			this.fileSystemWatcher2.SynchronizingObject = this;
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.password_data);
			this.Controls.Add(this.id_data);
			this.Controls.Add(this.login_send);
			this.Controls.Add(this.password_login_text);
			this.Controls.Add(this.id_login_text);
			this.Name = "login";
			this.Text = "login";
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox id_login_text;
		private System.Windows.Forms.TextBox password_login_text;
		private System.Windows.Forms.Button login_send;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.TextBox id_data;
		private System.Windows.Forms.TextBox password_data;
		private System.Windows.Forms.TextBox clear;
		private System.IO.FileSystemWatcher fileSystemWatcher2;
	}
}