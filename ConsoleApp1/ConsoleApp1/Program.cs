using System;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList student_name = new SortedList();
            student_name.Add(05, "ajith");
            student_name.Add(066, "dinesh");
            student_name.Add(04, "maanesh");
            student_name.Add(01, "sangeetha");
            student_name.Add(06, "shiva");
            student_name.Add(02, "mathi");


            foreach (DictionaryEntry pair in student_name)

            {
                Console.WriteLine("{0}   {1}", pair.Key, pair.Value);

            }
           

        }
    }
}
