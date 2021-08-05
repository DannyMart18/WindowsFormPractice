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
    public partial class Form4 : Form
    {

        public const double weeks = 52.0;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                String h = txtHours.Text;
                double hours = Double.Parse(h);
                String r = txtRate.Text;
                double rate = Double.Parse(r);

                double salary = calcSalary(hours, rate);


                lblAnswer.Text = "£" + salary.ToString();

            }
            catch (Exception)
            {
                lblAnswer.Text = "Invalid Data Entered";
            }
        }

        private double calcSalary(double hours, double rate)
        {
            double yearlyWage;
            double hourlyWage = hours * rate;
            yearlyWage = weeks * hourlyWage;

            return yearlyWage;
        }
    }
}
