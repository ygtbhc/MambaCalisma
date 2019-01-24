using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class Pc : IGame
    {
        public void Run()
        {
            Console.WriteLine("Pc game running..");
        }
    }
}
