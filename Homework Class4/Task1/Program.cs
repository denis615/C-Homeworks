using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.Clear();
            //Declaring the String as you Described
            string subString = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine(subString);
            //Requesting an input from the user
            Console.WriteLine("Please enter a number?");
            string input = Console.ReadLine();
            //Converting it to an Integrer
            int n = int.Parse(input);
            //Making it to Char so we can split it
            char[] chars = subString.ToCharArray();
            //Getting the length of the chars so that we can use it in our if statement
            int charsnumber = chars.Length;
            //Counter for our while loop
            int counter1 = 0;


            string output1="";

            
            //Condition to check if the input is less than the length of the char array
            if (charsnumber>=n) {
                //Making a While loop 
                while (counter1 <= n) {

                    
                    //Making the Charact back to string and adding them to the output
                     output1 += chars[counter1].ToString();
                    counter1++;



                  

                  



                }
                //Output
                Console.WriteLine(output1);

                //Geting the length
                int outputlenght = output1.Length;
                Console.WriteLine($"The length of the new string is:{outputlenght}");
                Console.ReadLine();


            }
            else
            {// If there is a bigger number or invalid character :D
                Console.WriteLine("The number you entered is more than the length of the String or is an invalid character. Goodbye");
                Environment.Exit(0);
            }
           
        }
    }
}
