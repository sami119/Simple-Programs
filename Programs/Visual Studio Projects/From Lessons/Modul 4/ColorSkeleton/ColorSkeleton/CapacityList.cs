using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSkeleton
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Color[] items;

        private int startIndex = 0;
        private int nextIndex = 0;

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Color[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Color SumIntervalPairs()
        {
            throw new NotImplementedException();
        }


        public Color Sum()
        {
            throw new NotImplementedException();
        }

        public Color[] Sort()
        {
            throw new NotImplementedException();
        }

        public void Add(Color item)
        {
            throw new NotImplementedException();
        }

        public void PrintCurrentState()
        {
            throw new NotImplementedException();
        }
    }
}
