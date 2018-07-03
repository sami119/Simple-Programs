using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedList
{
    class ReversedList<T> : IEnumerable<T>
    {
        private const int initialCapacity = 2;

        public T[] items;

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
            set
            {
                this.capacity = value;
            }
        }

        public ReversedList()
        {
            capacity = initialCapacity;
            this.items = new T[this.capacity];
        }

        private T this[int index]
        {
            get
            {
                OutOfRange(index);
                return this.items[index];
            }
            set
            {
                OutOfRange(index);
                this.items[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Capacity == this.Count)
            {
                Capacity *= 2; // Expand
                T[] temp = new T[Capacity];

                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.items[i];
                }
                this.items = temp;
            }
            this.items[this.Count++] = element;
        }

        public T RemoveAt(int index)
        {
            OutOfRange(index);
            T element = this.items[index];
            var step1 = items.Take(Count).Reverse().Concat(new T[Capacity - Count]);
            var step2 = step1.Take(index).Concat(step1.Skip(index + 1)).ToArray().Concat(new T[Capacity - Count]);
            var step3 = step2.Take(--Count).Reverse().Concat(new T[Capacity - Count]);
            this.items = step3.ToArray();
            return element;
        }

        public void OutOfRange(int index)
        {
            if(index < 0 || index > capacity)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
