using System;

namespace PreWorkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Your score is: {ChallengeOne()}.");
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
    }
}