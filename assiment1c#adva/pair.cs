using System;
using System.Collections.Generic;
using System.Text;

namespace assiment1c_adva
{
    class Pair<T1, T2>
    {
        private T1 first;
        private T2 second;

        public Pair(T1 first, T2 second)
        {
            this.first = first;
            this.second = second;
        }

        public T1 GetFirst()
        {
            return first;
        }

        public T2 GetSecond()
        {
            return second;
        }
    }
}
