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
		private void Clear()
		{
			txt_FirstValue.Clear();
			txt_SecondValue.Clear();
			txt_Answer.Clear();
		}

		private void btn_calculate_Click(object sender, EventArgs e)
		{
			
			if (cmb_Choice.Text=="Multiply")
			{
				try
				{
					txt_Answer.Text = myCal.Multiply(Convert.ToInt32(txt_FirstValue.Text), Convert.ToInt32(txt_SecondValue.Text)).ToString();

				}
				catch (Exception sr)
				{
					MessageBox.Show("Input is not invalid form","Errors",MessageBoxButtons.OK,MessageBoxIcon.Error);
					//lbl_Errors.Text = "Invalid input by users";
					Clear();
				}
			}
			else if (cmb_Choice.Text=="Divide")
			{
				try
				{
					txt_Answer.Text = myCal.Divide(Convert.ToInt32(txt_FirstValue.Text), Convert.ToInt32(txt_SecondValue.Text)).ToString();

				}
				catch (Exception sr)
				{
					MessageBox.Show("Input is not invalid form", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);

					//lbl_Errors.Text = "invalid";
				}

			}
			else if (cmb_Choice.Text=="Addition")
			{
				try
				{
					txt_Answer.Text = myCal.Addition(Convert.ToInt32(txt_FirstValue.Text), Convert.ToInt32(txt_SecondValue.Text)).ToString();

				}
				catch (Exception sr)
				{
					MessageBox.Show("Input is not invalid form", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);

					//lbl_Errors.Text = "invalid";
				}
			}
			else if (cmb_Choice.Text == "Subtraction")
			{
				try
				{
					txt_Answer.Text = myCal.Subtraction(Convert.ToInt32(txt_FirstValue.Text), Convert.ToInt32(txt_SecondValue.Text)).ToString();

				}
				catch (Exception sr)
				{
					MessageBox.Show("Input is not invalid form", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);

					//lbl_Errors.Text = "invalid";
				}
			}
			txt_FirstValue.Clear();
			txt_SecondValue.Clear();
			txt_FirstValue.Focus();
		}
	}
}
