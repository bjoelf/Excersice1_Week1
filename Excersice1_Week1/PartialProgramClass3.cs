using System;
using System.Collections.Generic;
using System.Text;

namespace Excersice1_Week1
{
    public partial class Program
    {
        private static void RunExcerciseEleven()
        {
            Console.WriteLine("Hello dear user, please type in an integer number, not ZERO" );
            int aInt = Convert.ToInt32(Console.ReadLine());
            while (aInt == 0)
            {
                Console.WriteLine("No not zero, pls try again");
                aInt--;
            }

            for(int i = 0; i<=aInt; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(i);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------");

            for (int i = aInt; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(i);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void RunExcerciseTwelve()
        {
            for (int i = 1; i <= 10; i++)
            {
                string builder = "";
                for (int ii = 1; ii <= 10; ii++)
                {
                    builder = builder + $"{i * ii} \t";
                }
                Console.WriteLine(builder);
                builder = "";
            }
        }
        private static void RunExcerciseThirteen()
        {
            int rnd = new Random().Next(500);

            bool notLucky = true;
            while (notLucky)
            {
                int guess = 0;
                Console.WriteLine($"Enter a number between 0 and 500.  ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == rnd)
                {
                    Console.Write($"Your guess was {guess} and that was correct!!");
                    notLucky = false;
                } 
                else if (guess > rnd)
                {
                    Console.Write($"Your guess was too big.");
                } 
                else
                {
                    Console.Write($"Your guess was too small.");
                }
            }
        }
        private static void RunExcerciseFourteen()
        {
            throw new NotImplementedException();
        }
        private static void RunExcerciseFifteen()
        {
            throw new NotImplementedException();
        }
        private static void RunExcerciseSixteen()
        {
            throw new NotImplementedException();
        }
        private static void RunExcerciseSeventeen()
        {
            throw new NotImplementedException();
        }
        private static void RunExcerciseEightteen()
        {
            throw new NotImplementedException();
        }
        private static void RunExcerciseNineteen()
        {
            throw new NotImplementedException();
        }
        private static void RunExcerciseTwenty()
        {
            throw new NotImplementedException();
        }
    }
}
