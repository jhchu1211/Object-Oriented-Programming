using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = Double.TryParse(sBox.Text, out double sales) && sales >= 0;
            if(!check)
            {
                MessageBox.Show("Total weekly sales must be a positive dollar amount. \nPlease re-enter.");
                sBox.Clear();
            }
            else
            {
                double f = sales * 0.18;
                double r = sales * 0.15;
                double ss = sales * 0.09;
                double t = sales - (f + r + ss);
                fBox.Text = Convert.ToString(f);
                rBox.Text = Convert.ToString(r);
                ssBox.Text = Convert.ToString(ss);
                tBox.Text = Convert.ToString(t);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            nBox.Clear();
            sBox.Clear();
            fBox.Clear();
            rBox.Clear();
            ssBox.Clear();
            tBox.Clear();
        }
    }
}
