using System;

namespace classobject
{
    class MyClass1 : MyClass3 
    {
        protected int a;
        internal int b;
        protected int c;
        public void Method1()
        {
            Console.WriteLine("Method1 form class 1");

        }
     }
class Myclass2 : MyClass1 
    {
    public void Method2()
        {
            Console.WriteLine("Method2 form class 2");
            a = 10;
            b = 1;
            c = a + b;

            Console.WriteLine("the c value is " +c);
            Method3();


        }

}
    class MyClass3
    {
        public void Method3()
        {
           /* string num = "one";
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Method3"+num +num2);
            Console.ReadKey();*/
            int iCount = 3;
            Class1[] aoStudent = new Class1[iCount];
            for (int iNum =0; iNum < iCount;iNum++)
            {
                aoStudent[iNum] = new Class1();

                Console.WriteLine("Enter student Name:");
                aoStudent[iNum].Name = Console.ReadLine();
                Console.WriteLine("Enter student age");
                aoStudent[iNum].Age =Convert .ToInt32 (Console.ReadLine());


            }
            for (int iNum = 0; iNum < iCount; iNum++)
            {
                Console.WriteLine("student name\n" +aoStudent[iNum].Name);
                Console.WriteLine("student age\n" +aoStudent[iNum].Age);

            }
                Console.ReadLine();


        }
    }
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Myclass2 obj2 = new Myclass2();
            obj2.Method1();
            obj2.Method2();
        }
    }
}
