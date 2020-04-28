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

            CustomList<int> newList = new CustomList<int>();
            newList.Add(1);
            newList.Add(10);
            newList.Add(10);
            newList.Add(10);
            newList.Add(20);
            newList.Add(1);
            newList.Add(10);
            newList.Add(10);
            newList.Add(10);
            newList.Add(20);
            newList.Add(1);
            newList.Add(10);
            newList.Add(10);
            newList.Add(10);
            newList.Add(20);

            Console.WriteLine(newList[8]);
            Console.ReadLine();
        }
    }
}
