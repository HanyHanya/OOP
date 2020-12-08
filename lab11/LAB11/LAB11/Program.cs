using System;
using System.Linq;
using System.Collections.Generic;

namespace LAB11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int n;
            Console.Write("Введите длину слова: ");
            n = Convert.ToInt32(Console.ReadLine());
            var SelectedMonth = from m in month where m.Length == n select m;
            Console.WriteLine($"Месяца длиной {n}:");
            foreach (string s in SelectedMonth)
                Console.WriteLine(s);
            Console.WriteLine();

            SelectedMonth = from m in month where m == "June" || m == "July" || m == "August" select m;
            Console.WriteLine("Летние:");
            foreach (string s in SelectedMonth)
                Console.WriteLine(s);
            Console.WriteLine();

            SelectedMonth = from m in month where m == "December" || m == "January" || m == "February" select m;
            Console.WriteLine("Зимние:");
            foreach (string s in SelectedMonth)
                Console.WriteLine(s);
            Console.WriteLine();

            SelectedMonth = from m in month orderby m select m;
            Console.WriteLine("Месяца в алфавитном порядке:");
            foreach (string s in SelectedMonth)
                Console.WriteLine(s);
            Console.WriteLine();

            //Задание 2
            List<Airline> Planes = new List<Airline>();
            Airline Plane1 = new Airline("Минск", "Понедельник", 1, 1, "П");
            Airline Plane2 = new Airline("Москва", "Вторник", 2, 2, "П");
            Airline Plane3 = new Airline("Минск", "Среда", 3, 3, "П");
            Airline Plane4 = new Airline("Москва", "Четверг", 4, 4, "П");
            Airline Plane5 = new Airline("Минск", "Пятница", 5, 5, "Г");
            Airline Plane6 = new Airline("Москва", "Суббота", 6, 6, "Г");
            Airline Plane7 = new Airline("Москва", "Воскресенье", 7, 7, "Г");
            Airline Plane8 = new Airline("Минск", "Понедельник", 8, 8, "Г");
            Planes.Add(Plane1);
            Planes.Add(Plane2);
            Planes.Add(Plane3);
            Planes.Add(Plane4);
            Planes.Add(Plane5);
            Planes.Add(Plane6);
            Planes.Add(Plane7);
            Planes.Add(Plane8);

            //Задание 3
            var SelectPlanes = from plane in Planes where plane.Destination == "Минск" select plane;
            Console.WriteLine("Номера самолетов, летящих в Минск: ");
            foreach (var p in SelectPlanes)
                Console.Write(p.numb + " ");
            Console.WriteLine();

            SelectPlanes = from plane in Planes where plane.Days == "Понедельник" select plane;
            Console.WriteLine("Номера самолетов, летящих в понедельник: ");
            foreach (var p in SelectPlanes)
                Console.Write(p.numb + " ");
            Console.WriteLine();

            SelectPlanes = from plane in Planes where plane.Days == "Понедельник" select plane;
            Console.WriteLine("Номер самого позднего самолета, летящего в понедельник: ");
            Console.WriteLine(SelectPlanes.Max(p => p.time));

            SelectPlanes = from plane in Planes orderby plane.time select plane;
            Console.WriteLine("Номера самолетов, отсортированные по времени вылета: ");
            foreach (var p in SelectPlanes)
                 Console.WriteLine("Номер: "+ p.numb + ". Время:" +p.time);
            Console.WriteLine();

            SelectPlanes = from plane in Planes where plane.type == "П" select plane;
            int i = 0;
            foreach (var p in SelectPlanes) i++;
            Console.WriteLine($"Количество пассажирских самолетов: {i}.") ;
            Console.WriteLine();

            //Задание 4
            Console.WriteLine("Все грузовые самолеты:");
            var SPlanes = from p in Planes.Skip(2)
                          where p.numb >= 3
                          where p.type == "Г"
                          orderby p.time descending
                          select p;

            foreach (var p in SPlanes)
                Console.WriteLine(p);
            Console.WriteLine();

            Person p1 = new Person("Owner1");
            Person p2 = new Person("Owner2");
            Cat c1 = new Cat("Cat1", "Owner1");
            Cat c2 = new Cat("Cat2", "Owner2");

            List<Person> Persones = new List<Person>();
            List<Cat> Cats = new List<Cat>();
            Persones.Add(p1);
            Persones.Add(p2);
            Cats.Add(c1);
            Cats.Add(c2);

            var Result = from c in Cats
                         join p in Persones on c._owner equals p._name
                         select new { name = c._name, owner = p._name};
            foreach ( var r in Result)
                Console.WriteLine($"Имя питомца - {r.name}; имя хозяина - {r.owner}");
            Console.WriteLine();
        }
    }
}
