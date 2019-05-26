using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class OverloadingExercise
    {
        public static void OverloadingExerciseMain()
        {
            int a = 5, b = 77, c = 789;
            double x = 5.678, y = 77.345, z = 789.4643;

            Console.WriteLine("Choose a calculation: \n" +
                "[1] a + b = ? \n" +
                "[2] a + b + c = ? \n" +
                "[3] x + y = ? \n" +
                "[4] x + y + z = ? \n");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": Calculate(a, b); break;
                case "2": Calculate(a, b, c); break;
                case "3": Calculate(x, y); break;
                case "4": Calculate(x, y, z); break;
                default: Calculate(); break;
            }


        }

        static void Calculate()
        {
            Console.WriteLine("No values or wrong values were entered");
        }

        static void Calculate(int a, int b)
        {
            Console.WriteLine("Result = " + a + b );

        }

        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Result = " + a + b + c);
        }

        static void Calculate(double x, double y)
        {
            Console.WriteLine("Result = " + x + y);
        }

        static void Calculate(double x, double y, double z)
        {
            Console.WriteLine("Result = " + x + y + z);
        }
    }
}
