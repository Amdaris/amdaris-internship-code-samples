using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ListsDemo
{
    public class ListsDemo
    {
        public static void Main(string[] args)
        {
            ListInitDemo();
            ListResizeDemo();
        }

        private static void ListInitDemo()
        {
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Peter");
            names.Add("Jack");
            names.Add("George");
            names.Add("Tom");

            List<string> items = new List<string> { "John", "Peter", "Jack", "George", "Tom" };
        }

        private static void ListResizeDemo()
        {
            //List<int> listOfIntegers = new List<int>();
            //int currentCapacity = listOfIntegers.Capacity;

            //for (int i = 0; i < 1_000_000; i++)
            //{
            //    listOfIntegers.Add(i);
            //    if (currentCapacity != listOfIntegers.Capacity)
            //    {
            //        currentCapacity = listOfIntegers.Capacity;
            //        Console.WriteLine($"List1 capacity was increased to {currentCapacity}");
            //    }
            //}

            List<int> listOfIntegers2 = new List<int>(1_000_000);
            int currentCapacity = listOfIntegers2.Capacity;
            for (int i = 0; i < 1_000_000; i++)
            {
                listOfIntegers2.Add(i);
                if (currentCapacity != listOfIntegers2.Capacity)
                {
                    currentCapacity = listOfIntegers2.Capacity;
                    Console.WriteLine($"List2 capacity was increased to {currentCapacity}");
                }
            }

            List<int> listOfIntegers3 = new List<int>();
            Console.WriteLine($"List3 capacity before AddRange = {listOfIntegers3.Capacity}");
            listOfIntegers3.AddRange(listOfIntegers2);
            Console.WriteLine($"List3 capacity after AddRange = {listOfIntegers3.Capacity}");
            listOfIntegers3.RemoveRange(0, listOfIntegers2.Count);
            Console.WriteLine($"List3 capacity after RemoveRange {listOfIntegers3.Capacity}");
            listOfIntegers3.TrimExcess(); // just for example, setting list capacity to the actual list size, not recommended to be used all the time
            Console.WriteLine("List3 capacity after TrimExcess = " + listOfIntegers3.Capacity);
        }
    }
}