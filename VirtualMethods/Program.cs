using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default.");
        }
        public void Delete()
        {
            Console.WriteLine("deleted by default.");
        }
    }
    class SqlServer:Database
    {

    }
    class MySql:Database
    {

    }
}
