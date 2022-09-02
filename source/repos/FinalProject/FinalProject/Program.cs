using System;

namespace FinalProject
{
    class Program
    {
        static void pause()
        {
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            Pool a = new Pool("A", 4, 8);
            double ad = a.Gett();
            Pool b = new Pool("B", 1, 3);
            double bd = b.Gett();
            Pool c = new Pool("C", 4, 2);
            double cd = c.Gett();
            Pool dd = new Pool("D", 13, 1);
            double ddd = dd.Gett();
            Pool e = new Pool("E", 12, 9);
            double ed = e.Gett();
            Pool f = new Pool("F", 10, 5);
            double fd = f.Gett();
            Pool g = new Pool("G", 6, 6);
            double gd = g.Gett();
            double[] pool = new double[7] {ad, bd, cd, ddd, ed, fd, gd};
            Pool[] pools = new Pool[7] { a, b, c, dd, e, f, g };
            Array.Sort(pool);
            Console.WriteLine("Maintenance man starts at (0,0) >> ");
            Pool diff = new Pool(); diff.SettL(0, 0);
            double max = 100; double nmax; int position = 0; int x; int y; double h; double maximum = 0;
            int[] check = new int[7];
            for(int i = 0; i < 7; i++)
            {
                x = 0; y = 0; h = 0; nmax = 0;
                maximum = 0;
                for(int n = 0; n < 7; n++)
                {
                    x = pools[n].x() - diff.x();
                    y = pools[n].y() - diff.y();
                    h = Math.Sqrt(Convert.ToDouble(x * x + y * y));
                    nmax = (max - h) + max;
                    if (nmax > maximum && h != 0 && check[n] != 1)
                    {
                        position = n;
                        maximum = nmax;
                    }
                }
                check[position] = 1;
                Random r = new Random();
                double d = r.Next(98, 108) + r.NextDouble();
                d = Math.Round(d, 2);
                pools[position].Sett(d, "F");
                string s = pools[position].ToString() + " >> ";
                Console.WriteLine(s);
                diff.SettL(pools[position].x(), pools[position].y());
            }
            /*for(int i = 0; i < 7; i++)
            {
                for(int n = 0; n < 7; n++)
                { 
                    if(pool[i] == pools[n].Gett())
                    {
                        Random r = new Random();
                        double d = r.Next(98, 108) + r.NextDouble();
                        d = Math.Round(d, 2);
                        pools[n].Sett(d, "F");
                        string s = pools[n].ToString() + " >> ";
                        Console.WriteLine(s);
                        break;
                    }
                }
            }*/
            //Array.Sort(pool);
            pause();
        }
    }
}
