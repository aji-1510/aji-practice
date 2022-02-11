using System;
using System.Threading;

namespace threadpro
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread obj = new Thread(methoed1);
            Thread obj1 = new Thread(methoed2);
            obj.Start();
            obj1.Start();

            
        }
        public static void methoed1()
        {
            int i;
/*            Console.WriteLine("methoed1");
*/            for(i=1;i<=10;i++)
            {
                Console.WriteLine("methoed1 value:{0}", i);
                if (i == 5)
                {
                    Thread.Sleep(5000);
                }
                
            }

        }
        public static void methoed2()
        {
            int i;
/*            Console.WriteLine("methoed2");
*/            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("methoed2 value:{0}", i);
                if (i == 5)
                {
                    Thread.Sleep(5000);
                }

            }

        }

    }
}
