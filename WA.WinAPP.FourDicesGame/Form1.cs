using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA.WinAPP.FourDicesGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void playButton_Click(object sender, EventArgs e)
		{
			// Game game = null;
			//while (game == null)
			//{
			//	try
			//	{
			//		game = new Game(1, 5, 6, 5); // 點數7
			//	}
			//	catch
			//	{ }
			//}
			Game game =Game.NewGame();
			historyTextBox.Text += game.ToString() + "\r\n";
		}
	}
}
