using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {startAgain:
            Console.Clear();
            Console.WriteLine("Please Enter a string of any length");
            string stringInput = Console.ReadLine();
            Console.WriteLine("Please enter a character");
            string characterInput = Console.ReadLine();
            char[] characterInputToChar = characterInput.ToCharArray();
            char[] charArray = stringInput.ToCharArray();


            int result = 0;

            for (int i = 0; i < stringInput.Length; i++)
            {
                if (charArray[i] == characterInputToChar[0])
                {
                    result++;
                }


            }

            Console.WriteLine($"That Character is {result} times in your array");


            Console.WriteLine("Would you like to Play again? Press Y or N");
            string answer = Console.ReadLine();
            string toLower = answer.ToLower();
            if (toLower == "y")
            {
                goto startAgain;
            }
            else
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
            }
            
        }
    }
}