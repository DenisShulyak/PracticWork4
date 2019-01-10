using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBill = 1000;
            int countBills = 4;
            Money money = new Money(numberBill, countBills);
            Console.WriteLine("Номинал купюры: " + money.GetNumberBill());
            Console.WriteLine("Количество купюр: " + money.GetCountBills());
            Console.WriteLine("Введите цену товара: ");
            int PriceProduct1 = int.Parse(Console.ReadLine());
            if(money.IsThereEnoughMoney(PriceProduct1) == true)
            {
                Console.WriteLine("Денежных средств хватит на покупку товара");
            }
            else
            {
                Console.WriteLine("Денежных средств не хватит на покупку товара");
            }
            Console.WriteLine("Введите цену товара(n): ");
            int PriceProduct2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество товаров, которые можно купить за нашие денежные средства: " + money.CanBuyProducts(PriceProduct2));


            Console.ReadLine();

        }
    }
}
