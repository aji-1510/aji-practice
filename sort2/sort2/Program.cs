using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sort_List = new List<int>();
            sort_List.Add(5);
            sort_List.Add(8);
            sort_List.Add(9);
            sort_List.Add(3);
            sort_List.Add(1);
            sort_List.Add(2);
            Console.WriteLine("List before");
            foreach (int num in sort_List)
            {
                Console.WriteLine(num);
            }
            sort_List.Sort();
            
            Console.WriteLine("List after");

            foreach (int num in sort_List)
            {
                Console.WriteLine(num);
            }
            sort_List.Reverse();
            Console.WriteLine("reverse list");
            foreach (int num in sort_List)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}