using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			SidePannel.Height = navBtn_Home.Height;
			SidePannel.Top = navBtn_Home.Top;
			firstCustomControl1.BringToFront();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void label1_Click_2(object sender, EventArgs e)
		{

		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void navBtn_Portfolio_Click(object sender, EventArgs e)
		{
			SidePannel.Height = navBtn_Portfolio.Height;
			SidePannel.Top = navBtn_Portfolio.Top;
			secondCustomControl1.BringToFront();
		}

		private void firstCustomControl1_Load(object sender, EventArgs e)
		{

		}

		private void navBtn_Home_Click(object sender, EventArgs e)
		{
			SidePannel.Height = navBtn_Home.Height;
			SidePannel.Top = navBtn_Home.Top;
			firstCustomControl1.BringToFront();
		}

		private void socialBtn_ig_Click(object sender, EventArgs e)
		{
	
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}
	}
}
