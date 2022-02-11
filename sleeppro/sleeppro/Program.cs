using System;
using System.Threading;


namespace sleeppro
{
    class Program
    {
        static void Main(string[] args)
        {
            char num2;
            do
            {
                int num1;
                
                Console.WriteLine("sleep methoed program");
                Console.WriteLine("which place sleep method proform 1 to 10");
                num1 = int.Parse(Console.ReadLine());
                sleep_demo(num1);
                Console.WriteLine("you want run again this program Y/N");
                num2 = Convert.ToChar(Console.ReadLine());

            } while ((num2 == 'Y') || (num2 == 'y'));
        }
        public static void sleep_demo(int num1)
        {
            int i;
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("methoed value :{0}", i);
                if (i==num1)
                {
                    Thread.Sleep(5000);
                }
            }
        }
    }
}
