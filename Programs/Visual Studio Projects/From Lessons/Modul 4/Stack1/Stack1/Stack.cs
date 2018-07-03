using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    class Stack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        public const int DefaultCapacity = 16;
        public Stack(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
        }

        public void Push(T item)
        {
            if (this.Count == this.elements.Length)
            {
                Grow();
            }
            elements[this.Count] = item;
            this.Count++;
        }
        private void Grow()
        {
            T[] newArray = new T[2 * this.elements.Length];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[i];   
            }
            this.elements = newArray;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }
            T element = this.elements[this.Count - 1];
            this.Count--;
            //todo: add shrink method
            return element;
        }

        public T[] ToArray()
        {
            T[] result = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                result[i] = this.elements[i];
            }

            return result;
        }
    }
}
