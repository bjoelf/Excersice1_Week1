using System;

namespace Excersice1_Week1
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    int assigmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assigmentChoice)
                    {
                        case 1:
                            RunExcerciseOne();
                            break;
                        case 2:
                            RunExcerciseTwo();
                            break;
                        case 3:
                            RunExcerciseThree();
                            break;
                        case 4:
                            RunExcerciseFour();
                            break;
                        case 5:
                            RunExcerciseFive();
                            break;
                        case 6:
                            RunExcerciseSix();
                            break;
                        case 7:
                            RunExcerciseSeven();
                            break;
                        case 8:
                            RunExcerciseEight();
                            break;
                        case 9:
                            RunExcerciseNine();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assigment numer!");
                            Console.ResetColor();
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assigment numer!");
                    Console.ResetColor();
                }
                Console.ResetColor();
                Console.WriteLine("Hit any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
        }


        private static void RunExcerciseOne()
        {
            //Console.WriteLine("You successfullt ran excercise one!");
            string firstName = "Björn";
            string lastName = "Elfvin";
            Console.WriteLine("Hello " + firstName + " " + lastName + " I'm glad you are test subject.....");
        }
        private static void RunExcerciseTwo()
        {
            //Console.WriteLine("You successfullt ran excercise two!");
            Console.WriteLine("Todays date is: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Tomorrows  date is: " + DateTime.Now.AddDays(1).ToShortDateString());
            Console.WriteLine("Yesterdays date was: " + DateTime.Now.AddDays(-1).ToShortDateString());
        }
    }
}
