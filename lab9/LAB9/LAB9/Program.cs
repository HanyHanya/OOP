using System;

namespace LAB9
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer Lang1 = new Programmer("C");
            Programmer Lang2 = new Programmer("C", 5);
            Lang1.Renamed += mes => Console.WriteLine(mes);
            Lang1.Added += mes => Console.WriteLine(mes);
            Lang2.Renamed += mes => Console.WriteLine(mes);
            Lang2.Added += mes => Console.WriteLine(mes);
            Lang1.Rename("C++");
            Lang1.NewPr();

            Lang2.Rename("C#");
            Lang2.NewPr();

        }
    }
}
