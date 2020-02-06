//Author: David Runowski
//Date: 02/06/2020
using System;
using System.Text.RegularExpressions;//import to use REGEX

namespace MethodCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter Your Name:"); //ask user for input
                string userName = Console.ReadLine();//assign variable to users input
                bool ans = Regex.IsMatch(userName, @"^[a-zA-Z]+$"); //Check to see if user input only contains letters, if it does assign ture to ans
                if (ans)//check if ans is true
                {
                    displayName(userName); //call method with userName
                }
                else
                {
                    Console.WriteLine("***ERROR: Please Use Only Letters***");
                }

            }
            catch
            {
                Console.WriteLine("Invalid Entry");
            }
        }

        static void displayName(string input)//declare method displayName
        {
            Console.WriteLine("Hello " + input + "!");//print line using parameter
        }
    }
}
