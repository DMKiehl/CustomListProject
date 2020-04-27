using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //member variables
        private T[] items;
        //count property
        public int Count { get; }

        //capacity property
        public int Capacity { get; set; }

        //constructor
        public CustomList()
        {
            items = new T[4];
        }

        //member methods
        public void Add(T item)
        {
            items[0] = item;
        }

        public bool Remove(T item)
        {
            return false;
        }

    }
}
