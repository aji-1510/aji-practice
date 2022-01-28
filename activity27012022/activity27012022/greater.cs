using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity27012022
{
    class greater
    {
        public void greater_demo()
        {
            char add;

            do 
            { 

                int num1, num2, num3, num4, num5;
                Console.WriteLine("--------------------------- WELCOME TO FIND OUT THE GEARTER VALUE PROGRAM---------------------------------");
                Console.WriteLine("Enter the five Number");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                num3 = Convert.ToInt32(Console.ReadLine());
                num4 = Convert.ToInt32(Console.ReadLine());
                num5 = Convert.ToInt32(Console.ReadLine());
                if ((num1 >= num2) && (num1 >= num3) && (num1 >= num4) && (num1 >= num5))
                {
                    Console.WriteLine("number {0} is a greater value", num1);
                }
                else if ((num2 >= num1) && (num2 >= num3) && (num2 >= num4) && (num2 >= num5))
                {
                    Console.WriteLine("number {0} is a greater value", num2);
                }
                else if ((num3 >= num1) && (num3 >= num2) && (num3 >= num4) && (num3 >= num5))
                {
                    Console.WriteLine("number {0} is a greater value", num3);
                }
                else if ((num4 >= num1) && (num4 >= num2) && (num4 >= num3) && (num4 >= num5))
                {
                    Console.WriteLine("number {0} is a greater value", num4);
                }
                else
                {
                    Console.WriteLine("number {0} is a greater value", num5);

                }
                Console.WriteLine("\n\n");
                Console.WriteLine("You want one more greaterthen value process Y/N :");
                add = Convert.ToChar(Console.ReadLine());
             }while((add=='y')||(add=='Y'));


        }
    }
}
