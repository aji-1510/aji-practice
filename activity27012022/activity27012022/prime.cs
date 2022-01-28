using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity27012022
{
    class prime
    {
        public void prime_demo()
        {
            char add;
            do
            {

                int n, i, m = 0, flag = 0;
                Console.WriteLine("---------------------------------- WELCOME TO FIND OUT PRIME NUMBER PROGRAM--------------------------------------");
                Console.Write("Enter the Number to check Prime: ");
                n = int.Parse(Console.ReadLine());
                m = n / 2;
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write("Number is not Prime.");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.Write("Number is Prime.");
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("You want one more prime number cal process Y/N :");
                add = Convert.ToChar(Console.ReadLine());

            } while ((add == 'y') && (add == 'Y'));

        }
    }
}
