using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    class grt_3number
    {
        public void GRT_demo()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter three numbers");
            num1=Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Num1 is geraeter = {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Num2 ius greater={0}", num2);
            }
            else
            {
                Console.WriteLine("Num3 is greater={0}",num3);
            }

        }

    }
}
