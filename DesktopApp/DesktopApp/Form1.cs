using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
	public partial class Form1 : Form
	{
		Calculator myCal = new Calculator();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txt_Answer.Text = myCal.Multiply(Convert.ToInt32(txt_FirstValue.Text), Convert.ToInt32(txt_SecondValue.Text)).ToString();
		}

		private void btn_Divide_Click(object sender, EventArgs e)
		{
			txt_Answer.Text = myCal.Divide(Convert.ToInt32(txt_FirstValue.Text), Convert.ToInt32(txt_SecondValue.Text)).ToString();

		}

	}
}
