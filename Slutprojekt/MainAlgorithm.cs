using System;
using System.Collections.Generic;
using System.Threading;

namespace Slutprojekt
{
    public class MainAlgorithm
    {
        private string numberOfClones; //String int and bool to help execute the methods down below
        private int numberOfClonesResult;
        private bool success = false;

        private List<string> names = new List<string>(); //A list to store the names the user will give their clones

        public List<Clone> clones = new List<Clone>(); //A list to store the clones created in the constructor

        public Queue<string> nameQueue = new Queue<string>(); //A queue which purpose it is to queue up the names of the clones for easier writing of them.

        public MainAlgorithm() //Constructor that creates the "max" number of clones and adds them to their List
        {   
            Clone c1 = new Clone();
            Clone c2 = new Clone(); //Create clones inside method instead, use for loop, same number of clones the user says.
            Clone c3 = new Clone();
            Clone c4 = new Clone();

            clones.Add(c1);
            clones.Add(c2);
            clones.Add(c3);
            clones.Add(c4);
        }

        public void CreateClones() //A method to handle the creation of clones
        {
            while (success == false) //While loop to prevent the user from writing anything that is not intended
            {
                Console.WriteLine("Please choose a number of 1 - 4");

                numberOfClones = Console.ReadLine();    //Parsing their string answer into an int
                success = int.TryParse(numberOfClones, out numberOfClonesResult);

                if (numberOfClonesResult <= 0 || numberOfClonesResult > 4) //Checks if the answer is allowed, if it not the success variable sets back to false and the user has to write another number
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

        public void NameSetter() //Handles the name setting and "cleaning up" of the clones
        {

            for (int nameNumber = 0; nameNumber < numberOfClonesResult; nameNumber++) //Lets the user write in the names for the corresponding amount of clones created
            {
                names.Add(Console.ReadLine());
            }

            for (int remove = 3; remove > numberOfClonesResult; remove--) //Removes eccess clones that has not been named.
            {
                clones.RemoveAt(remove);
            }

            Thread.Sleep(1000);
            Console.Clear();
        }

        public void NameQueuer() //Queues up the name from the List and then writes out all of the names to avoid using the indexing of the List.
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
