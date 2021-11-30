using System;

namespace classobject
{
    class MyClass1 : MyClass3
    {
      
        public void Method1()
        {
            Console.WriteLine("student Eligible age 20 above");

        }
    }
    class Myclass2 : MyClass1
    {
        public void Method2()
        {
          
            Method3();


        }

    }
    class MyClass3
    {
        public void Method3()
        {

            /*int iCount = 3;*/
            Console.WriteLine("enter the total student");
            int iCount = Convert.ToInt32(Console.ReadLine());
            Class1[] aoStudent = new Class1[iCount];
            for (int iNum = 0; iNum < iCount; iNum++)
            {
                aoStudent[iNum] = new Class1();

                Console.WriteLine("Enter student Name:");
                aoStudent[iNum].Name = Console.ReadLine();
                Console.WriteLine("Enter student age");
                aoStudent[iNum].Age = Convert.ToInt32(Console.ReadLine());
               


            }
            Console.WriteLine("eligible student name");
            for (int iNum = 0; iNum < iCount; iNum++)
            {
                
                if (aoStudent[iNum ].Age>20)
                {
                    Console.WriteLine("student name\n" + aoStudent[iNum].Name);
                    Console.WriteLine("student age\n" + aoStudent[iNum].Age);
                }
                

            }
            Console.ReadLine();


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass2 obj2 = new Myclass2();
            obj2.Method1();
            obj2.Method2();
        }
    }
}
