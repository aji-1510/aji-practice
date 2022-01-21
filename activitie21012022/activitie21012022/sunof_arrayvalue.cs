using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activitie21012022
{
    class sunof_arrayvalue
    {
        public void sun(int[] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            { 
                sum += Array[i];

            }
            Console.ReadKey();
            Console.WriteLine("class C");
            foreach (int n in Array)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("totel value of array elements : " + sum);
        }
    }
}
