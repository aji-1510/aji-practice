using System;

namespace ss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float a = 16.4f;
            int b = 9;
            float c;
            c = a * (b + a) / (a - b);
            Console.WriteLine(+c);
            Console.ReadLine();


            int h, i, j, x;
            h = 90;
            i = 15;
            j= 3;
            x = h - i / 3 + j * 2 - 1;
            Console.WriteLine(x);
            Console.ReadLine();

            // Prints numbers from 1 to n
            static void printNos(int n)
            {
                if (n > 0)
                {
                    printNos(n - 1);
                    Console.Write(n + " ");
                }
                return;
            }
            printNos(10);
            Console.ReadLine();

        }
    }
}
