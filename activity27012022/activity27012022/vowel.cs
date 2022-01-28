using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity27012022
{
    class vowel
    {
        public void vowel_pro()
        {
            char add;
            char ch;
            do
            {
                Console.Write("\n\n");
                Console.Write("--------------------check whether the input alphabet is a vowel or not:--------------------------");
                Console.Write("\n\n");

                Console.Write("Input an Alphabet : ");
                ch = Convert.ToChar(Console.ReadLine().ToLower());
                int i = ch;
                {
                    switch (ch)
                    {
                        case 'a':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'i':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'o':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'u':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'e':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        default:
                            Console.WriteLine("The Alphabet is not a vowel");
                            break;
                    }
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("You want  one more  findout vowel process Y/N :");
                add = Convert.ToChar(Console.ReadLine());
            } while ((add == 'y') || (add == 'Y'));
        }


    }
    
}
