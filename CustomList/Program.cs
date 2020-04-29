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
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(100);
            list2.Add(200);
            CustomList<int> newList = new CustomList<int>();
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            newList.Add(12);
            newList.Add(6);
            newList.Add(7);
            newList.Add(8);
            newList.Add(9);
            newList.Add(10);
            newList.Add(14);
            newList.Add(15);
            newList.Add(16);
            newList.Add(27);

            newList.Remove(12);

            newList.ToString();

            CustomList<int> list3 = newList + list2;
            Console.WriteLine(list3);

            //Console.WriteLine(newList[5]);
            Console.ReadLine();
        }
    }
}
