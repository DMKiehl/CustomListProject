using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> list2 = new CustomList<int>();
            //list2.Add(1);
            //list2.Add(6);
            //list2.Add(4);
            //CustomList<int> newList = new CustomList<int>();
            //newList.Add(1);
            //newList.Add(2);
            //newList.Add(3);
            //newList.Add(4);
            //newList.Add(5);
            //newList.Add(12);
            //newList.Add(6);

            //newList.Remove(12);

            //newList.ToString();


            //CustomList<int> list3 = newList - list2;
            //Console.WriteLine(list3);
            //CustomList<int> nList = newList.Zip(list2);
            //Console.WriteLine(nList);

            //Console.ReadLine();

            CustomList<string> list2 = new CustomList<string>();
            list2.Add("Hello");
            list2.Add("Dana");

            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            newList.Add("Hi");

            ////newList.Remove("Hello");

            //CustomList<string> list3 = newList - list2;
            //Console.WriteLine(list3);
            CustomList<string> nList = newList.Zip(list2);
            Console.WriteLine(nList);

            Console.ReadLine();

            /* Console.WriteLine(newList[0]);*/


        }
    }
}
