using System;

namespace DesignPatterns.FactoryPattern
{
    public class Creator
    {
        public IGame CreateInstance(int n)
        {
            IGame game = null;

            if (n == 1)
                game = new Pc();

            if (n == 2)
                game = new Xbox();

            return game;
        }
    }
}
