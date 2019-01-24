using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Test
{
    public class DataModelingHelper: IDataModeling
    {
        public void Base()
        {
            Case1();
            Case2();
            Console.WriteLine("Data modeling parsed and pushed for error list");
        }

        public void Case1()
        {
            Console.WriteLine("Case 1");
        }
        public void Case2()
        {
            Console.WriteLine("Case 2");
        }
    }
}
