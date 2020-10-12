using System;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {

            Airline Plane1 = new Airline("Москва", "Понедельник", 1);
            Airline Plane2 = new Airline("Берлин", "Вторник", 2);
            Airline Plane3 = new Airline("Париж", "Среда", 3);
            Airline Plane4 = new Airline("Москва", "Понедельник", 1);

            Airline[] PlaneArr = { Plane1 , Plane2, Plane3};

            Console.WriteLine("Тип созданного объекта: " + Plane1.GetType());
            Console.WriteLine("Cравнение объектов Plane1 и Plane2: " + Plane1.Equals(Plane2));
            Console.WriteLine("Cравнение объектов Plane1 и Plane4: " + Plane1.Equals(Plane4));

            bool flag = false;
            Console.WriteLine("Введите пункт назначения");
            string dest = Console.ReadLine();
            Console.WriteLine("Номера самолетов по заданному пункту назначения:");
            foreach ( var plane in PlaneArr)//по пункту назначения
            {
                if ( plane.Destination == dest)
                {
                    Console.WriteLine(plane.Numb);
                    flag = true;
                }
            }
            if (!flag) Console.WriteLine("Словпадений не найдено!");
            flag = false;
            Console.WriteLine("Введите день вылета");
            string days = Console.ReadLine();
            Console.WriteLine("Номера самолетов по дню вылета:");
            foreach (var plane in PlaneArr)//по дню недели
            {
                if (plane.Days == days)
                {
                    Console.WriteLine(plane.Numb);
                    flag = true;
                }
            }
            if (!flag) Console.WriteLine("Словпадений не найдено!");

            var SomePlane = new { destination="Париж", days="Среда", numb=3 };
            Console.WriteLine("Тип анонимного объекта: " + SomePlane.GetType());
            Console.WriteLine($"Пункт назначения: {SomePlane.destination}\n" +
                              $"Дата вылета: {SomePlane.days}\n" +
                              $"Номер рейса: {SomePlane.numb}");
        }
    }
}
