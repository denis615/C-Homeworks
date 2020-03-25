using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello from SEDC Codecademy v7.0");
            string subString = "Hello from SEDC Codecademy v7.0";
            //Getting the Input from the user
            Console.WriteLine("Please enter a number:");
            string stringN = Console.ReadLine();
            
           
            int n1;
            //Checking if we can sucessfully Parse the string and assigning that value to n1
            bool sucessfulParsing = int.TryParse(stringN, out n1);
            //If the checking is sucessfull and less than the length of our original substring
            if (sucessfulParsing == true && n1<subString.Length ) {

                string subString1;
           
            
                //Creating our substrinf from 0 to the value of our input (n1)
                subString1 = subString.Substring(0, n1);
                //Getting the length of the Substring
                int lengthOfSubString1 = subString1.Length;

                //Getting the output if everything went succesfully
                Console.WriteLine(subString1);
                Console.WriteLine($"The length of the new string is {lengthOfSubString1}");
                Console.ReadLine();
            
           

            }
            else {//Handlind errors if we get a wrong input :D
                Console.WriteLine("You either Entered a wrong character or a big number");
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
            }
    }
}
}
