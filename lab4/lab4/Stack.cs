using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class Stack
    {
        private int[] items;
        private int count;//количество элементов в стеке
        private int capacity;//максимальное количество элементов
        public Stack(int initCap = 0)
        {
            capacity = initCap;
            items = new int[initCap];
        }

        public bool IsEmpty//пуст или нет
        {
            get { return count == 0; }
        }
        public int Count//количество элементов
        {
            get { return count; }
        }

        public void Push(int item)//добавление
        {
            items[count++] = item;
        }
        public int Pop()//поп :)
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            int item = items[--count];

            return item;
        }
        public void Show()
        {
            for(int i=0; i < items.Length; i++)
            {
                if(items[i]!=0)
                    Console.WriteLine(items[i]);

            }
        }
        public int Peek()//чтение верхнего элемента
        {
            return items[count - 1];
        }

        //перегрузка
        public static Stack operator +(Stack stack, int item)
        {
            stack.Push(item);
            return stack;
        }

        public static Stack operator --(Stack stack)
        {
            stack.Pop();
            return stack;
        }

        public static Stack operator >(Stack stack1, Stack stack2)
        {

            int i = stack1.items.Length;
            Array.Resize<int>(ref stack1.items, stack1.items.Length + stack2.items.Length);
            Array.Copy(stack2.items, 0, stack1.items, i, stack2.items.Length);
            Array.Sort(stack1.items);
            return stack1;
        }
        public static Stack operator <(Stack stack1, Stack stack2)
        {

            int i = stack1.items.Length;
            Array.Resize<int>(ref stack1.items, stack1.items.Length + stack2.items.Length);
            Array.Copy(stack2.items, 0, stack1.items, i, stack2.items.Length);
            Array.Sort(stack1.items);
            Array.Reverse(stack1.items);
            return stack1;
        }

        public static bool operator true(Stack stack)
         {
            return stack.items[0] != 0;
         }

        public static bool operator false(Stack stack)
        {
            return stack.items[0] == 0;
        }

    }
}
