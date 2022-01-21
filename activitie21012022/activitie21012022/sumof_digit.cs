using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activitie21012022
{
    class sumof_digit
    {
       public void sum_method(int n)
        {
            int sum = 0, m;
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("class D");
            Console.Write("Sum of value= " + sum);

        }
    }
}
