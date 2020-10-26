﻿using System;
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
            // увеличиваем стек
            /*if (count == items.Length)
                Resize(items.Length + 10);*/

            items[count++] = item;
        }
        public int Pop()//поп :)
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            int item = items[--count];
           
           /* if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);*/

            return item;
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

        /*private void Resize(int max)//изменение максимальной длины
        {
            S[] tempItems = new S[max];
            for (int i = 0; i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }*/


    }
}
