using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    class LinearProbingHashtable : Hashtable
    {
        private object[] values;
        private int size;
        public int Size
        {
            get { return size; }
            private set { }
        }

        public LinearProbingHashtable(int initialCapacity)
        {
            if(initialCapacity < 1)
            {
                throw new ArgumentException("initialCapacity cant be < 1");
            }
            values = new object[initialCapacity];
        }

        public override void Add(object value)
        {
            EnsureCapacity();
            int index = IndexFor(value);
            if(values[index] == null)
            {
                values[index] = value;
                ++size;
            }
        }

        public override bool Contains(object value)
        {
            return IndexOf(value) != -1;
        }

        private void EnsureCapacity()
        {
            if(size == values.Length)
            {
                HashtableResize();
            }
        }

        private void HashtableResize()
        {
            LinearProbingHashtable copy = new LinearProbingHashtable(values.Length * 2);
            for (int i = 0; i < values.Length; ++i)
            {
                if (values[i] != null)
                {
                    copy.Add(values[i]);
                }
            }
            values = copy.values;
        }

        private int IndexFor(object value)
        {
            int start = StartingIndexFor(value);
            int index = IndexFor(value, start, values.Length);

            if(index == -1)
            {
                index = IndexFor(value, 0, start);
                if(index != -1)
                {
                    throw new ArgumentException("no free slots");
                }
            }
            return index;
        }

        private int IndexFor(object value, int start, int end)
        {
            if(value == null)
            {
                throw new ArgumentException("value cant be null");
            }

            for(int i = start; i < end; ++i)
            {
                if (values[i] == null || value.Equals(values[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        private int StartingIndexFor(object value)
        {
            if(value == null)
            {
                throw new ArgumentException("value cant be null");
            }
            return Math.Abs(hashCode(value.ToString()) % values.Length);
        }

        private int IndexOf(object value)
        {
            int start = StartingIndexFor(value);
            int index = IndexOf(value, start, values.Length);

            if(index == -1)
            {
                index = IndexOf(value, 0, start);
            }
            return index;
        }

        private int IndexOf(object value, int start, int end)
        {
            if (value == null)
            {
                throw new ArgumentException("value cant be null");
            }

            for(int i = start; i < end; ++i)
            {
                if (value.Equals(values[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
