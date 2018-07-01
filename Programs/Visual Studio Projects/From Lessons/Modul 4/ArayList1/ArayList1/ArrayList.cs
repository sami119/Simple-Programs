using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayList1
{
    public class ArrayList<T>
    {
        private T[] items;

        private const int initialCapacity = 2;

        private int count;
        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        private int capacity;
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public ArrayList()
        {
            this.items = new T[initialCapacity];
            capacity = initialCapacity;
        }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.items[index];
            }
            set
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                Capacity = Capacity * 2;
                T[] copy = new T[Capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    copy[i] = items[i];
                }
                copy[Count] = item;
                Count++;
                items = copy;
            }
            else
            {
                this.items[Count] = item;
                Count++;
            }
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return this.items[index];
        }

        public void Set(int index, T item)
        {
            if (index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            this.items[index] = item;
        }
        /*
                public T RemoveAt(int index) { }*/
    }

}
