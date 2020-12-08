using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB10
{
    class Services
    {
        public string _name;
        public Services(string name)
        {
            _name = name;
        }
        public void TryThis()
        {
            Console.WriteLine("I like it!");
        }
        public override string ToString()
        {
            return $"{_name}";
        }
    }

    public class Cost
    {
        public int _name;

        public Cost (int name)
        {
            _name = name;
        }
    }
}
