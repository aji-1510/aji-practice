using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activitie21012022
{    class greater_value
    {
        sunof_arrayvalue obj3 = new sunof_arrayvalue();
        public void greatervalue(int num1,int num2,int num3)
        {
            Console.WriteLine("class B");

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Num1 is geraeter = {0}",+num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Num2 ius greater={0}", num2);
            }
            else
            {
                Console.WriteLine("Num3 is greater={0}", num3);
            }
            int[] array = { 24, 44, 77, 11, 22 };
            obj3.sun(array);

           


        }
      }

    }