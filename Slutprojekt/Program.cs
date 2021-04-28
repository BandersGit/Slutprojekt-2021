using System.Threading;
using System.Collections.Generic;
using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args) //Clone Battle Game, Create and name your clones, then battle against droids, fighting part not worked on bc of time constraints
        {
            MainAlgorithm run = new MainAlgorithm(); // Instansiates MainAlgorithm class to get access to its methods

            Console.WriteLine("How many clones do you want to create?"); //Asks the user how many clones they want to create, and then runs the method for creating them

            run.CreateClones();

            Console.WriteLine("Choose names for your Clones!"); //When the clones have been created the user can name them, whatever they want
            Console.WriteLine("Write them down below:");

            run.NameSetter();

            Console.WriteLine("The name/s of your clone/s are: ");  //Uses a method with a queue to write out all the names
            run.NameQueuer();
           
            Console.ReadLine();
        }
    }
}
