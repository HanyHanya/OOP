using System;
using System.Collections.Generic;
using System.Text;

namespace LAB8
{
     public class Earth
    {
        public string Name;
        public Earth() { }
        public virtual void What()
        {
            Console.WriteLine("On Earth");
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
        public Continent(string name) { Name = name; }
        public virtual void What()
            {
                Console.WriteLine("It is land");
            }

        }

        public sealed class Island : Land, OnEarth, State
        {
            public Island() { }
            public Island(string name) { Name = name; }
        public override void What()
            {
                Console.WriteLine("It is land");
            }
        }

        public class Sea : Water, OnEarth, State
        {
            public Sea() { }
            public Sea(string name) { Name = name; }
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
            public Ocean(string name) { Name = name; }
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
