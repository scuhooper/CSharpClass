using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ist303_keeling_j_a5
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnQuit_Click( object sender, EventArgs e )
		{
			Application.Exit();
		}

		private void btnSubmitGuess_Click( object sender, EventArgs e )
		{

		}

		private void btnPlay_Click( object sender, EventArgs e )
		{
			pnlTitleScreen.Visible = false;
			pnlGame.Visible = true;
		}

		private void frmMain_Load( object sender, EventArgs e )
		{
			
		}
	}
}
