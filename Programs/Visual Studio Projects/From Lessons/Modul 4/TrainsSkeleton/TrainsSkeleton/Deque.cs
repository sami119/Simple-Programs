using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    public class Deque<T>
    {
        private const int defaultCapacity = 16;
        public int Capacity { get; private set; } //показва капацитета
        public int Count { get; private set; } //показва броят елементи
        public T[] collection;

        public Deque() : this(defaultCapacity)
        {
            //празен конструктор, задава капацитета на дека на стойността по подразбиране (16)
        }

        public Deque(int capacity)
        {
            //създава дека с точно зададен капацитет
            collection = new T[capacity];
            Capacity = capacity;
            Count = 0;
        }

        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            collection = collection.ToArray();
            Capacity = collection.Count();
            Count = collection.Count();
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
        }

        public void AddFront(T item)
        {
            if(Capacity == Count)
            {
                Capacity *= 2;
                Array.Resize(ref collection, Capacity);
            }
            collection[Count++] = item;
            //добавя елемент отпред
        }

        public void AddBack(T item)
        {
            if(Capacity == Count)
            {
                Capacity *= 2;
                Array.Resize(ref collection, Capacity);
            }
            collection = new T[] { item }.Concat(collection.Take(Capacity - 1)).ToArray();
            Count++;
            //добавя елемент отзад
        }

        public T RemoveFront()
        {
            var item = collection[--Count];
            collection = collection.Take(Count).Concat(collection.Skip(Count + 1).Concat(new T[1])).ToArray();
            return item;
            //връща и премахва елемента отпред
        }

        public T RemoveBack()
        {
            var item = collection[0];
            Count--;
            collection = collection.Skip(1).Concat(new T[1]).ToArray();
            return item;
            //връща и премахва елемента отзад
        }

        public T GetFront()
        {
            return collection[Count-1];
            //връща, без да премахва, елемента отпред

        }

        public T GetBack()
        {
            return collection[0];
            //връща, без да премахва, елемента отзад
        }
    }
}
