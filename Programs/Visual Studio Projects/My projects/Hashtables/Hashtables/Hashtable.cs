using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    public abstract class Hashtable
    {
        public abstract void Add(object value);
        public abstract bool Contains(object value);
        public int hashCode(string input)
        {
            input = input.ToLower();
            int hash = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                hash = 31 * hash + (input[i] - 'a' + 1);
            }
            return hash;
        }
    }
}
