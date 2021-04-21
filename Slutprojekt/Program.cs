using System.Security.Cryptography.X509Certificates;
using System.Threading;
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

            List<Clone> clones = new List<Clone>();

            Clone c1 = new Clone();
            Clone c2 = new Clone();
            Clone c3 = new Clone();
            Clone c4 = new Clone();
            clones.Add(c1);
            clones.Add(c2);
            clones.Add(c3);
            clones.Add(c4);


            Console.WriteLine("How many clones do you want to create?");
            while (success == false)
            {
                Console.WriteLine("Please choose a number of 1 - 4");

                numberOfClones = Console.ReadLine();
                success = int.TryParse(numberOfClones, out numberOfClonesResult);

                if (numberOfClonesResult <= 0 || numberOfClonesResult > 4)
                {
                    Console.WriteLine("That is not possible, please try again.");
                    success = false;
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }

            Console.WriteLine("Choose names for your Clones!");
            Console.WriteLine("Write them down below:");

            for (int nameNumber = 0; nameNumber < numberOfClonesResult; nameNumber++)
            {
                names.Add(Console.ReadLine());
            }

            for (int remove = 4; remove > numberOfClonesResult; remove--)
            {
                clones.RemoveAt(remove);
            }

            for (int cloneNumber = 0; cloneNumber < numberOfClonesResult; cloneNumber++)
            {
                 names[cloneNumber] = clones[cloneNumber].GetName();
            }
           
            Console.ReadLine();
        }
    }
}
