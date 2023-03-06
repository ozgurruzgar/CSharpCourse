using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "İstanbul");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName="Engin"},new Customer { FirstName="Özgür"});
            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product:IEntity
    {

    }

     interface IEntity
    {
    }

    interface IProductDal : IRepository<Product>
    {
    }
    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal:IRepository<Customer>
    {
    }
    interface IRepository<T> where T: class,IEntity, new()  //struct koyarsak değer tip olabilir demek
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
