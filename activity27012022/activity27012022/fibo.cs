using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity27012022
{
    class fibo
    {
        public void fibo_demo()
        {
            char add;
            do
            {
                int num1 = 0, num2 = 1, num3, i, number;
                Console.WriteLine("---------------------------------- WELCOME TO FIND OUT FIBONACCI SERIES PROGRAM--------------------------------------");
                Console.WriteLine("\n\n");
                Console.Write("Enter the number of elements: ");
                number = int.Parse(Console.ReadLine());
                Console.Write(num1 + " " + num2 + " ");
                for (i = 2; i < number; ++i)
                {
                    num3 = num1 + num2;
                    Console.Write(num3 + " ");
                    num1 = num2;
                    num2 = num3;
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("You want run one more fibonacci series calculation process Y/N :");
                add = Convert.ToChar(Console.ReadLine());
            } while ((add == 'y') || (add == 'Y'));

        }
    }

}
