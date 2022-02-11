using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIO
{
    class Class3
    {
        public void text_demo()
        {
            using (TextWriter tw = File.CreateText("E:\\demo4.txt"))
            {

                tw.WriteLine("Hiiiii Good Morning");
                tw.WriteLine("Byeeeeee   :)");
            }

        }
        public void textdemo1()
        {
            using (TextReader tr = File.OpenText("E:\\demo4.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());

            }
        }
    }
}
