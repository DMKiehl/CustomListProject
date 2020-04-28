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

        public T this[int i]
        {
            get 
            { 
                if(i >= count)
                {
                    Console.WriteLine("Argument Out of Range");
                }
                return items[i]; 
            }
            set 
            { 
                items[i] = value; 
            }
        }
        //count property
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
        }

        //capacity property
        public int Capacity
        {
            get
            {
                return items.Length;
            }

            set
            {
               
            }
        }

        //constructor
        public CustomList()
        {
            items = new T[4];
        }

        //member methods
        public void Add(T item)
        {
            
            count++;
        }

        public bool Remove(T item)
        {
            count--;
            return false;
        }

    }
}
