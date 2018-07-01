using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class ArrayList<T>
    {
        private const int Initial_Size = 2;
        private T[] items;

        private int count;
        public int Count
        {
            get
            {
                return count;
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
                return capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public ArrayList()
        {
            this.items = new T[Initial_Size];
        }

        public T this[int index]
        {
            get
            {
                if(index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[index];
            }
            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count++] = item;
        }

        private void Resize()
        {
            T[] copy = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public T Get(int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }
            return this.items[index];
        }

        public void Set(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }
            this.items[index] = item;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }
            count--;
            var item = this.items[index];
            items = items.Take(index).Concat(items.Skip(index + 1)).ToArray();
            return item;
        }
    }
}
