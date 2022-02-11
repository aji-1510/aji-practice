using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIO
{
    class Class1
    {
        public void file1_demo()
        {
            FileStream obj = new FileStream("E:\\demo1.txt", FileMode.OpenOrCreate);
            StreamWriter str = new StreamWriter(obj);
            str.WriteLine("welcome to demo page 1");
            str.Close();
            obj.Close();
        }
        public void streamdemo()
        {
            FileStream obj = new FileStream("E:\\demo1.txt", FileMode.OpenOrCreate);
            StreamReader str = new StreamReader(obj);
            string value = str.ReadLine();
            Console.WriteLine(value);
            str.Close();
            obj.Close();

        }

    }
}
