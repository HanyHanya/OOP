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
            State state1 = new State("OneS"); 
            State state2 = new State("TwoS");
           
            earth.Add(sea1);
            earth.Add(sea2);
            earth.Add(sea3);
            earth.Add(sea4);
            earth.Add(sea5);

            earth.Add(island1);
            earth.Add(island2);
            earth.Add(island3);

            earth.Add(con1);
            con1.Add(state1);
            con1.Add(state2);

            Console.WriteLine("Государства:");
            con1.ShowList();
            Console.WriteLine("Отсортировавнные Острова");
            contr.SortIsland();
            Console.WriteLine("Колисество морей на Земле: " + contr.NumOfSeas());

            Console.WriteLine("Дополнительное задание 1");
            string path = "C:\\Users\\Яна\\Desktop\\lab\\sem3\\OOP\\labs\\lab6\\LAB6\\Earth.txt";
            List<Earth> collection = EarthController.ReadFile(path);
            foreach (Earth i in collection)
            {
                Console.WriteLine(i);
            }

            /*Console.WriteLine("Read from JSON \n");
            string path1 = "";
            using (StreamReader sr = new StreamReader(path1))
            {
                string file = sr.ReadToEnd();
                //Mammals animal2 = JsonConvert.DeserializeObject<Mammals>(file);
                Console.WriteLine(animal2);
            }*/
        }

    }
}
