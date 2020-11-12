using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XandO
{
	
	public partial class Form1 : Form
	{
		int player = 1;
		int[,] field = new int[3, 3] { { -1, -1, -1 }, { -1, -1, -1 }, { -1, -1, -1 } };
		public Form1()
		{
			InitializeComponent();
		}
		public bool win_condition(int[,] field)
		{
			for(int i=0;i<3;i++)
			{
				if (field[i, 0] == field[i, 1] && field[i, 0] == field[i, 2] && field[i, 0] != -1)
					return true;

				if (field[0, i] == field[1, i] && field[i, 0] == field[2, i] && field[0, i] != -1)
					return true;

			}
			if (field[0, 0] == field[1, 1] && field[0, 0] == field[2, 2] && field[0,0]!=-1)
				return true;
			if (field[0, 2] == field[1, 1] && field[0, 2] == field[2, 0] && field[0,2]!=-1)
				return true;
			Console.WriteLine(player);
			return false;
		}

		private void restart()
		{
			foreach(Control b in Controls.OfType<Button>())
			{
				b.Enabled = true;
				b.Text = "";

			}
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					field[i, j] = -1;
			player = player % 2 + 1;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (button1.Text == "")
			{
				if (player == 1)
				{
					button1.Text = "x";
					player = 2;
					field[0, 0] = 1;
					if(win_condition(field))
					{
						MessageBox.Show("Player 1 won");
						restart();
					}


				}
				else
				{
					button1.Text = "o";
					player = 1;
					field[0, 0] = 2;
					if (win_condition(field))
					{
						MessageBox.Show("Player 2 won");
						restart();
					}
				}

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (button2.Text == "")
			{
				if (player == 1)
				{
					button2.Text = "x";
					player = 2;
					field[1, 0] = 1;
					if (win_condition(field))
					{
						MessageBox.Show("Player 1 won");

					}
				}
				else
				{
					button2.Text = "o";
					player = 1;
					field[1, 0] = 2;
					if (win_condition(field))
					{
						MessageBox.Show("Player 2 won");
						restart();

					}
				}

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (button3.Text == "")
			{
				if (player == 1)
				{
					button3.Text = "x";
					player = 2;
					field[2, 0] = 1;
					if (win_condition(field))
					{
						MessageBox.Show("Player 1 won");
						restart();


					}
					else
					{
						button3.Text = "o";
						player = 1;
						field[2, 0] = 2;
						if (win_condition(field))
						{
							MessageBox.Show("Player 2 won");
							restart();

						}
					}

				}
			}

		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (button4.Text == "")
			{
				if (player == 1)
				{
					button4.Text = "x";
					player = 2;
					field[0, 1] = 1;
					if (win_condition(field))
					{
						MessageBox.Show("Player 1 won");
						restart();

					}
				}
				else
				{
					button4.Text = "o";
					player = 1;
					field[0, 1] = 2;
					if (win_condition(field))
					{
						MessageBox.Show("Player 2 won");
						restart();


					}
				}

			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (button5.Text == "")
			{
				if (player == 1)
				{
					button5.Text = "x";
					player = 2;
					field[1, 1] = 1;
					if (win_condition(field))
					{
						MessageBox.Show("Player 1 won");
						restart();

					}
				}
				else
				{
					button5.Text = "o";
					player = 1;
					field[1, 1] = 2;
					if (win_condition(field))
					{
						MessageBox.Show("Player 2 won");
						restart();

					}
				}

			}

		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (button6.Text == "")
			{
				if (player == 1)
				{
					button6.Text = "x";
					player = 2;
					field[1, 2] = 1;
					if (win_condition(field))
					{
						MessageBox.Show("Player 1 won");
						restart();

					}
				}
				else
				{
					button6.Text = "o";
					player = 1;
					field[1, 2] =2;
					if (win_condition(field))
					{
						MessageBox.Show("Player 2 won");
						restart();

					}
				}

			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (button7.Text == "")
			{
				if (player == 1)
				{
					button7.Text = "x";
					player = 2;
					field[0, 2] = 1;
					if (win_condition(field))
					{
						MessageBox.Show("Player 1 won");
						restart();


					}
				}
				else
				{
					button7.Text = "o";
					player = 1;
					field[0, 2] = 2;
					if (win_condition(field))
					{
						MessageBox.Show("Player 2 won");
						restart();


					}
				}

			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (button8.Text == "")
			{
				if (player == 1)
				{
					button8.Text = "x";
					player = 2;
					field[1, 2] = 1;
					if (win_condition(field))
					{
						MessageBox.Show("Player 1 won");
						restart();


					}
				}
				else
				{
					button8.Text = "o";
					player = 1;
					field[1, 2] = 2;
					if (win_condition(field))
					{
						MessageBox.Show("Player 2 won");
						restart();

					}
				}

			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			
			if (button9.Text == "")
			{
				if (player == 1)
				{
					button9.Text = "x";
					player = 2;
					field[2, 2] = 1;
					if (win_condition(field))
					{
						MessageBox.Show("Player 1 won");
						restart();

					}
				}
				else
				{
					button9.Text = "o";
					player = 1;
					field[2, 2] = 2;
					if (win_condition(field))
					{
						MessageBox.Show("Player 2 won");
						restart();

					}
				}


			}
		}

		
	}
}
