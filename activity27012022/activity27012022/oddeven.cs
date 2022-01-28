using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity27012022
{
    class oddeven
    {
        public void odd_even()
        {
            char add;
            do
            {
                int i;
                Console.WriteLine("--------------------------- WELCOME TO FIND OUT ODD EVEN NUMBER PROGRAM---------------------------------");
                Console.Write("Enter a Number : ");
                i = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.Write("{0} Number is an Even Number", i);
                    
                }
                else
                {
                    Console.Write("{0} Entered Number is an Odd Number", i);
                    
                }
                Console.WriteLine("\n");
                Console.WriteLine("You want one more odd even  process Y/N :");
                add = Convert.ToChar(Console.ReadLine());
            } while ((add == 'y') || (add == 'Y'));
        }
    }
}
