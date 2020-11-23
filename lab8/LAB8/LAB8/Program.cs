using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LAB8
{
    public class Stack<S> where S : new()//универсальный параметр должен представлять тип, который имеет общедоступный (public) конструктор без параметров
    {
        private S[] items;
        private int count;//количество элементов в стеке
        private int capacity;//максимальное количество элементов
        public Stack(int initCap = 0)
        {
            capacity = initCap;
            items = new S[initCap];
        }

        public bool IsEmpty//пуст или нет
        {
            get { return count == 0; }
        }
        public int Count//количество элементов
        {
            get { return count; }
        }

        public void Push(S item)//добавление
        {
            items[count++] = item;
        }
        public S Pop()//поп :)
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            S item = items[--count];

            return item;
        }
        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] != null)
                    Console.WriteLine(items[i]);

            }
        }
        public S Peek()//чтение верхнего элемента
        {
            return items[count - 1];
        }

        //перегрузка
        public static Stack<S> operator +(Stack<S> stack, S item)
        {
            stack.Push(item);
            return stack;
        }

        public static Stack<S> operator --(Stack<S> stack)
        {
            stack.Pop();
            return stack;
        }

        public static Stack<S> operator >(Stack<S> stack1, Stack<S> stack2)
        {

            int i = stack1.items.Length;
            Array.Resize<S>(ref stack1.items, stack1.items.Length + stack2.items.Length);
            Array.Copy(stack2.items, 0, stack1.items, i, stack2.items.Length);
            Array.Sort(stack1.items);
            return stack1;
        }
        public static Stack<S> operator <(Stack<S> stack1, Stack<S> stack2)
        {

            int i = stack1.items.Length;
            Array.Resize<S>(ref stack1.items, stack1.items.Length + stack2.items.Length);
            Array.Copy(stack2.items, 0, stack1.items, i, stack2.items.Length);
            Array.Sort(stack1.items);
            Array.Reverse(stack1.items);
            return stack1;
        }

        public static bool operator true(Stack<S> stack)
        {
            return stack.items[0] != null;
        }

        public static bool operator false(Stack<S> stack)
        {
            return stack.items[0] == null;
        }

        ///////2
        internal class Owner
        {
            private string Id { get; }
            private string Name { get; }
            private string Organisation { get; }

            public Owner(string id, string name, string org)
            {
                Id = id;
                Name = name;
                Organisation = org;
            }
            public override string ToString()
            {
                return $"ID владельца - {Id},\nИмя владельца - {Name},\nОрганизация - {Organisation} ";
            }
        }

        ///////////3
        public class Date
        {
            private int Day { get; }
            private int Month { get; }
            private int Year { get; }

            public Date()
            {
                DateTime date = DateTime.Now;
                Day = date.Day;
                Month = date.Month;
                Year = date.Year;
            }
        }

        public void ToFile(string filePath)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine("\n--------------------\n");
                foreach (S obj in items)
                {
                    writer.WriteLine(obj);
                    writer.WriteLine();
                }
                writer.Close(); 
            }
        }
    }
}