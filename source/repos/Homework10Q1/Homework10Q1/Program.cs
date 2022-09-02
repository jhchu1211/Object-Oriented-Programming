using System;

namespace Homework10Q1
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
            bool t;
            int answer;
            do
            {
                Console.WriteLine("Please enter a value to answer the following question");
                Console.WriteLine("What type of student are you?");
                Console.WriteLine("1 - Elementary School\n2 - Middle School\n3 - High School\n4 - College\n5 - Graduate Student\n6 - No Education");
                t = Int32.TryParse(Console.ReadLine(), out answer) && answer > 0 && answer < 7;
            } while (!t);
            Console.WriteLine("What is your name?");
            string n = Console.ReadLine();
            switch (answer)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Where are you going to school?");
                    string s = Console.ReadLine();
                    Console.WriteLine("What is your GPA?");
                    double G = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is your grade level?");
                    int g = Convert.ToInt32(Console.ReadLine());
                    Student me = new Student(n, g, G, s);
                    Console.WriteLine(me.ToString());
                    break;
                case 4:
                    Console.WriteLine("What college/institution are you currently attending?");
                    string i = Console.ReadLine();
                    Console.WriteLine("What are you studying at " + i + "?");
                    string m = Console.ReadLine();
                    Console.WriteLine("What year are you in at " + i + "?");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is your GPA at " + i + "?");
                    double nG = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Where did you go for high school?");
                    s = Console.ReadLine();
                    Console.WriteLine("What was your GPA at " + s + "?");
                    G = Convert.ToDouble(Console.ReadLine());
                    g = 0;
                    Undergraduate meme = new Undergraduate(n,g,G,s, i, m, nG, y);
                    Console.WriteLine(meme.ToString());
                    break;
                case 5:
                    Console.WriteLine("What college/institution are you currently attending?");
                    string nI = Console.ReadLine();
                    Console.WriteLine("What college/institution did you attend for your undergraduate studies?");
                    i = Console.ReadLine();
                    Console.WriteLine("What did you study at " + i + "?");
                    m = Console.ReadLine();
                    Console.WriteLine("What degree did you receive at " + i + "?");
                    string d = Console.ReadLine();
                    Console.WriteLine("What was your GPA at " + i + "?");
                    nG = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Where did you go for high school?");
                    s = Console.ReadLine();
                    Console.WriteLine("What was your GPA at " + s + "?");
                    G = Convert.ToDouble(Console.ReadLine());
                    g = 0;
                    y = 0;
                    Graduate mememe = new Graduate(n, g, G, s, i, m, nG, y, d, nI);
                    Console.WriteLine(mememe.ToString());
                    break;
                case 6:
                default:
                    Console.WriteLine("What in the world are you doing mang?????");
                    break;
            }
            pause();
        }
    }
}
