using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayList
{
    class CustomArrayList
    {
        private object[] arr;

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
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

              private static readonly int INITIAL_CAPACITY = 4;

        public object Get(int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return arr[index];
        }
        public CustomArrayList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(object item)
        {
            if (Count == Capacity)
            {
                Capacity = Capacity * 2;
                object[] copy = new object[Capacity];
                for (int i = 0; i < arr.Length; i++)
                {
                    copy[i] = arr[i];
                }
                copy[Count] = item;
                Count++;
                arr = copy;
            }
            else
            {
                this.arr[Count] = item;
                Count++;
            }
        }

        public void Insert(int index, object item)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            this.Add(item);
            object ar;
            
            for (int i = Count-1; i > index; i--)
            {
                ar = arr[i];
                arr[i] = arr[i-1];
                arr[i-1] = ar;
            }
        }

        public int IndexOf(object item)
        {

        }

        public void Clear()
        {

        }

        public bool Contains(object item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.arr[index];
            }
            set
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                this.arr[index] = value;
            }
        }

        public object Remove(int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int Remove(object item)
        {
        }


    }
}
