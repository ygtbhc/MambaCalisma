using System;

namespace MessageHelperLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine(SqlScriptMessage.CheckSchemaNameErrorMessage());
                //Schema adı girilmelidir
            }

            Console.ReadKey();
        }
    }
}
