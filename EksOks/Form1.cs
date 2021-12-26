using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EksOks
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public int player = 2;
		public int move = 0;
		public int s1 = 0;
		public int s2 = 0;
		public int sn = 0;

		private void button_click(object sender, EventArgs e)
		{
			Button button = (Button) sender;
			if (button.Text == "")
			{
				if (player % 2 == 0)
				{
					button.Text = "X";
					player++;
					move++;
				}
				else
				{
					button.Text = "O";
					player++;
					move++;
				}
				if (tie() == true)
				{
					MessageBox.Show("GAME IS A TIE!", "I N F O");
					sn++;
					Draw.Text = "Tie: " + sn;
				}
				if (winner() == true)
				{
					if (button.Text == "X")
					{
						MessageBox.Show("WINNER IS PLAYER X ! ! !", "WE HAVE A WINNER ! ! !");
						s1++;
						XWin.Text = "X: " + s1;
					}
					else
					{
						MessageBox.Show("WINNER IS PLAYER O ! ! !", "WE HAVE A WINNER ! ! !");
						s2++;
						OWin.Text = "O: " + s2;
					}					
				}
			}
		}
		public bool tie()
		{
			if (move == 9 && winner() == false)
				return true;
			else
			{
				return false;
			}
		}
		public bool winner()
		{
			if (b11.Text == b12.Text && b12.Text == b13.Text && b11.Text != "" ||
					b21.Text == b22.Text && b22.Text == b23.Text && b21.Text != "" ||
					b31.Text == b32.Text && b32.Text == b33.Text && b31.Text != "" ||
					b11.Text == b21.Text && b21.Text == b31.Text && b11.Text != "" ||
					b12.Text == b22.Text && b22.Text == b32.Text && b12.Text != "" ||
					b13.Text == b23.Text && b23.Text == b33.Text && b13.Text != "" ||
					b11.Text == b22.Text && b22.Text == b33.Text && b11.Text != "" ||
					b13.Text == b22.Text && b22.Text == b31.Text && b13.Text != "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		void NewGame()
		{
			player = 2;
			move = 0;
			b11.Text = b12.Text = b13.Text = b21.Text = b22.Text = b23.Text = b31.Text = b32.Text = b33.Text = "";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			NewGame();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			s1 = s2 = sn = 0;
			XWin.Text = "X: 0";
			OWin.Text = "O: 0";
			Draw.Text = "Tie: 0";
			NewGame();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			XWin.Text = "X: " + s1;
			OWin.Text = "O: " + s2;
			Draw.Text = "Tie: " + sn;
		}
	}
}
