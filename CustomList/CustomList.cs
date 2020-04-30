using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        //member variables
        private T[] items;

        public T this[int i]
        {
            get
            {
                if (i < count && i >= 0)
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
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
            T[] newList = new T[items.Length];
            for (int i = 0; i < count; i++)
            {
                
                if (items[i].Equals(item))
                {
                    int index = i;
                    CompressArray(newList, index);
                  
                    return true;
                }
                newList[i] = items[i];
            }
            items = newList;
            return false;
        }

        public void CompressArray(T[] newList, int index)
        {
            for (int j = index + 1; j <= count; j++)
            {
                newList[j - 1] = items[j];
            }

            count--;
            items = newList;
            //return true;
        }

        public override string ToString()
        {
            string newString = "";

            for (int i = 0; i < count; i++)
            {

                newString += items[i].ToString();

            }
            Console.WriteLine(newString);
            return newString;
            
        }

        public void Zip(CustomList<T> list, CustomList<T> list2)
        {

        }

        public static CustomList<T> operator +(CustomList<T> list, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            foreach (T item in list) newList.Add(item);
            foreach (T item in list2) newList.Add(item);

            
            return newList;

        }

        public static CustomList<T> operator -(CustomList<T> list, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            foreach (T item in list) newList.Add(item);
            

            foreach (T item in list2)
            {
                newList.Remove(item);
            }

            return newList;
        }

    }
}
