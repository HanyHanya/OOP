using System;

namespace lab4
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack numbers1 = new Stack(10);
            Stack numbers2 = new Stack(10);
            numbers1.Push(1);
            numbers1.Push(2);
            numbers1.Push(3);
            numbers2.Push(4);
            numbers2.Push(5);
            numbers2.Push(6);
            numbers1--;
            numbers1 = numbers1+7;
            numbers1.Show();
            Console.WriteLine();
            numbers1 = numbers1 > numbers2;
            numbers1.Show();
        }
    }
}


