using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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
            Lang2.NewPr();


            StringBuilder str = new StringBuilder("Never?  gonna give you   up! " +
                " Never  gonna. run, around and :desert you");
            Console.WriteLine(str);
            Action<StringBuilder> stCh = StringChanger.DeletePunctiantion;
            stCh += Console.WriteLine;
            stCh += StringChanger.DeletePunctiantion;
            stCh += StringChanger.DeleteSpaces;
            stCh += Console.WriteLine;
            stCh += StringChanger.InsertString;
            stCh += Console.WriteLine;
            stCh += StringChanger.ToLowerCase;
            stCh += Console.WriteLine;
            stCh += StringChanger.ToUpperCase;
            stCh += Console.WriteLine;

            stCh(str);
        }
    }
}
