using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework05Q01
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lBox1.Items.Clear();
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
            for (int i = 0; i < 1000; i++)
            {
                Random r = new Random();
                double a = Math.Round(r.NextDouble(), 1);
                lBox1.Items.Add(a);
                a = a * 10;
                switch (a)
                {
                    case 10:
                    case 9:
                        count5++;
                        break;
                    case 8:
                        count4++;
                        break;
                    case 7:
                        count3++;
                        break;
                    case 6:
                        count2++;
                        break;
                    default:
                        count1++;
                        break;
                }
            }
            lBox1.Items.Add("Range" + "\t\t" + "Count");
            lBox1.Items.Add("=======================================");
            lBox1.Items.Add("[90, 100]" + "\t\t" + count5);
            lBox1.Items.Add("[80, 90)" + "\t\t" + count4);
            lBox1.Items.Add("[70, 80)" + "\t\t" + count3);
            lBox1.Items.Add("[60, 70)" + "\t\t" + count2);
            lBox1.Items.Add("Below 60" + "\t\t" + count1);
        }
    }
}
