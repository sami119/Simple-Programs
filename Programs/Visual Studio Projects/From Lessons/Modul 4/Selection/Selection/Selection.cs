using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    static class Selection
    {
        public static void Sort<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length; i++)
            {
                int currMin = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (Less(a[j], a[currMin]))
                    {
                        currMin = j;
                    }
                    Swap(a, i, currMin);
                }
            }

        }

        public static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
