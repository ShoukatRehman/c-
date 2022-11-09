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
        int Limit = 5;
        int counter = 0;
        string HistoryMaintain = null;
        List<string> HistoryList = new List<string>();

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
                 HistoryMaintain = lbl_Events.Text += "=" + txt_Answer.Text;
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Input is not valid format", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //lbl_Errors.Text = "Not valid input";
                    Clear();
                }



            }
            else if (cmb_Choices.Text=="Sub")
            {
                try
                {
                     
                   txt_Answer.Text = myCal.Sub(Convert.ToInt32(txt_first.Text), Convert.ToInt32(txt_second.Text)).ToString();
                   HistoryMaintain = lbl_Events.Text += "=" + txt_Answer.Text;
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Input is not valid format", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   // lbl_Errors.Text="Not valid input";
                    Clear();
                }
            }
            txt_first.Clear();
            txt_second.Clear();
            txt_first.Focus();

            lbl_lastoption.Text = "Last Operation :" + HistoryMaintain;
            if (counter<Limit)
            {
                HistoryList.Add(HistoryMaintain);
                counter++;
            }
            
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            History myHistory = new History();
            myHistory.LoadList(HistoryList);
        }

        private void txt_first_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_first.Text))
            {
                txt_first.Focus(); 
            }
            else
            {
                lbl_Events.Text += txt_first.Text;
            }
           
        }

        private void txt_second_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_second.Text))
            {
                txt_second.Focus();
            }
            else
            {
                lbl_Events.Text += txt_second.Text;
            }
            
        }

        private void cmb_Choices_Leave(object sender, EventArgs e)
        {
            //lbl_Events.Text += cmb_Choices.Text;
        }

        private void cmb_Choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Choices.Text=="Add")
            {
                lbl_Events.Text += " + ";
            }
            else if (cmb_Choices.Text=="Sub")
            {
                lbl_Events.Text += " - ";

            }
            
        }

       
    }
}
