using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10
{
    class Program
    {
        static ObservableCollection<Services> observable;
        static void ObsCollectionEventHandler(string Message) => Console.WriteLine(Message);

        static void Main(string[] args)
        {
            Services Servis1 = new Services("Услуга 1");
            Services Servis2 = new Services("Услуга 2");
            Services Servis3 = new Services("Услуга 3");

            Cost one = new Cost(1);
            Cost two = new Cost(2);
            Cost three = new Cost(3);

            ServisOrdered ordered = new ServisOrdered();

            ordered.Add(one, Servis1);
            ordered.Add(two, Servis2);
            Console.WriteLine($"В коллекции содержится услуга со стоимостью 3? {ordered.Contains(three)}");
            ordered.Add(three, Servis3);
            Console.WriteLine($"А сейчас? {ordered.Contains(three)}");
            Console.WriteLine();
            foreach (DictionaryEntry order in ordered)
            {
                Console.Write($"Услуга: {((Services)order.Value)._name}. ");
                Console.WriteLine($"Стоимость: {((Cost)order.Key)._name}.");
            }
            Console.WriteLine();
            ordered.Remove(one);
            Console.WriteLine($"Удалена услуга со стоимостью 1.");
            Console.WriteLine();

            foreach (DictionaryEntry order in ordered)
            {
                Console.Write($"Услуга: {((Services)order.Value)._name}. ");
                Console.WriteLine($"Стоимость: {((Cost)order.Key)._name}.");
            }

            //Задание 2
            Queue intQ = new Queue();
            for (int i = 1; i < 10; i++)
                intQ.Enqueue(new Random().Next(10));
            Console.WriteLine("Список:");
            foreach (var i in intQ)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("Введите кол-во элементов, которое необходимо удалить");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0 || n >= intQ.Count)
                Console.WriteLine("Введено неверное значение");
            else
            {
                for (int i = 0; i < n; i++)
                    intQ.Dequeue();
            }
            Console.WriteLine("Список после удаления");
            foreach (var i in intQ)
                Console.Write(i + " ");
            Console.WriteLine();

            Stack newIntStack = new Stack(intQ);
            Console.WriteLine("Стек:");
            foreach (var el in newIntStack)
                Console.Write(el + " ");
            Console.WriteLine();

            int length = newIntStack.Count;
            for (int i = 1; i <= length; i++)
            {
                int Element = Convert.ToInt32(newIntStack.Pop());
                if (Element % 2 == 0)
                    Console.WriteLine($"Найдено четное число - {Element} ");
            }

            //Задание 3
            var obsCol = new ObservableCollection<Services>();

            Console.WriteLine("\nОбозреваемая коллекция:");
            obsCol.CollectionWasChanged += ObsCollectionEventHandler;
            obsCol.Add(Servis1);
            obsCol.Add(Servis2);
            obsCol.Remove(Servis1);
            obsCol.Remove(Servis2);

        }
    }
}
