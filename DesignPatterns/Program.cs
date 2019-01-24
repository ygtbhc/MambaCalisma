using DesignPatterns.Test;
using System;

namespace DesignPatterns
{
    class Program
    {
        public static void Main()
        {
            #region FactoryPattern
            //Creator creator = new Creator();

            //IGame pc = creator.CreateInstance(1);
            //IGame xbox = creator.CreateInstance(2);

            //pc.Run();
            //xbox.Run(); 
            #endregion

            Creator creator = new Creator();

            IDataModeling data = creator.CreateInstance<DataModelingHelper>();

            data.Base();

            Console.ReadKey();
        }

    }
}
