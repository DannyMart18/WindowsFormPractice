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

    public partial class Form1 : Form
    {

        public long answer;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String num = txtInput.Text;
                long number = Int64.Parse(num);
                answer = factorial(number);
                String txtAnswer = answer.ToString();
                lblAnswer.Text = txtAnswer;
            }
            catch (Exception)
            {

                lblAnswer.Text = "Invalid input";

            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        public long factorial(long num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * factorial(num - 1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

       
    }
}
