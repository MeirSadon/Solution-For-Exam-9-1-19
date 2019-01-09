using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
	public partial class memoryGameForm : Form
	{
		public memoryGameForm()
		{
			InitializeComponent();
		}

		Random r = new Random();
		string number1;
		string number2;
		string number3;
		string number4;
		string number5;
		int score = 0;

		private void memoryGameForm_Load(object sender, EventArgs e)
		{
			Random r = new Random();
			number1 = num1Lbl.Text = r.Next(101).ToString();
			number2 = num2Lbl.Text = r.Next(101).ToString();
			number3 = num3Lbl.Text = r.Next(101).ToString();
			number4 = num4Lbl.Text = r.Next(101).ToString();
			number5 = num5Lbl.Text = r.Next(101).ToString();
			//num2Lbl.Text = r.Next(101).ToString();
			//num3Lbl.Text = r.Next(101).ToString();
			//num4Lbl.Text = r.Next(101).ToString();
			//num5Lbl.Text = r.Next(101).ToString();


		}

		private void startBtn_Click(object sender, EventArgs e)
		{
			//num1Lbl.Text = "";
			//num2Lbl.Text = "";
			//num3Lbl.Text = "";
			//num4Lbl.Text = "";
			//num5Lbl.Text = "";

			//num1Lbl.ForeColor = memoryGameForm.DefaultBackColor;
			//num2Lbl.ForeColor = memoryGameForm.DefaultBackColor;
			//num3Lbl.ForeColor = memoryGameForm.DefaultBackColor;
			//num4Lbl.ForeColor = memoryGameForm.DefaultBackColor;
			//num5Lbl.ForeColor = memoryGameForm.DefaultBackColor;

			num1Lbl.Visible = false;
			num2Lbl.Visible = false;
			num3Lbl.Visible = false;
			num4Lbl.Visible = false;
			num5Lbl.Visible = false;


		}

		private void finishBtn_Click(object sender, EventArgs e)
		{
			if (box1TxtBx.Text == number1 && box2TxtBx.Text == number2 && box3TxtBx.Text == number3 && box4TxtBx.Text == number4 && box5TxtBx.Text == number5)
				MessageBox.Show("You Won!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			if (box1TxtBx.Text == number1)
				score++;
			if (box2TxtBx.Text == number2)
				score++;
			if (box3TxtBx.Text == number3)
				score++;
			if (box4TxtBx.Text == number4)
				score++;
			if (box5TxtBx.Text == number5)
				score++;

			scoreList.Items.Add(score);
			score = 0;

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("EXIT?", "exit", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
			Application.Exit();
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{	
				num1Lbl.Visible = true;
				num2Lbl.Visible = true;
				num3Lbl.Visible = true;
				num4Lbl.Visible = true;
				num5Lbl.Visible = true;

				number1 = num1Lbl.Text = r.Next(101).ToString();
				number2 = num2Lbl.Text = r.Next(101).ToString();
				number3 = num3Lbl.Text = r.Next(101).ToString();
				number4 = num4Lbl.Text = r.Next(101).ToString();
				number5 = num5Lbl.Text = r.Next(101).ToString();

				box1TxtBx.Text = "";
				box2TxtBx.Text = "";
				box3TxtBx.Text = "";
				box4TxtBx.Text = "";
				box5TxtBx.Text = "";
			
		}
	}
}


