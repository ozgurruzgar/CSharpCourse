using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(50);
            product.ProductName = "Hard Disk";

            Product product2 = new Product(25);
            product2.ProductName = "GSM";
            product2.StockControlEvent += Product2_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                product.Sell(10);
                product2.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Product2_StockControlEvent()
        {
            Console.WriteLine("Gsm about to Finish!!");
        }
    }
}
