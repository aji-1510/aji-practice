using System;

namespace reveresString_without
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("----Enter the your name----");
            name = Console.ReadLine();
            char[] revers = name.ToCharArray();
            string name2 = "";
            for (int i=revers.Length-1;i>=0;i--)
            {
                name2 += revers[i];
            }
            Console.WriteLine(name2);
            Console.ReadKey();
        }
    }
}
