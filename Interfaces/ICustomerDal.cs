﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated.");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted.");
        }

        public void Update()
        {
           Console.WriteLine("Oracle Updated.");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal _customerDal)
        {
            _customerDal.Add();
        }
    }
}
