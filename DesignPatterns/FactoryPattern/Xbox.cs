using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class Xbox : IGame
    {
        public void Run()
        {
            Console.WriteLine("Xbox game running..");
        }
    }
}
