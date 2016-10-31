namespace ist303_keeling_j_a5
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlTitleScreen = new System.Windows.Forms.Panel();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.pnlGame = new System.Windows.Forms.Panel();
			this.lblError = new System.Windows.Forms.Label();
			this.lblSecretWord = new System.Windows.Forms.Label();
			this.lblLeftLeg = new System.Windows.Forms.Label();
			this.lblRightLeg = new System.Windows.Forms.Label();
			this.lblRightArm = new System.Windows.Forms.Label();
			this.lblLeftArm = new System.Windows.Forms.Label();
			this.lblBody = new System.Windows.Forms.Label();
			this.lblHead = new System.Windows.Forms.Label();
			this.lblNoose = new System.Windows.Forms.Label();
			this.btnSubmitGuess = new System.Windows.Forms.Button();
			this.lblGuess = new System.Windows.Forms.Label();
			this.mtxtGuess = new System.Windows.Forms.MaskedTextBox();
			this.lblHistory = new System.Windows.Forms.Label();
			this.lblLettersGuessed = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.pnlTitleScreen.SuspendLayout();
			this.pnlGame.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Old English Text MT", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(215, 16);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(253, 65);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Hangman";
			// 
			// pnlTitleScreen
			// 
			this.pnlTitleScreen.Controls.Add(this.btnPlay);
			this.pnlTitleScreen.Controls.Add(this.lblTitle);
			this.pnlTitleScreen.Location = new System.Drawing.Point(13, 12);
			this.pnlTitleScreen.Name = "pnlTitleScreen";
			this.pnlTitleScreen.Size = new System.Drawing.Size(682, 698);
			this.pnlTitleScreen.TabIndex = 1;
			// 
			// btnPlay
			// 
			this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlay.Location = new System.Drawing.Point(294, 222);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(99, 39);
			this.btnPlay.TabIndex = 1;
			this.btnPlay.Text = "&Play!!";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnQuit
			// 
			this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuit.Location = new System.Drawing.Point(598, 716);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(99, 39);
			this.btnQuit.TabIndex = 2;
			this.btnQuit.TabStop = false;
			this.btnQuit.Text = "&Quit";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// pnlGame
			// 
			this.pnlGame.Controls.Add(this.btnReset);
			this.pnlGame.Controls.Add(this.lblError);
			this.pnlGame.Controls.Add(this.lblSecretWord);
			this.pnlGame.Controls.Add(this.lblLeftLeg);
			this.pnlGame.Controls.Add(this.lblRightLeg);
			this.pnlGame.Controls.Add(this.lblRightArm);
			this.pnlGame.Controls.Add(this.lblLeftArm);
			this.pnlGame.Controls.Add(this.lblBody);
			this.pnlGame.Controls.Add(this.lblHead);
			this.pnlGame.Controls.Add(this.lblNoose);
			this.pnlGame.Controls.Add(this.btnSubmitGuess);
			this.pnlGame.Controls.Add(this.lblGuess);
			this.pnlGame.Controls.Add(this.mtxtGuess);
			this.pnlGame.Controls.Add(this.lblHistory);
			this.pnlGame.Controls.Add(this.lblLettersGuessed);
			this.pnlGame.Location = new System.Drawing.Point(44, 40);
			this.pnlGame.Name = "pnlGame";
			this.pnlGame.Size = new System.Drawing.Size(621, 667);
			this.pnlGame.TabIndex = 3;
			this.pnlGame.Visible = false;
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(192, 458);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(46, 18);
			this.lblError.TabIndex = 14;
			this.lblError.Text = "label1";
			this.lblError.Visible = false;
			// 
			// lblSecretWord
			// 
			this.lblSecretWord.AutoSize = true;
			this.lblSecretWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSecretWord.Location = new System.Drawing.Point(228, 272);
			this.lblSecretWord.Name = "lblSecretWord";
			this.lblSecretWord.Size = new System.Drawing.Size(164, 31);
			this.lblSecretWord.TabIndex = 13;
			this.lblSecretWord.Text = "Secret Word";
			// 
			// lblLeftLeg
			// 
			this.lblLeftLeg.AutoSize = true;
			this.lblLeftLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLeftLeg.Location = new System.Drawing.Point(338, 104);
			this.lblLeftLeg.Name = "lblLeftLeg";
			this.lblLeftLeg.Size = new System.Drawing.Size(12, 18);
			this.lblLeftLeg.TabIndex = 12;
			this.lblLeftLeg.Text = "/";
			this.lblLeftLeg.Visible = false;
			// 
			// lblRightLeg
			// 
			this.lblRightLeg.AutoSize = true;
			this.lblRightLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRightLeg.Location = new System.Drawing.Point(352, 104);
			this.lblRightLeg.Name = "lblRightLeg";
			this.lblRightLeg.Size = new System.Drawing.Size(12, 18);
			this.lblRightLeg.TabIndex = 11;
			this.lblRightLeg.Text = "\\";
			this.lblRightLeg.Visible = false;
			// 
			// lblRightArm
			// 
			this.lblRightArm.AutoSize = true;
			this.lblRightArm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRightArm.Location = new System.Drawing.Point(354, 70);
			this.lblRightArm.Name = "lblRightArm";
			this.lblRightArm.Size = new System.Drawing.Size(12, 18);
			this.lblRightArm.TabIndex = 10;
			this.lblRightArm.Text = "\\";
			this.lblRightArm.Visible = false;
			// 
			// lblLeftArm
			// 
			this.lblLeftArm.AutoSize = true;
			this.lblLeftArm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLeftArm.Location = new System.Drawing.Point(337, 70);
			this.lblLeftArm.Name = "lblLeftArm";
			this.lblLeftArm.Size = new System.Drawing.Size(12, 18);
			this.lblLeftArm.TabIndex = 9;
			this.lblLeftArm.Text = "/";
			this.lblLeftArm.Visible = false;
			// 
			// lblBody
			// 
			this.lblBody.AutoSize = true;
			this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBody.Location = new System.Drawing.Point(345, 68);
			this.lblBody.Name = "lblBody";
			this.lblBody.Size = new System.Drawing.Size(13, 36);
			this.lblBody.TabIndex = 8;
			this.lblBody.Text = "|\r\n|";
			this.lblBody.Visible = false;
			// 
			// lblHead
			// 
			this.lblHead.AutoSize = true;
			this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHead.Location = new System.Drawing.Point(341, 53);
			this.lblHead.Name = "lblHead";
			this.lblHead.Size = new System.Drawing.Size(20, 18);
			this.lblHead.TabIndex = 7;
			this.lblHead.Text = "O";
			this.lblHead.Visible = false;
			// 
			// lblNoose
			// 
			this.lblNoose.AutoSize = true;
			this.lblNoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoose.Location = new System.Drawing.Point(255, 16);
			this.lblNoose.Name = "lblNoose";
			this.lblNoose.Size = new System.Drawing.Size(102, 162);
			this.lblNoose.TabIndex = 6;
			this.lblNoose.Text = "      ________\r\n      |               |\r\n      |\r\n      |\r\n      |\r\n      |\r\n    " +
    "  |\r\n      |\r\n___|___";
			// 
			// btnSubmitGuess
			// 
			this.btnSubmitGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitGuess.Location = new System.Drawing.Point(329, 394);
			this.btnSubmitGuess.Name = "btnSubmitGuess";
			this.btnSubmitGuess.Size = new System.Drawing.Size(75, 23);
			this.btnSubmitGuess.TabIndex = 5;
			this.btnSubmitGuess.Text = "Submit";
			this.btnSubmitGuess.UseVisualStyleBackColor = true;
			this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
			// 
			// lblGuess
			// 
			this.lblGuess.AutoSize = true;
			this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGuess.Location = new System.Drawing.Point(216, 396);
			this.lblGuess.Name = "lblGuess";
			this.lblGuess.Size = new System.Drawing.Size(56, 18);
			this.lblGuess.TabIndex = 4;
			this.lblGuess.Text = "Guess:";
			// 
			// mtxtGuess
			// 
			this.mtxtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtGuess.Location = new System.Drawing.Point(278, 393);
			this.mtxtGuess.Mask = "L";
			this.mtxtGuess.Name = "mtxtGuess";
			this.mtxtGuess.Size = new System.Drawing.Size(32, 24);
			this.mtxtGuess.TabIndex = 3;
			this.mtxtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblHistory
			// 
			this.lblHistory.AutoSize = true;
			this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHistory.Location = new System.Drawing.Point(14, 577);
			this.lblHistory.Name = "lblHistory";
			this.lblHistory.Size = new System.Drawing.Size(258, 18);
			this.lblHistory.TabIndex = 1;
			this.lblHistory.Text = "Place letters here as they are guessed";
			// 
			// lblLettersGuessed
			// 
			this.lblLettersGuessed.AutoSize = true;
			this.lblLettersGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLettersGuessed.Location = new System.Drawing.Point(14, 548);
			this.lblLettersGuessed.Name = "lblLettersGuessed";
			this.lblLettersGuessed.Size = new System.Drawing.Size(132, 18);
			this.lblLettersGuessed.TabIndex = 0;
			this.lblLettersGuessed.Text = "Guessed Letters";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(231, 322);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(158, 29);
			this.btnReset.TabIndex = 15;
			this.btnReset.Text = "Play Again?";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Visible = false;
			this.btnReset.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnSubmitGuess;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnQuit;
			this.ClientSize = new System.Drawing.Size(709, 767);
			this.Controls.Add(this.pnlGame);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.pnlTitleScreen);
			this.Name = "frmMain";
			this.Text = "Hangman";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.pnlTitleScreen.ResumeLayout(false);
			this.pnlTitleScreen.PerformLayout();
			this.pnlGame.ResumeLayout(false);
			this.pnlGame.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlTitleScreen;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Panel pnlGame;
		private System.Windows.Forms.Label lblLettersGuessed;
		private System.Windows.Forms.Label lblHistory;
		private System.Windows.Forms.MaskedTextBox mtxtGuess;
		private System.Windows.Forms.Button btnSubmitGuess;
		private System.Windows.Forms.Label lblGuess;
		private System.Windows.Forms.Label lblHead;
		private System.Windows.Forms.Label lblLeftLeg;
		private System.Windows.Forms.Label lblRightLeg;
		private System.Windows.Forms.Label lblRightArm;
		private System.Windows.Forms.Label lblLeftArm;
		private System.Windows.Forms.Label lblBody;
		private System.Windows.Forms.Label lblNoose;
		private System.Windows.Forms.Label lblSecretWord;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Button btnReset;
	}
}

