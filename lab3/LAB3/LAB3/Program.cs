using System;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {

            int flag = 0;
            Airline[] PlaneArr;
            PlaneArr[1] = Plane1;//экземпляр

            Console.WriteLine("Введите пункт назначения");
            string dest = Console.ReadLine();
            Console.WriteLine("Номера самолетов по заданному пункту назначения:");
            foreach ( var plane in PlaneArr)//по пункту назначения
            {
                if ( plane.Destination == dest)
                {
                    Console.WriteLine(plane.Numb);
                    flag++;
                }
            }
            if (flag == 0) Console.WriteLine("Словпадений не найдено!");
            flag = 0;
            foreach (var plane in PlaneArr)//по дню недели
            {
                if (plane.Destination == dest)
                {
                    Console.WriteLine(plane.Numb);
                    flag++;
                }
            }
            if (flag == 0) Console.WriteLine("Словпадений не найдено!");

            var SomePlane = new {/*поля*/};
            //GetType
            //информация
        }
    }
}
