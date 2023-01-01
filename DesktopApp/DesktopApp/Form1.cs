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
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int valueOne;
			int valueTwo;

			valueOne=Convert.ToInt32(txt_FirstValue.Text);
			valueTwo=Convert.ToInt32(txt_SecondValue.Text);
			int Sum=valueOne*valueTwo;
			txt_Answer.Text = Sum.ToString();
		}

		private void btn_Divide_Click(object sender, EventArgs e)
		{
			int valueOne;
			int valueTwo;

			valueOne = Convert.ToInt32(txt_FirstValue.Text);
			valueTwo = Convert.ToInt32(txt_SecondValue.Text);
			int Sum = valueOne / valueTwo;
			txt_Answer.Text = Sum.ToString();
		}
	}
}
