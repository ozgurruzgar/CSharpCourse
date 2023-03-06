using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { FirstName = "Engin", LastName = "Demiroğ", Age = 35 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }
    [ToTable("Customers")] // Bu ifade bu class veritabında Customers tablosuna denk gelir demek.
    class Customer
    {
        [RequiredProperty]// Id zorunlu demek. Eğer Id Bilgisi yoksa boş geçer.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class RequiredPropertyAttribute : Attribute
    {
    }
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add Method's instead of AddnNew Method use")]//bu class eski sen yeniyi kullan demek
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
}
