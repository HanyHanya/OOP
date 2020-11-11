using System;

namespace LAB6
{
    public abstract class Earth
    {
        public virtual void What()
        {
            Console.WriteLine("On Earth");
        }
        public override string ToString()
        {
            return @$"У меня нет столько фантазии, чтобы придумывать методы и поля для ВОДЫ(и не только)";
        }
    }
    public interface OnEarth
    {
        void What();
    }
    public interface State
    {
        public bool IsStateHere()
        {
            return true;
        }
    }

    public class Land : Earth { }

    public abstract class Water : Earth { }

    public class Continent : Land, OnEarth, State
    {
        public Continent() { }
        public virtual void What()
        {
            Console.WriteLine("It is land");
        }

    }

    public sealed class Island : Land, OnEarth, State
    {
        public Island() { }
        public override void What()
        {
            Console.WriteLine("It is land");
        }
    }

    public class Sea : Water, OnEarth, State
    {
        public Sea() { }
        public override void What()
        {
            Console.WriteLine("It is water");
        }
        public virtual bool IsStateHere()
        {
            return false;
        }
    }
    public class Ocean : Water, OnEarth, State
    {
        public Ocean() { }
        public override void What()
        {
            Console.WriteLine("It is water");
        }
        public virtual bool IsStateHere()
        {
            return false;
        }
    }

    public class Print
    {
        public void IAmPrinting(Earth obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }



    ////////////////////lab6/////////////////
    enum Days//перечисление
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    struct User//структура
    {
        public string name;
        public int age;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
}
