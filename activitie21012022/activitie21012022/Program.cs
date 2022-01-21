using System;

namespace activitie21012022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("clsaa A");
            int n, num1, num2, num3;
            greater_value obj1 = new greater_value();
            sumof_digit obj2 = new sumof_digit(); 
            sunof_arrayvalue obj3 = new sunof_arrayvalue();
            Console.WriteLine("Enter three numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            obj1.greatervalue(num1,num2,num3);
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            obj2.sum_method(n);
            Console.ReadKey();
            
          

            

          

        }
    }
}
