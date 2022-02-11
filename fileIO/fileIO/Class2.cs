using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIO
{
    class Class2
    {
        public void demo()
        {
            FileStream obj = new FileStream("E:\\demo5.txt", FileMode.OpenOrCreate);
            obj.WriteByte(65);
            obj.WriteByte(66);
            obj.Close();

        }
        public void demo1()
        {
            int i;
            FileStream obj = new FileStream("E:\\demo3.txt", FileMode.OpenOrCreate);
            for (i = 65; i <= 90; i++)
            {
                obj.WriteByte((byte)i);
            }
            obj.Close();

        }
        public void reading_data()
        {
            int i = 0;
            FileStream obj = new FileStream("E:\\demo4.txt", FileMode.OpenOrCreate);
            while ((i = obj.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
            obj.Close();
        }
    }
}
