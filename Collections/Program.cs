using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table","Tablo");
            dictionary.Add("Computer","PC");

            Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key,item.Value);
            }
            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id=1,FirstName="Engin"});
            //customers.Add(new Customer { Id=2,FirstName="Derin"});

            List<Customer> customers = new List<Customer>
            {
             new Customer { Id = 1, FirstName = "Engin" },
             new Customer { Id = 2, FirstName = "Derin" }
            };
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4,FirstName="Ali" },
                new Customer{Id=5,FirstName="Veli"}
            });
            //customers.Clear();

            //IndexOf elemanın listede kaçıncı sırada old. bilgisini verir.

            //LastIndexOf Sondan başlayarak elemanın Listedeki sırasını arıyor.

            //Insert ilgili sıraya ilgili nesneyi sokmamıza yarar.
            //customers.Insert(0, customer2);

            //RemoveAll ile ilgili instance'ın tüm referanslarını siler.
            //customers.RemoveAll(c=>c.FirstName=="Salih");

            foreach (var c in customers)
            {
                Console.WriteLine(c.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            //   string[] cities = new string[2] {"Ankara","İstanbul"};

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //  Console.WriteLine(cities[2]);
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
