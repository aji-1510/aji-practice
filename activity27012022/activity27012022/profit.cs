using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity27012022
{
    class profit
    {
        public double Profit_money(double costPrice, double sellingPrice)
        {
            double profit = (sellingPrice - costPrice);
            return profit;
        }
       
        public double Loss_money(double costPrice, double sellingPrice)
        {
            double Loss = (costPrice - sellingPrice);
            return Loss;
        }
        public void pro_loss()
        {
            char add;
            do
            {
                Console.WriteLine("----------------------------- WELCOME TO FIND OUT THE PROFIT AND LOSS CALCULATION----------------------------------");
                Console.WriteLine("Enter Cost Price ");
                double costPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Selling Price ");
                double sellingPrice = Convert.ToDouble(Console.ReadLine());
                if (sellingPrice == costPrice)
                    Console.Write("No profit nor Loss");
                else if (sellingPrice > costPrice)
                {
                    Console.WriteLine("Profit :" + Profit_money(costPrice, sellingPrice));
                }
                else
                {
                    Console.WriteLine("Loss :" + Loss_money(costPrice, sellingPrice));
                }
                Console.ReadKey();
                Console.WriteLine("\n\n");
                Console.WriteLine("You want again one more profit-loss cal process Y/N :");
                add = Convert.ToChar(Console.ReadLine());
            } while ((add=='y')||(add=='Y'));

        }
    }
}
