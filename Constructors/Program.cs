using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product();
            Product product2 = new Product(2,"laptop");
            Product product3 = new Product { Id = 1, ProductName = "pc" };

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("product");
            personManager.Add();

            Teacher.Number = 10;

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to Db");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added.");
        }
    }
    class BaseClass
    {
        string _message;
        public BaseClass(string message)
        {
            _message = message;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_message);
        }
    }
    class PersonManager:BaseClass
    {
        public PersonManager(string message):base(message)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validated.");
        }
    }
     class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done.");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}
