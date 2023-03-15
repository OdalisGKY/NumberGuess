using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
     
                //random number
                Random random = new Random();
                int number = random.Next(1, 10);

                //number var
               // int number = 7;

                //int pick var
                int pick = 0;

                Console.WriteLine("Guess between 1 and 10");

                //not correct
                while (pick != number)
                {
                    //input
                    string input = Console.ReadLine();
                    pick = Int32.Parse(input);
                    if (pick != number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Sorry, wrong number, try again");
                        Console.ResetColor();
                    }

                }
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
        
            }
        }
    }
