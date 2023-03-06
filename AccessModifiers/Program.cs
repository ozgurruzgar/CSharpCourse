using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Customer
    {
        int id;

        public void Save()
        {
            Customer customer = new Customer();
        }
    }
    class Student:Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
        }
    }
    public class Course
    {
        public string CourseName { get; set; }
       private class NestedClass //Sadece iç içe class'larda class private olabilir.
        {

        }
    }
}
