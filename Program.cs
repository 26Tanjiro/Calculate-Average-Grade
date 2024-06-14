using System;
using System.Diagnostics;

namespace Projectg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double addgrade;
            double sum = 0;
            double average;

            Console.WriteLine("Enter many attemp grade:");
            addgrade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < addgrade; i++)
            {
                sum = sum + InputGrade();
            }
            average = sum / addgrade;

            

             if (average <= 50)
            {
                Fail(average);
            }
            else if (average <= 70)
            {
                Fair(average);
            }
            else if (average <= 80)
            {
                Good(average);
            }
            else if (average <= 90)
            {
                VeryGood(average);
            }
            else
            {
                Excellent(average);
            }

            Console.WriteLine("Total Grade you input: " + sum);
            
        }

        public static int InputGrade()
        { 
          Console.Write("Enter the Grade:");
          return Convert.ToInt32(Console.ReadLine());
        }

        public static void Fail(double average)
        {
            Console.WriteLine(average + " Failed");
        }
        public static void Fair(double average)
        {
            Console.WriteLine(average + " Fair");
        }
        public static void Good(double average)
        {
            Console.WriteLine(average + " Good");
        }
        public static void VeryGood(double average)
        {
            Console.WriteLine(average + " Very Good");
        }
        public static void Excellent(double average)
        {
            Console.WriteLine(average + "Excellent");
        }
    }

}