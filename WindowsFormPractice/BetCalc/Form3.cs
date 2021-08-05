using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetCalc
{
    public partial class Form3 : Form
    {

        

        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                String input = txtInput.Text;
                int year = Int32.Parse(input);

                if (year % 4 == 0 || year % 400 == 0)
                {
                    lblAnswer.Text = input + " is a leap year";
                }
                else
                {
                    lblAnswer.Text = input + " is not a leap year";
                }
            }
            catch (Exception)
            {
                lblAnswer.Text = "Invalid Input";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
