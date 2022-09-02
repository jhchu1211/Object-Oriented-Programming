using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public void Separate(int n)
        {
            int og = n;
            int fifth = og / 10000;
            int fourth = (og / 1000) % 10;
            int third = (og / 100) % 10;
            int second = (og / 10) % 10;
            int first = (og) % 10;
            int sum = fifth + fourth + third + second + first;
            lister.Items.Add($"{n}\t{fifth} + {fourth} + {third} + {second} + {first} = {sum}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nBox.BackColor = Color.White;
            lister.Items.Clear();
            bool check = Int32.TryParse(nBox.Text, out int n) && n > 0;
            if (!check)
            {
                MessageBox.Show("Invalid number. \nPlease enter a positive integer to begin the application.");
                nBox.BackColor = Color.LightSalmon;
            }
            else
            {
                Random r = new Random();
                int R = 0;
                for(int i = 0; i < n; i++)
                {
                    R = r.Next(0, 100000); // from 0 - 99999
                    Separate(R);
                }
            }
        }
    }
}
