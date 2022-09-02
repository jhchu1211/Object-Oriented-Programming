using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework04Q03
{
    public partial class Form1 : Form
    {
        public double Factorial(double n)
        {
            double fac = 1;
            while (n >= 1)
            {
                
                fac = fac * (n);
                
                n = n - 1;
                
            }
            return fac;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool verify = Int32.TryParse(nBox.Text, out int n) && n >= 1;
            if(!verify)
            {
                MessageBox.Show("Invalid input.");
                if(n < 1)
                {
                    MessageBox.Show("Please enter a positive integer");
                }
                MessageBox.Show("Please reinput a valid integer");
            }
            else
            {
                LB1.Items.Clear();
                int f = 1;
                LB1.Items.Add(n + "! =" + n + " *");
                while(n > 1)
                {
                    f = f * n;
                    n = n - 1;
                    if (n == 1)
                    {
                        LB1.Items.Add(Convert.ToString(n));
                    }
                    else
                    {
                        LB1.Items.Add(n + " *");
                    }
                    if (n == 1)
                    {
                        LB1.Items.Add(" = " + f);
                    }
                }
                double estimate = 1;
                for(int i = Convert.ToInt32(nBox.Text); i > 1; i = i -1)
                {
                    estimate = 1 / (Factorial(i)) + estimate;
                }
                estimate = estimate + 1;
                decimal es = decimal.Round(Convert.ToDecimal(estimate), 6);
                eBox.Text = Convert.ToString(es);
            }
        }
    }
}
