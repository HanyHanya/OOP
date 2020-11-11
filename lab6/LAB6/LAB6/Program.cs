using System;
using System.Collections.Generic;
using System.IO;

namespace LAB6
{
    class Program
    {
        static void Main(string[] args)
        {
            Earth earth = new Earth();
            EarthController contr = new EarthController();
            Island island1 = new Island("AIsland");
            Island island2 = new Island("BIsland");
            Island island3 = new Island("CIsland");
            Sea sea1 = new Sea("OneS");
            Sea sea2 = new Sea();
            Sea sea3 = new Sea();
            Sea sea4 = new Sea();
            Sea sea5 = new Sea();
            Ocean ocean1 = new Ocean();
            Continent con1 = new Continent("OneC");
            State state1 = new State("OneState");
            State state2 = new State("TwoState");

            earth.Add(sea1);
            earth.Add(sea2);
            earth.Add(sea3);
            earth.Add(sea4);
            earth.Add(sea5);

            earth.Add(island3);
            earth.Add(island1);
            earth.Add(island2);

            earth.Add(con1);
            con1.Add(state1);
            con1.Add(state2);

            Console.WriteLine("Государства:");
            con1.ShowList();
            Console.WriteLine();
            contr.SortIsland(earth.EarthL);
            Console.WriteLine("Количество морей на Земле: " + contr.NumOfSeas(earth.EarthL));

        }

    }
}
