using System;

namespace lab4
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack numbers = new Stack(10);
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);
            numbers.Push(6);
            numbers--;
            numbers = numbers+7;
            
            while (!numbers.IsEmpty)
            {
                int numb = numbers.Pop();
                Console.WriteLine(numb);
            }
        }
    }
}


