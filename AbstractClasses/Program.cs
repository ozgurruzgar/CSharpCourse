using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultSql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
