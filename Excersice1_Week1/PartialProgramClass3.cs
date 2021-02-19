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

        }
        private static void RunExcerciseThirteen()
        {
            throw new NotImplementedException();
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
