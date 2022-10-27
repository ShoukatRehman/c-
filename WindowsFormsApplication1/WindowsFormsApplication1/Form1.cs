using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        @class myCal = new @class();
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txt_first.Clear();
            txt_second.Clear();
            txt_Answer.Clear();
        }

        private void btn_calul_Click(object sender, EventArgs e)
        {
            if (cmb_Choices.Text=="Add")
            {
                try
                {
                    txt_Answer.Text = myCal.Add(Convert.ToInt32(txt_first.Text), Convert.ToInt32(txt_second.Text)).ToString();

                }
                catch (Exception ee)
                {

                    lbl_Errors.Text = "Not valid input";
                    Clear();
                }



            }
            else if (cmb_Choices.Text=="Sub")
            {
                txt_Answer.Text = myCal.Sub(Convert.ToInt32(txt_first.Text), Convert.ToInt32(txt_second.Text)).ToString();

            }
            txt_first.Clear();
            txt_second.Clear();
            txt_first.Focus();

        }

       
    }
}
