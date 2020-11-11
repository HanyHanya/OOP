using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LAB6
{
    public partial class Earth
    {
        List<Earth> earth = new List<Earth>();//контейнер
        public List<Earth> EarthL { get => earth; }
        public void Add(Earth obj)
        {
            earth.Add(obj);
        }

        public Earth Remove(Earth obj)
        {
            foreach (Earth elem in earth)
            {
                if (obj == elem)
                {
                    earth.Remove(obj);
                    return obj;
                }
            }
            return null;
        }
        
        public void ShowList()
        {
            foreach (Earth elem in earth)
            {
                Console.WriteLine(elem.name);
            }
        }
    }

    public class EarthController 
    {
        //List<Earth> earth = new List<Earth>();
        public void SortIsland(List<Earth> newlist)
        {
            int n = 0, i = 0;
            foreach (Earth elem in newlist)
            {
                if (elem is Island)
                {
                    n++;
                }
            }
            
            string[] IslandArr = new string[n];
            foreach (Earth elem in newlist)
            {
                if (elem is Island)
                {
                    IslandArr[i] = elem.name;
                    i++;
                }
            }
            Console.WriteLine("Не Сортировавнные Острова");
            foreach (string elem in IslandArr)
            {
                Console.WriteLine(elem);
            }
            Array.Sort(IslandArr);
            Console.WriteLine("Отсортировавнные Острова");
            foreach (string elem in IslandArr)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
        }

        public int NumOfSeas(List<Earth> newlist)
        {
            int n = 0;
            foreach (Earth elem in newlist)
            {
                if (elem is Island)
                {
                    n++;
                }
            }
            return n;
        }

    }
}
