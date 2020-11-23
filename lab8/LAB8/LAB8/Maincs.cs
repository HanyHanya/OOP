using System;
using System.Collections.Generic;
using System.Text;

namespace LAB8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "C:\\Users\\Яна\\Desktop\\lab\\sem3\\OOP\\labs\\lab8\\File.txt";
                Stack<int> numbers1 = new Stack<int>(10);
                Stack<Earth> numbers2 = new Stack<Earth>(10);
                Island island1 = new Island("Island1");
                Sea sea1 = new Sea("Sea1");
                Ocean ocean1 = new Ocean("Ocean1");
                Continent con1 = new Continent("Continent1");
                numbers1.Push(1);
                numbers1.Push(2);
                numbers1.Push(3);
                numbers1--;
                numbers1 = numbers1 + 7;
                numbers1.Show();
                numbers1.ToFile(filePath);
                Console.WriteLine();
                numbers2.Push(sea1);
                numbers2.Push(island1);
                numbers2.Push(ocean1);
                numbers2.Push(con1);
                numbers2.Show();
                numbers2.ToFile(filePath);
            }
            catch(Exception)
            {
                Console.WriteLine("Уопс, сломалось(((");
            }
            finally
            { 
                Console.WriteLine("It Workssssssssss"); 
            }
            
        }
    }
}
