using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    public partial class Airline
    {
        /*конструкторы должны обеспечивать проверку
          корректности.Создать массив объектов. Вывести:
          a) список рейсов для заданного пункта назначения;
          b) список рейсов для заданного дня недели;*/
        private string destination;//пункт назначения
        private uint numb;//номер рейса
        static string type;//тип самолета
        private string time;//время вылета
        private string days;//дни недели
        private const string airport = "Минск-1";
        private readonly int planeID;
        static int NumbOfPlanes = 0;

        //конструкторы
        public Airline(string des, int numb)//c параметрами
        {
            planeID = GetHashCode();
            NumbOfPlanes++;
        }
        public Airline(string t, string d, int numb = 1)//с параметром по умолчанию
        {
            time = t;
            days = d;
            planeID = GetHashCode();
            NumbOfPlanes++;
        }
        private Airline()//без параметров, вызывать через методы
        {
            destination = "Неизвестно";
            numb = 0;
            time = "00.00";
            days = "Неизвестно";
            planeID = GetHashCode();
            NumbOfPlanes++;
        }
        static Airline()//статический конструктор
        {
            type = "Пассажирский";
        }

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
        public string Time
        {
            get { return time; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    time = value;
            }
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
        public static void ShowInfo()
        {
            Console.WriteLine("Тип Самолетов: " + Airline.type);
            Console.WriteLine($"Количество самолетов: {Airline.NumbOfPlanes}");
        }
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
            if(obj is Airline objectType)
            {
                if(this.destination == objectType.destination && this.numb == objectType.numb &&
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
}
