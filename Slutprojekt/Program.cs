using System.Threading;
using System.Collections.Generic;
using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args) //Clone Battle Game, Create and name your clones, then battle against droids
        {
            MainAlgorithm run = new MainAlgorithm();

            Console.ReadLine();

            Console.WriteLine("How many clones do you want to create?");

            run.CreateClones();

            Console.WriteLine("Choose names for your Clones!");
            Console.WriteLine("Write them down below:");

            run.NameSetter();

            Console.WriteLine("The name/s of your clone/s are: ");
            run.NameQueuer();
           
            Console.ReadLine();
        }
    }
}
