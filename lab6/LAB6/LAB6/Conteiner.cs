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
                Console.WriteLine(elem);
            }
        }
    }

    public class EarthController : Earth
    {
        List<Earth> earth = new List<Earth>();
        public void SortIsland()
        {
            int n = 0, i = 0;
            foreach (Island elem in earth)
            {
                n++;
            }
            string[] IslandArr = new string[n];
            foreach (Island elem in earth)
            {
                IslandArr[i] = elem.name;
                i++;
            }
            Array.Sort(IslandArr);
            foreach (string elem in IslandArr)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
        }

        public int NumOfSeas()
        {
            int n = 0;
            foreach (Sea elem in earth)
            {
                n++;
            }
            return n;
        }

        static public List<Earth> ReadFile(string path)
        {
            List<Earth> earthObj = new List<Earth>();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string[] fileString;
                    while (!reader.EndOfStream)
                    {
                        fileString = reader.ReadLine().Split(" ");
                        Earth elem = new Earth(Convert.ToString(fileString[0]));
                        earthObj.Add(elem);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return earthObj;
        }
    }
}
