using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Checker()
        {
            int answer;
            bool valid1 = Int32.TryParse(Console.ReadLine(), out answer) && answer >= 0 && answer <= 100;
            
            if (!valid1)
            {
                do
                {
                    Console.WriteLine("Please enter an integer from 0 - 100");
                    valid1 = Int32.TryParse(Console.ReadLine(), out answer) && answer >= 0 && answer <= 100;
                } while (!valid1);
            }
            return answer;
        }
        public static int CheckString()
        {
            int count;
            
            for(int i = 1; ;i++)
            {
                string a = Console.ReadLine();

                if (a == "yes")
                {
                    count = 1;
                    break;
                }
                if (a == "no")
                {
                    count = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter yes or no, computer-chan is eagerly waiting for your reply");
                }
            }
            return count;
        }

        public static void Pause()
        {
            Console.WriteLine("Press any key to continue to the next round");
            Console.ReadKey(true);
        }

        public static void Pause1()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            int answer;
            int ranswer;
            int tries; // for the amount of times need to guess the correct answer
            int counter = 1; // for the round
            int countConfirm;
           
            for (int i = 0; ; i++) // is the outer loop to continue the game if desired, infinite loop
            {
                tries = 0;
                Console.WriteLine($"Round {counter}");
                Random random = new Random();
                Console.WriteLine("Lets play a game. I'll think of a number,");
                Console.WriteLine("and you just have to guess it!");
                Console.Write("Ready? And begin! :  ");
                //bool valid1 = Int32.TryParse(Console.ReadLine(), out answer) && answer >= 0 && answer <= 100; 
                ranswer = random.Next(100) + 1; // from 0-99 to 1-100 with the plus one on the range
                // Console.WriteLine(ranswer); // to check how my guesses are working
                //uncomment the above to get the answer quick to check the rest of the code
               
                for (int newi = 0; ; newi++) //is an infinite loop until broken out of
                { 
                    answer = Checker(); // checker function returns answer to answer 
                    if(answer - ranswer > 0)
                    {
                        Console.WriteLine("Your answer is greater than what I'm thinking.");
                        Console.WriteLine("Please try again");
                        tries++;
                    }
                    if (answer - ranswer < 0)
                    {
                        Console.WriteLine("Your answer is less than what I'm thinking.");
                        Console.WriteLine("Please try again");
                        tries++;
                    }
                    if (answer == ranswer)
                    {
                        Console.WriteLine("Congratulations!");
                        tries++;
                        if (tries == 1)
                        {
                            Console.WriteLine($"You figured out the answer in {tries} try");
                        }
                        if (tries > 1)
                        {
                            Console.WriteLine($"You figured out the answer in {tries} tries");
                        }
                        break;
                    }
                }
                Console.WriteLine("Would you like to play again? Type yes or no ");
                countConfirm = CheckString();
                if(countConfirm == 1)
                {
                    counter++;
                    Console.WriteLine("");
                    Pause();
                    Console.WriteLine("");
                }
                else if(countConfirm == 0)
                {
                    Console.WriteLine("Thanks for playing!");
                    Pause1();
                    break;
                }
            }
        }
    }
}
