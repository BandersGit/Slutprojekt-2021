using System;
using System.Collections.Generic;
using System.Threading;

namespace Slutprojekt
{
    public class MainAlgorithm
    {
        string numberOfClones;
        int numberOfClonesResult;
        bool success = false;

        List<string> names = new List<string>();

        List<Clone> clones = new List<Clone>();

        Clone c1 = new Clone();
        Clone c2 = new Clone();
        Clone c3 = new Clone();
        Clone c4 = new Clone();

        public MainAlgorithm()
        {
            clones.Add(c1);
            clones.Add(c2);
            clones.Add(c3);
            clones.Add(c4);
        }

        public void NameSetter()
        {

            for (int nameNumber = 0; nameNumber < numberOfClonesResult; nameNumber++)
            {
                names.Add(Console.ReadLine());
            }

            for (int remove = 3; remove > numberOfClonesResult; remove--)
            {
                clones.RemoveAt(remove);
            }

            for (int cloneNumber = 0; cloneNumber < numberOfClonesResult; cloneNumber++)
            {
                 names[cloneNumber] = clones[cloneNumber].GetName();
            }
        }

        public void CreateClones()
        {
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
        }
    }
}
