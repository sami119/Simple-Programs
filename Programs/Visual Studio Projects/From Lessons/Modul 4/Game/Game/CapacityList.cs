using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        private int capacity = 0;

        public CapacityList(int capacity = InitialCapacity)
        {
            this.capacity = capacity;
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {
            // int sum = 0;
            var pair = new Pair(0, 0);
            for (int i = startIndex; i < nextIndex; i++)
            {
                pair.First += items[i].First;
                pair.Last += items[i].Last;
                items[i].First = 0;
                items[i].Last = 0;
            }
            items[startIndex] = pair;

            return items[startIndex];
            //return 0;
        }

        public Pair Sum()
        {
            var pair = new Pair(0, 0);
            int i = 0;
            while (i < startIndex)
            {
                pair.First += items[i].First;
                pair.Last += items[i].Last;
                i++;
            }
            return pair;
            //TODO: сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
        }

        public void Add(Pair item)
        {
            if (capacity == nextIndex)
            {
                //items[nextIndex] = item;
                this.SumIntervalPairs();
                startIndex++;
                nextIndex = startIndex;
                items[nextIndex] = item;
                nextIndex++;
            }
            else
            {
                if (nextIndex > capacity - 1)
                {
                    return;
                }
                items[nextIndex] = item;
                nextIndex++;
            }
            //TODO: Добавяне на двойката         
        }

        public void PrintCurrentState()
        {
            for (int i = 0; i < nextIndex; i++)
            {
                Console.WriteLine(items[i]);
            }
            //TODO: отпечатайте всички двойки от 0 до nextIndex
        }
    }
}
