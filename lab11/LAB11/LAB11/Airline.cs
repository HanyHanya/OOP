using System;
using System.Collections.Generic;
using System.Text;

namespace LAB11
{
    public partial class Airline
    {
        private string destination;//пункт назначения
        public uint numb;//номер рейса
        public string type;//тип самолета
        public int time;//время вылета
        private string days;//дни недели
        private const string airport = "Минск-1";
        private readonly int planeID;
        static int NumbOfPlanes = 0;

        //конструкторы
        public Airline(string des, string d, uint n, int t, string typ)//c параметрами
        {
            destination = des;
            days = d;
            numb = n;
            time = t;
            type = typ;
            planeID = GetHashCode();
            NumbOfPlanes++;
        }
        public Airline(int t, uint numb = 1)//с параметром по умолчанию
        {
            time = t;
            planeID = GetHashCode();
            NumbOfPlanes++;
        }
        private Airline()//без параметров, вызывать через методы
        {
            destination = "Неизвестно";
            numb = 0;
            time = 0;
            days = "Неизвестно";
            planeID = GetHashCode();
            NumbOfPlanes++;
        }
        /*static Airline()//статический конструктор
        {
            type = "Пассажирский";
        }*/

        //свойства
        public string Destination
        {
            get { return destination; }
            set
            {
                if (!string.IsNullOrEmpty(value))//проверка
                    destination = value;
            }
        }
        public uint Numb
        {
            get
            { return numb; }
            set { numb = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public string Days
        {
            get { return days; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    days = value;
            }//ограничен set
        }


        //методы
        public static Airline addPlane()//способ вызова приватного конструктора
        {
            return new Airline();
        }
        /*public static void ShowInfo()
        {
            Console.WriteLine("Тип Самолетов: " + Airline.type);
            Console.WriteLine($"Количество самолетов: {Airline.NumbOfPlanes}");
        }*/
    }
    public partial class Airline
    {
        //переопределение
        public override int GetHashCode()
        {
            return HashCode.Combine(destination, numb, type, time, days);
        }
        public override bool Equals(object obj)
        {
            if (obj is Airline objectType)
            {
                if (this.destination == objectType.destination && this.numb == objectType.numb &&
                    this.time == objectType.time && this.days == objectType.days)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return $"Пункт назначения: {destination},\n Номер рейса: {numb},\n" +
                   $"Тип самолета: {type},\n Врема вылета: {time},\n " +
                   $"День вылета: {days}\n";
        }
    }

    public class Person
    {
        public string _name;
        public Person(string n)
        {
            _name = n;
        }

    }
    public class Cat
    {
        public string _name;
        public string _owner;
        public Cat( string n, string o)
        {
            _name = n;
            _owner = o;
        }

    }
}
