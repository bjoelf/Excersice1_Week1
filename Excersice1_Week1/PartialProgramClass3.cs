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
                    builder += $"{i * ii} \t";
                }
                Console.WriteLine(builder);
            }
        }
        private static void RunExcerciseThirteen()
        {
            int rnd = new Random().Next(500);

            bool notLucky = true;
            while (notLucky)
            {
                Console.WriteLine($"Enter a number between 0 and 500.  ");
                int guess = Convert.ToInt32(Console.ReadLine());
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
            ///Write a program that keeps asking the user for input numbers, until he enters -1. 
            ///Store the amount of numbers the user have entered and the sum of the numbers added together. 
            ///When the user types -1, the program should display the sum and the average of the numbers.

            double sum = AskUserForInput("Give me a number");
            int counter = 0;

            bool loopAlive = true;
            while (loopAlive)
            {
                double userInput = Double.Parse(Console.ReadLine());
                if (userInput == -1)
                {
                    Console.WriteLine($"Sum is {sum} and the average is: {sum/counter}. ");
                    loopAlive = false;
                }
                else
                {
                    Console.WriteLine($"Sum is (now): {sum}. Give me a negative value (-1) to quit.");
                    sum += userInput;
                    counter++;
                }
            }
        }
        private static void RunExcerciseFifteen()
        {
            throw new NotImplementedException();
        }
        private static void RunExcerciseSixteen()
        {
            /// Write a program that asks the user for a number. 
            /// Use this number to output the Fibonacci series up until that number. 
            /// Entering 10 should then output: 0, 1, 1, 2, 3, 5, 8, 13, 21 and 34.
            Console.Write("Please enter a number: ");
            int nr = int.Parse(Console.ReadLine());

            int fib = 0;
            int newFib = 1;
            int lastFib = 0;
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine(lastFib);
                lastFib = newFib + fib;
                fib = newFib;
                newFib = lastFib;
            }
        }
        private static void RunExcerciseSeventeen()
        {
            ///Let the user input a string, then check if the string is a palindrome sentence.
            ///A palindrome is a word or sentence that reads the same in both directions. 
            ///Example of palindrome sentences are Loops at a spool, wet stew and level. 
            ///However, the spaces might look different depending on which direction you read it, 
            ///so these should be excluded in your calculations, and a tip is to use some string manipulation to remove them.

            do {
                Console.Write("Enter a word to check: ");
                string input = Console.ReadLine();
                input = input.Replace(" ", "").Trim();
                int test = (input.Length % 2 + 1);
                bool pal = true;

                for (int i = 0; i < test; i++)
                {
                    char fromStart = input[i];
                    char fromEnd = input[input.Length - (i + 1)];
                    if (fromStart != fromEnd)
                    {
                        Console.WriteLine(fromStart + " " + fromEnd);
                        pal = false;
                        break;
                    }
                    Console.WriteLine(fromStart + " " + fromEnd);
                }

                if (pal)
                {
                    Console.WriteLine($" {input} is a palindrome");
                }
                else
                {
                    Console.WriteLine($" {input} is a palindrome");
                }
            } while (true);
        }
        private static void RunExcerciseEightteen()
        {
            ///Create a new empty integer array of 10 elements. 
            ///Loop through the array and assign each element to a new random value.
            int[] intArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                intArray[i] = Convert.ToInt32(new Random().Next(500));
            }
            ///Create a new empty array of doubles, having the same size as the previous array. 
            ///Loop through that array and assign the values to 1 divided by the value on the same position of the previous array.
            ///So if the first array has the value 42 on position 3, the second array should hold the double value 1 / 42.
            double[] dblArray = new double[10];
            for (int i = 0; i<10; i++)
            {
                dblArray[i] = 1/Convert.ToDouble(intArray[i]);
            }

            ///Finally, loop through both arrays and output the values to the screen using a foreach-loop.
            ///https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/using-foreach-with-arrays
            foreach (int i in intArray)
            {
                Console.WriteLine($"intArray value is: {i} ");
            }
            foreach (double d in dblArray)
            {
                Console.WriteLine($"doubleArray value is: {d} ");
            }

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
