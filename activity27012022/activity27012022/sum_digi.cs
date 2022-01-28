using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity27012022
{
    class sum_digi
    {
        public void sum()
        {
            char add;
            do
            {
                Console.WriteLine("--------------------------------------- WELCOME TO FIND OUT THE SUM THE DIGIT-------------------------------------------");
                int n, sum = 0, m;
                Console.Write("Enter a number: ");
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    m = n % 10;
                    sum = sum + m;
                    n = n / 10;
                }
                Console.Write("Sum is= " + sum);
                Console.WriteLine("\n\n");
                Console.WriteLine("You want  one more sum of digit cal process Y/N :");
                add = Convert.ToChar(Console.ReadLine());
            } while ((add=='y')||(add=='Y'));
        }
    }
}
