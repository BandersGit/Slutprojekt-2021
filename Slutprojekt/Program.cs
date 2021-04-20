using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clone academy, Base clones get trained to become different types (ARC, Jet, Heavy, Commando to Intel or ATK)
            string numberOfClones;
            int numberOfClonesResult = 0;
            bool success = false;
            
            List<string> names = new List<string>();

            System.Console.WriteLine("How many clones do you want to create?");
            while (success == false)
            {
                System.Console.WriteLine("Please choose a number of 1 - 4");

                numberOfClones = Console.ReadLine();
                success = int.TryParse(numberOfClones, out numberOfClonesResult);

                if (numberOfClonesResult <= 0 || numberOfClonesResult > 4)
                {
                    System.Console.WriteLine("That is not possible, please try again.");
                    Console.Clear();
                }
            }

            System.Console.WriteLine("Choose names for your Clones!");
            System.Console.WriteLine("Write them down below:");
            for (int nameNumber = 0; nameNumber < numberOfClonesResult; nameNumber++)
            {
                names.Add(Console.ReadLine());
            }

            
            for (int cloneNumber = 0; cloneNumber < numberOfClonesResult; cloneNumber++)
            {
                Clone wää = new Clone(); //Hur att skap olika namn för varje Klon
            }
            
            Console.ReadLine();
        }
    }
}
