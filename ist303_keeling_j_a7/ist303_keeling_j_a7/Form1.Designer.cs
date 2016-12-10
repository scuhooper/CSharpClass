namespace ist303_keeling_j_a7
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtFileList = new System.Windows.Forms.RichTextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.chkSubdirectories = new System.Windows.Forms.CheckBox();
			this.btnQuit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtFileList
			// 
			this.txtFileList.Location = new System.Drawing.Point(13, 14);
			this.txtFileList.Name = "txtFileList";
			this.txtFileList.Size = new System.Drawing.Size(606, 429);
			this.txtFileList.TabIndex = 0;
			this.txtFileList.Text = "";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(13, 449);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(94, 45);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "&Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// chkSubdirectories
			// 
			this.chkSubdirectories.AutoSize = true;
			this.chkSubdirectories.Location = new System.Drawing.Point(113, 464);
			this.chkSubdirectories.Name = "chkSubdirectories";
			this.chkSubdirectories.Size = new System.Drawing.Size(195, 17);
			this.chkSubdirectories.TabIndex = 2;
			this.chkSubdirectories.Text = "Include &Subdirectories and Folders?";
			this.chkSubdirectories.UseVisualStyleBackColor = true;
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(525, 449);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(94, 45);
			this.btnQuit.TabIndex = 3;
			this.btnQuit.Text = "&Quit";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnBrowse;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnQuit;
			this.ClientSize = new System.Drawing.Size(631, 504);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.chkSubdirectories);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFileList);
			this.Name = "frmMain";
			this.Text = "Directory Displayer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtFileList;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.CheckBox chkSubdirectories;
		private System.Windows.Forms.Button btnQuit;
	}
}

