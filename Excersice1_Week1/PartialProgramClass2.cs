using System;
using System.Collections.Generic;
using System.Text;

namespace Excersice1_Week1
{
    public partial class Program
    {
        private static void RunExcerciseThree()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName);
        }
        private static void RunExcerciseFour()
        {
            // return: “The brown fox jumped over the lazy dog”
            String str = "The quick fox Jumped Over the DOG";
            String ret = str.ToLower();
            ret = ret.Replace("quick", "brown");
            ret = ret.Insert(30, "lazy ");
            ret = char.ToUpper(ret[0]) + ret.Substring(1);
            Console.WriteLine(ret);
        }
        private static void RunExcerciseFive()
        {
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            String ret = str.Substring(str.IndexOf('['));
            ret = ret.Substring(0, 2) + ret.Substring(6);
            ret = ret.Substring(0, ret.Length - 1);
            ret = ret + ",6,7,8,9,10]";
            Console.WriteLine(ret);
        }
        private static void RunExcerciseSix()
        {
            Console.Write("Write a wholenumber (no decimals): ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write another wholenumber (no decimals this time either...): ");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(firstInt, secondInt);
            int min = Math.Min(firstInt, secondInt);
            Console.WriteLine("The biggest number is: " + max);
            Console.WriteLine($"The smallest number is: {min} ");
            Console.WriteLine($"The diffrence is :  { max - min}");
            Console.WriteLine($"The sum is :  { max + min}");
            Console.WriteLine($"The product is :  { max * min}");
            Console.WriteLine($"The ratio is :  { max / min}");
        }
        private static void RunExcerciseSeven()
        {
            Console.Write("Write a radius with decimals: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.Pow(radius * Math.PI * 2, 2);
            Console.WriteLine($"The area for that radius is : {area} ");
            double volume = Math.Pow(radius * Math.PI * 4, 3) / 3;
            Console.WriteLine($"The volyme for that radius is: {volume} ");
        }
        private static void RunExcerciseEight()
        {
            Console.Write("Write a radius with decimals: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double sqrt = Math.Sqrt(radius);
            Console.WriteLine($"The sqrt is : {sqrt} ");
            double pow2 = Math.Pow(sqrt, 2);
            Console.WriteLine($"The sqrt rasied pow 2 is : {pow2} ");
            double pow10 = Math.Pow(pow2, 10);
            Console.WriteLine($"The sqrt rasied another pow 10  : {pow10} ");
        }
        private static void RunExcerciseNine()
        {
            Console.Write("Hello dear user, what is your name? ");
            string userName = Console.ReadLine();
            Console.Write($"Welcome dear {userName}. Would you please state he year you was born? ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int age = DateTime.Now.Year - yearOfBirth;
            Console.WriteLine($"Dear, you are {age} years old....");

            if (age >= 18)
            {
                Console.WriteLine($"Yould you like to order a beer? True/false will do just fine...");
                bool beer = Convert.ToBoolean(Console.ReadLine());
                if (beer)
                {
                    Console.WriteLine("The order has been done!");
                }
                else //no beer
                {
                    Console.WriteLine($"Yould you like to order a coke? True/false will do just fine...");
                    bool coke = Convert.ToBoolean(Console.ReadLine());
                    if (coke)
                    {
                        Console.WriteLine("The coke has been served!");
                    }
                    else // no coke either...
                    {
                        Console.WriteLine("No order options are available!");
                    }
                }
            }
            else  // age < 18
            {
                Console.WriteLine($"Yould you like to order a coke? True/false will do just fine...");
                bool coke = Convert.ToBoolean(Console.ReadLine());
                if (coke)
                {
                    Console.WriteLine("The coke has been served!");
                }
                else // no coke either...
                {
                    Console.WriteLine("No order options are available!");
                }
            }
        }
        private static void RunExcerciseTen()
        {
            Console.Write("Hello dear user, please type in a number");
            double aNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dear user, please type in another number");
            double bNumber = Convert.ToDouble(Console.ReadLine());
            if (bNumber != 0)
            {
                Console.WriteLine($"First number divided by second number is: {aNumber / bNumber}");
            }
            else
            {
                Console.WriteLine("Error; number entered is equal to zero.");
                RunExcerciseFour();
            }
        }
    }
}
