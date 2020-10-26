using System;

namespace lab4
{

    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);
            numbers.Push(6);
            while (!numbers.IsEmpty)
            {
                int numb = numbers.Pop();
                Console.WriteLine(numb);
            }
        }
    }
}


