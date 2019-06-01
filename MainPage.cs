using System;

namespace OOP
{
    class MainPage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a compilation of all the exercises I have completed while doing my C# Developer course. \n\n" +
                "DISCLAIMER:\n" +
                "Since I had some prior knowledge of programming I skipped some chapters which are the same for all\n" +
                "programming languages (i.e: data types, loops, if-else statements, switch cases, etc.)\n\n" +
                "Enjoy!");

            Console.WriteLine("Choose an exercise: \n" +
                "[0] Overloading Methods Exercise\n" +
                "[1] \n" +
                "More coming soon!");
            string input = Console.ReadLine();

            switch (input)
            {
                default: Console.WriteLine("No Module was selected or wrong input was given");  break;
                case "0": OverLoadingExercise(); break;
                case "1": Console.WriteLine(); ; break;
            }

        }

        private static void OverLoadingExercise()
        {
            OverloadingExercise.OverloadingExerciseMain();
        }


    }
}
