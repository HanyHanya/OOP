using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class Stack<S>
    {
        private S[] items;
        private int count;//количество элементов в стеке
        const int n = 10;//максимальное количество элементов
        public Stack()
        {
            items = new S[n];
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
            // увеличиваем стек
            /*if (count == items.Length)
                Resize(items.Length + 10);*/

            items[count++] = item;
        }
        public S Pop()//поп :)
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            S item = items[--count];
           
           /* if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);*/

            return item;
        }
        public S Peek()//чтение верхнего элемента
        {
            return items[count - 1];
        }

        /*private void Resize(int max)//изменение максимальной длины
        {
            S[] tempItems = new S[max];
            for (int i = 0; i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }*/


    }
}
