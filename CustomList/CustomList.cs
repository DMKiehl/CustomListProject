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
                if(i < count && i >= 0)
                {
                    return items[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set 
            { 
                items[i] = value; 
            }
        }
        //count property
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        //capacity property
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                if (value > 0)
                {
                    T[] newItems = new T[value];
                    if (count > 0)
                    {
                        CopyArray(items, newItems);                       
                        capacity *= 2;
                    }
                    items = newItems;
                }
            }


        }       

        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];

        }

        public void CheckCapacity(int num)
        {
            if (capacity < num)
            {
                int updateCapacity = capacity * 2;
                Capacity = updateCapacity;
            }
        }
        //member methods
        public void Add(T item)
        {
            if(count == capacity)
            {
                CheckCapacity(count + 1);
            }
            
            items[count] = item;
            count++;
        }
        
        public void CopyArray(T[] items, T[] newItems)
        {
            for(int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }

        }

        public bool Remove(T item)
        {
            for(int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    int index = i;
                    //items[i] = default(T);
                    T[] newList = new T[items.Length];
                    //CopyArray(items, newList);
                    CondenseArray(items, index, newList);
                    items = newList;
                    count--;
                    return true;
                }
            }
            
            return false;
        }

        public void CondenseArray(T[] items, int index, T[] newList)
        {
           if(index < count)
            {
               
                
            }
        }

    }
}
