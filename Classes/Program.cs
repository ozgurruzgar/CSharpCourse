using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Özgür";
            customer.LastName = "Rüzgar";
            customer.City = "Ankara";

            Customer customer2 = new Customer 
            {
                Id = 2, FirstName = "Engin", LastName = "Demiroğ", City = "İstanbul" 
            };

            Console.ReadLine();
        }
    }
}
