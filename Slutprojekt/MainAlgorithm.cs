using System;
using System.Collections.Generic;
using System.Threading;

namespace Slutprojekt
{
    public class MainAlgorithm
    {
        private string numberOfClones;
        private int numberOfClonesResult;
        private bool success = false;

        private List<string> names = new List<string>();

        public List<Clone> clones = new List<Clone>();

        public Queue<string> nameQueue = new Queue<string>();

        public MainAlgorithm()
        {
            Clone c1 = new Clone();
            Clone c2 = new Clone();
            Clone c3 = new Clone();
            Clone c4 = new Clone();

            clones.Add(c1);
            clones.Add(c2);
            clones.Add(c3);
            clones.Add(c4);
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
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            Thread.Sleep(1000);
            Console.Clear();
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
            
            Thread.Sleep(1000);
            Console.Clear();
        }

        public void NameQueuer()
        {
            for (int cloneNumber = 0; cloneNumber < numberOfClonesResult; cloneNumber++)
            {
                nameQueue.Enqueue(names[cloneNumber]);
            }

            for (int cloneNumber = 0; cloneNumber < numberOfClonesResult; cloneNumber++)
            {
                Console.WriteLine(nameQueue.Dequeue());
            }
        }

        
    }
}
