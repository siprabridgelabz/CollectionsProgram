using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    //List<T>class represents the list of objects which can be accessed with index.
    //List is dynamic ,we can resize with items
    public class ListDemo
    {
        //creating a list of integers
        List<int> list= new List<int>();
        public void Adding()
        {
            list.Add(10);
            list.Add(11);
            list.Add(13);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of list -"+list.Count);
            Console.WriteLine("Capacity of list -" + list.Capacity);
            list.Add(14);
            list.Add(15);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Capacity of list -" + list.Capacity);
            Console.WriteLine("Find elements -" + list.Contains(1));
            Console.WriteLine("Remove elemrnt -" + list.Remove(14));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            Console.WriteLine("removing element for a particular position");
            list.RemoveAt(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            Console.WriteLine("Reverse element");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            Console.WriteLine("Sorting the list element");
            list.Add(2);
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            Console.WriteLine("Delete element");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
