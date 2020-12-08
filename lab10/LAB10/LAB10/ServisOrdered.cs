using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB10
{
    class ServisOrdered : IOrderedDictionary
    {
        private ArrayList _ordered;

        public ServisOrdered()
        {
            _ordered = new ArrayList();
        }

        public int IndexOfKey(object key)
        {
            for (int i = 0; i < _ordered.Count; i++)
            {
                if (((DictionaryEntry)_ordered[i]).Key == key)
                {
                    return i;
                }
            }

            return -1;
        }

        public object this[object key]
        {
            get { return ((DictionaryEntry)_ordered[IndexOfKey(key)]).Value; }
            set { _ordered[IndexOfKey(key)] = new DictionaryEntry(key, value); }
        }

        public object this[int index]
        {
            get { return ((DictionaryEntry)_ordered[index]).Value; }
            set { _ordered[index] = new DictionaryEntry(((DictionaryEntry)_ordered[index]).Key, value); }
        }

        public ICollection Keys
        {
            get
            {
                ArrayList keyCollection = new ArrayList();
                for (int i = 0; i < _ordered.Count; i++)
                {
                    keyCollection.Add(((DictionaryEntry)_ordered[i]).Key);
                }
                return keyCollection;
            }
        }

        public ICollection Values
        {
            get
            {
                ArrayList valueCollection = new ArrayList();
                for (int i = 0; i < _ordered.Count; i++)
                {
                    valueCollection.Add(((DictionaryEntry)_ordered[i]).Value);
                }
                return valueCollection;
            }
        }

        public bool IsReadOnly { get { return false; } }

        public bool IsFixedSize { get { return false; } }

        public int Count { get { return _ordered.Count; } }

        public object SyncRoot { get { return _ordered.SyncRoot; } }

        public bool IsSynchronized { get { return _ordered.IsSynchronized; } }

        public void Add(object key, object value)
        {
            if (IndexOfKey(key) != -1)
            {
                throw new ArgumentException("Попытка добавить существующий элемент");
            }
            _ordered.Add(new DictionaryEntry(key, value));
        }

        public void Clear()
        {
            _ordered.Clear();
        }

        public bool Contains(object key)
        {
            if (IndexOfKey(key) == -1)
            {
                return false;
            }
            else return true;
        }

        public void CopyTo(Array array, int index)
        {
            _ordered.CopyTo(array, index);
        }


        public void Insert(int index, object key, object value)
        {
            if (IndexOfKey(key) != 1)
            {
                throw new ArgumentException("Попытка добавить существующий элемент");
            }
            else
            {
                _ordered.Insert(index, new DictionaryEntry(key, value));
            }
        }

        public void Remove(object key)
        {
            _ordered.RemoveAt(IndexOfKey(key));
        }

        public void RemoveAt(int index)
        {
            _ordered.RemoveAt(index);
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return new OrderDictionaryEnumerator(_ordered);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new OrderDictionaryEnumerator(_ordered);
        }
    }
}
