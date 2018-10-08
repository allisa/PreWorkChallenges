using System;

namespace PreWorkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Your score is: {ChallengeOne()}.");
            ChallengeTwo();
        }

        //Challenge one, Array Max Result
        static int ChallengeOne()
        {
            int[] userInputArray = new int[5];

            Console.WriteLine("Please enter 5 numbers between 1-10");

            for (int i = 0; i < userInputArray.Length; i++)
            {
                userInputArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("Enter a number from your original input");
            int numInput = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < userInputArray.Length; i++)
            {
                if (userInputArray[i] == numInput)
                    count++;
            }

            return (numInput * count);
        }

        //Challenge two, Leap Year Calendar
        static void ChallengeTwo()
        {
            Console.Write("Enter a year to find out if it is a leap year:");
            int year = Int32.Parse(Console.ReadLine());

            if (year % 4 == 0)
                Console.WriteLine($"The year {year} is a leap year.");
            else if (year % 100 == 0 && year % 400 == 0)
                Console.WriteLine($"The year {year} is a leap year.");
            else
                Console.WriteLine($"The year {year} is not a leap year.");   
        }
    }
}