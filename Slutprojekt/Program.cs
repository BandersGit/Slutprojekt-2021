using System.Threading;
using System.Collections.Generic;
using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAlgorithm run = new MainAlgorithm();

            Console.WriteLine("How many clones do you want to create?");

            run.CreateClones();

            Console.WriteLine("Choose names for your Clones!");
            Console.WriteLine("Write them down below:");

            run.NameSetter();
           
            Console.ReadLine();
        }
    }
}
