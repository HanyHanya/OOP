using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
        public partial class Earth
        {
            public Earth() { }
            public string name;
            public int NumOfIslands;
            public Earth(string _name) { name = _name; }
            public virtual void What()
            {
                Console.WriteLine("On Earth");
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
            public Continent(int _num)
            {
                try
                {
                if (_num < 0)
                    throw new InvalidNumberException("Количество государств на континенте не может быть меньше нуля!", _num);
                }
                catch(InvalidNumberException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Значение будет заменено на 0.");
                    _num = 0;
                }
                NumOfIslands = _num;
            }
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
            public State(string _name) : base(_name)
            {
                try
                {
                    foreach (char ch in _name)
                    {
                        if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
                            throw new InvalidNameException("Название государства не может содержать цифр!");
                    }
                }
                catch (InvalidNameException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Значение будет заменено на State.");
                    _name = "State";
                }
                name = _name;
            }
        }
        public sealed class Island : Land, OnEarth
        {
            public Island(string _name) { name = _name; }
            public Island(int _num)
            {
                try
                {
                    if (_num < 0)
                        throw new InvalidNumberException("Количество государств на острове не может быть меньше нуля!", _num);
                }
                catch (InvalidNumberException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Значение будет заменено на 0.");
                    _num = 0;
                }
                NumOfIslands = _num;
            }
            public override void What()
            {
                Console.WriteLine("It is land");
            }
        }

        public class Sea : Water, OnEarth
        {
            public Sea() { }
            public Sea(int _num) 
            {
                try
                {
                    if (_num > 0)
                        throw new InvalidNumberException("В море не может быть государств!", _num);
                }
                catch (InvalidNumberException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Значение будет заменено на 0.");
                    _num = 0;
                }
                NumOfIslands = _num; 
            }
            public Sea(string _name) 
            {
                name = _name; 
            }
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
            public Ocean(int _num) { NumOfIslands = _num; }
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

        

    }


