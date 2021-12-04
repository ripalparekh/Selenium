// See https://aka.ms/new-console-template for more information
using System;

namespace Loops

{
    public class LoopsClass
    {
        public static void Main()
        {
            
            string[] AnimalsArray = { "dog", "cat", "elephant", "zebra" };
            Console.WriteLine("Enter an number between 0 and 3");
            string OptionString = Console.ReadLine();
            bool Success = int.TryParse(OptionString, out int OptionInt);

            if (Success.Equals(true))
            {

                if (OptionInt >= 0 & OptionInt <= 3)
                {
                    Console.WriteLine("The Animal you picked is " + AnimalsArray[OptionInt]);
                }
                else
                {
                    Console.WriteLine("You Picked an invalid choice");
                }

            }
            else
            {
                Console.WriteLine("You did not enter a number");
            }

        }

    }

}

