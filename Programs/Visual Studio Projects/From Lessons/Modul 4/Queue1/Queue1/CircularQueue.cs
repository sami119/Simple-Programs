using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class CircularQueue<T>
    {
        private const int DefaultCapacity = 16;
        private T[] items;
        private int startIndex;
        private int endIndex;
        public int Count { get; private set; }
        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.items = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (this.Count >= items.Length)
            {
                Grow();
            }

            this.items[this.endIndex] = item;
            this.endIndex = (this.endIndex + 1) % this.items.Length;
            this.Count++;
        }

        private void Grow()
        {
            T[] newElements = new T[2 * this.items.Length];
            this.CopyAllElementsTo(newElements);
            this.items = newElements;
            this.startIndex = 0;
            this.endIndex = Count;
        }

        private void CopyAllElementsTo(T[] destination)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                destination[destinationIndex] = this.items[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.items.Length;
                destinationIndex++;
            }
        }
        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            T item = this.items[startIndex];
            startIndex = (startIndex + 1) % this.items.Length;
            Count--;

            return item;
        }

        public T[] ToArray()
        {
            T[] resultArray = new T[this.Count];
            CopyAllElementsTo(resultArray);
            return resultArray;
        }
    }
}
