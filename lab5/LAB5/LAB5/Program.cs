using System;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            Island island1 = new Island();
            Sea sea1 = new Sea();
            Ocean ocean1 = new Ocean();
            Continent con1 = new Continent();

            Console.WriteLine("Con can{0} be converted to object", (con1 is Object) ? "" : "n't");
            Console.WriteLine("Con can{0} be converted to ValueType", (con1 is ValueType) ? "" : "n't");

            Land land1 = new Land();
            Island island2 = land1 as Island;
            Console.WriteLine("Land to Island conversion is {0} completed", (island2 != null) ? "" : "not");
            Land land2 = con1 as Land;
            Console.WriteLine("Continent to Land conversion is {0} completed", (land2 != null) ? "" : "not");
            Console.WriteLine();

            Print print1 = new Print();
            Water[] WArr = new Water[] { sea1, ocean1 };
            foreach (var i in WArr)
            {
                print1.IAmPrinting(i);
            }
            Console.WriteLine();
            
        }

    }
}
