using System;
using System.Collections.Generic;

namespace LAB6
{
    public partial class Earth
    {
        public Earth() { }
        public string name;
        public Earth(string _name) { name = _name; }
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

    public class Land : Earth { }

    public abstract class Water : Earth { }

    public partial class Continent : Land, OnEarth
    {
        public Continent(string _name) 
        {
            name = _name;
        }
        public virtual void What()
        {
            Console.WriteLine("It is land");
        }

    }

    public class State : Continent
    {
        public State(string _name)
        {
            name = _name;
        }
    }
    public sealed class Island : Land, OnEarth
    {
        public Island(string name) { }
        public override void What()
        {
            Console.WriteLine("It is land");
        }
    }

    public class Sea : Water, OnEarth
    {
        public Sea() { }
        public Sea(string name) { }
        public override void What()
        {
            Console.WriteLine("It is water");
        }
        public virtual bool IsStateHere()
        {
            return false;
        }
    }
    public class Ocean : Water, OnEarth
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

    struct User//структура
    {
        public string name;
        public int age;
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
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
}
