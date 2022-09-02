using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    class NUtilities
    {
        public NUtilities()
        {
        }
        public void FindLargest(ref double[] a, string s)
        {
            int iMax = 4;
            double max = 0;
            int index = -1;
            for(int i = 0; i < iMax; i++ )
            {
                if(a[i] > max)
                {
                    index = i;
                    max = a[i];
                }
            }
            index++;
            Console.WriteLine("#" + index + " objext has the largest " + s + " of " + max);
        }
        ~NUtilities() { }
    }
}
