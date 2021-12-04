// See https://aka.ms/new-console-template for more information
using System;

namespace Loops

{
    public class LoopsClass
    {
        public static void Main()
        {
            bool RunAgain = true;
            while (RunAgain == true)
            {
                Console.Clear();
                string[] AnimalsArray = { "dog", "cat", "elephant", "zebra" };
                string[] Cars = { "Fiat", "Lexus", "Mercedes", "Ferarri" };
                Console.WriteLine("Enter an number between 0 and 3");
                string OptionString = Console.ReadLine();
                bool Success = int.TryParse(OptionString, out int OptionInt);

                if (Success.Equals(true))
                {

                    if (OptionInt >= 0 & OptionInt <= 3)
                    {
                        Console.WriteLine("The Animal you picked is " + AnimalsArray[OptionInt]);
                        Console.WriteLine("You could have picked from these: ");
                        PrintAnimals(AnimalsArray);
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

                PrintCars(Cars);
                AnimalCar(Cars, AnimalsArray);

                RunAgain = AskToStop();
            }
        }
        #region Methods       
        public static void PrintAnimals(string[] AnimalsList)
        {
            foreach (string Animal in AnimalsList)
            {
                Console.WriteLine(Animal);
            }
        }

        public static void PrintCars(string[] CarList)
        {
            for (int count = 0; count < CarList.Length; count++)
            {
                Console.WriteLine("The Car is " + CarList[count]);
            }
        }

        public static void AnimalCar(string[] CarList, string[] Animals)
        {
            var RandAnimal = new Random();
            var RandCar = new Random();

            Console.WriteLine("the Animal " + Animals[RandAnimal.Next(Animals.Length)] +
                " matches with the " + CarList[RandCar.Next(CarList.Length)]);
        }
        
        public static bool AskToStop()
        {
            Console.WriteLine("Press Q to quit or any other key to run again");
            char Answer = Console.ReadKey().KeyChar;
            if ((Answer is (char)'q') || (Answer is (char)'Q'))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        #endregion
        
    }

}

