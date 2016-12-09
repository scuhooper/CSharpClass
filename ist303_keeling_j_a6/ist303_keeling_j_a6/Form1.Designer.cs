namespace ist303_keeling_j_a6
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
			this.lstToDoList = new System.Windows.Forms.ListBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.txtActivityName = new System.Windows.Forms.TextBox();
			this.btnAddActivity = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnRemoveActivity = new System.Windows.Forms.Button();
			this.btnDateSort = new System.Windows.Forms.Button();
			this.btnNameSort = new System.Windows.Forms.Button();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblActivityName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstToDoList
			// 
			this.lstToDoList.FormattingEnabled = true;
			this.lstToDoList.Location = new System.Drawing.Point(12, 12);
			this.lstToDoList.Name = "lstToDoList";
			this.lstToDoList.Size = new System.Drawing.Size(200, 251);
			this.lstToDoList.TabIndex = 0;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(111, 279);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 1;
			// 
			// txtActivityName
			// 
			this.txtActivityName.Location = new System.Drawing.Point(111, 306);
			this.txtActivityName.Name = "txtActivityName";
			this.txtActivityName.Size = new System.Drawing.Size(200, 20);
			this.txtActivityName.TabIndex = 2;
			// 
			// btnAddActivity
			// 
			this.btnAddActivity.Location = new System.Drawing.Point(111, 332);
			this.btnAddActivity.Name = "btnAddActivity";
			this.btnAddActivity.Size = new System.Drawing.Size(91, 34);
			this.btnAddActivity.TabIndex = 3;
			this.btnAddActivity.Text = "&Add Activity";
			this.btnAddActivity.UseVisualStyleBackColor = true;
			// 
			// btnQuit
			// 
			this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnQuit.Location = new System.Drawing.Point(221, 332);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(90, 34);
			this.btnQuit.TabIndex = 7;
			this.btnQuit.Text = "&Quit";
			this.btnQuit.UseVisualStyleBackColor = true;
			// 
			// btnRemoveActivity
			// 
			this.btnRemoveActivity.Location = new System.Drawing.Point(219, 13);
			this.btnRemoveActivity.Name = "btnRemoveActivity";
			this.btnRemoveActivity.Size = new System.Drawing.Size(92, 35);
			this.btnRemoveActivity.TabIndex = 4;
			this.btnRemoveActivity.Text = "&Remove Activity";
			this.btnRemoveActivity.UseVisualStyleBackColor = true;
			// 
			// btnDateSort
			// 
			this.btnDateSort.Location = new System.Drawing.Point(219, 54);
			this.btnDateSort.Name = "btnDateSort";
			this.btnDateSort.Size = new System.Drawing.Size(92, 35);
			this.btnDateSort.TabIndex = 5;
			this.btnDateSort.Text = "Sort by &Date";
			this.btnDateSort.UseVisualStyleBackColor = true;
			// 
			// btnNameSort
			// 
			this.btnNameSort.Location = new System.Drawing.Point(219, 95);
			this.btnNameSort.Name = "btnNameSort";
			this.btnNameSort.Size = new System.Drawing.Size(92, 35);
			this.btnNameSort.TabIndex = 6;
			this.btnNameSort.Text = "Sort by &Name";
			this.btnNameSort.UseVisualStyleBackColor = true;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(75, 285);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(30, 13);
			this.lblDate.TabIndex = 8;
			this.lblDate.Text = "Date";
			// 
			// lblActivityName
			// 
			this.lblActivityName.AutoSize = true;
			this.lblActivityName.Location = new System.Drawing.Point(33, 309);
			this.lblActivityName.Name = "lblActivityName";
			this.lblActivityName.Size = new System.Drawing.Size(72, 13);
			this.lblActivityName.TabIndex = 9;
			this.lblActivityName.Text = "Activity Name";
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnAddActivity;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnQuit;
			this.ClientSize = new System.Drawing.Size(322, 375);
			this.Controls.Add(this.lblActivityName);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.btnNameSort);
			this.Controls.Add(this.btnDateSort);
			this.Controls.Add(this.btnRemoveActivity);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnAddActivity);
			this.Controls.Add(this.txtActivityName);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.lstToDoList);
			this.Name = "frmMain";
			this.Text = "To-Do-List";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstToDoList;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txtActivityName;
		private System.Windows.Forms.Button btnAddActivity;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Button btnRemoveActivity;
		private System.Windows.Forms.Button btnDateSort;
		private System.Windows.Forms.Button btnNameSort;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblActivityName;
	}
}

