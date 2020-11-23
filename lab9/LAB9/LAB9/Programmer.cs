using System;
using System.Collections.Generic;
using System.Text;

namespace LAB9
{
    public delegate void Language(string message);
    public class Programmer
    {
        
        public string name;
        public int numOfPr = 0;
        public Programmer() { }
        public Programmer(string n) { name = n; }
        public Programmer(string s, int n) { name = s; numOfPr = n; }
        public event Language Renamed;
        public event Language Added;
        public void Rename(string str)
        {
            name = str;
            Renamed?.Invoke($"Переименовано на {name}!");
        }
        public int NewPr()
        {
            numOfPr++;
            Added?.Invoke($"Добавлено свойство! Их теперь {numOfPr}");
            return numOfPr;
        }
    }

}
