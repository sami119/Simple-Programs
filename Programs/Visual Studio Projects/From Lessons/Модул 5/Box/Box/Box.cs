using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Box<T>: IEnumerable<T>
    {
        private List<T> store;

        public Box()
        {
            this.store = new List<T>();
            this.count = 0;
        }

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(T input)
        {
            this.store.Add(input);
            count++;
        }

        public T Remove()
        {
            T temp = store.Last();
            this.store.Remove(store.Last());
            count--;
            return temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)store).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)store).GetEnumerator();
        }
    }
}
