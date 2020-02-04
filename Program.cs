//Author: David Runowski
//Date: 02/06/2020
using System;

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
                displayName(userName); //call method with userName

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
