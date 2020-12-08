using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB10
{
    class OrderDictionaryEnumerator : IDictionaryEnumerator
    {
        public ArrayList _ordered;
        int position = -1;
        public OrderDictionaryEnumerator(ArrayList ordered)
        {
            _ordered = ordered;
        }

        public object Key
        {
            get
            {
                try
                {
                    return ((DictionaryEntry)_ordered[position]).Key;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public object Value
        {
            get
            {
                try
                {
                    return ((DictionaryEntry)_ordered[position]).Value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public DictionaryEntry Entry { get { return (DictionaryEntry)Current; } }

        public object Current
        {
            get
            {
                try
                {
                    return _ordered[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }

            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _ordered.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
