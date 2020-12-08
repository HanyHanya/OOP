using System;
using System.Collections.Generic;
using System.Text;

namespace LAB10
{
    class ObservableCollection<T>
    {
        public delegate void EventHandler(string message);
        public event EventHandler CollectionWasChanged;

        List<T> list;
        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        public ObservableCollection()
        {
            list = new List<T>();
        }

        public void Add(T newEl)
        {
            list.Add(newEl);
            CollectionWasChanged?.Invoke($"Добавлен элемент: {newEl}");
        }
        public void Remove(T newEl)
        {
            list.Remove(newEl);
            CollectionWasChanged?.Invoke($"Удален элемент: {newEl}");
        }

    }
}
