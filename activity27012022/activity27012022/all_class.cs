using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity27012022
{
    class all_class
    {
        public void allclass()
        {
            greater great = new greater();
            prime prime_d = new prime();
            sum_digi sum_obj = new sum_digi();
            profit pro = new profit();
            vowel vowel_demo = new vowel();
            oddeven odd = new oddeven();
            fibo fibodemo = new fibo();


            Console.WriteLine("------------------------WELCOME--------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("HI GUYS CHOOSE ANY ONE PROGRAM ");
            Console.WriteLine("");
            char add;
            do
            {
            start:
                Console.WriteLine("\n");
                Console.WriteLine("1.greaterthen value program\n2.prime program\n3.sum of digit program\n4.profit loss program\n5.vowel program\n6.odd or even program\n7.fibonacci program");
                Console.WriteLine("\n");
                int num;
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        great.greater_demo();
                        break;

                    case 2:
                        prime_d.prime_demo();
                        break;
                    case 3:
                        sum_obj.sum();
                        break;
                    case 4:
                        pro.pro_loss();
                        break;
                    case 5:
                        vowel_demo.vowel_pro();
                        break;
                    case 6:
                        odd.odd_even();
                        break;
                    case 7:
                        fibodemo.fibo_demo();
                        break;

                    default:
                        Console.WriteLine("Enter the valid input value");
                        goto start;
                        /*  break;*/

                }
                
                Console.WriteLine("HI USER YOU WANT ONE MORE TIME RUN AGAIN ALL PROCESS Y/N : ");
                add = Convert.ToChar(Console.ReadLine());

            } while ((add == 'y') || (add == 'Y'));













        }
    }

}
