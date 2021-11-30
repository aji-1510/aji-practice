using System;

namespace activitys16112021_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many times run this program?");
            int no = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < no; i++)
            {
                Console.WriteLine("enter the a value");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the b value");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    /*int c = a + b;*/
                    Console.WriteLine("a and b value equal" + " " + (a + b));

                }
                else
                {
                    Console.WriteLine("a and b value not equal" + " " + (a + b) * 3);
                }
            }
            Console.ReadLine();
            
        }
    }
}
