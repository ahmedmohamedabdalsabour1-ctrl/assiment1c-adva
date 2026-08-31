using System;
using System.Collections.Generic;
using System.Text;

namespace assiment1c_adva
{
    internal class Container <T>
    {
        private T value;

        public void Add(T item)
        {
            value = item;
        }

        public T Get()
        {
            return value;
        }
    }
}
