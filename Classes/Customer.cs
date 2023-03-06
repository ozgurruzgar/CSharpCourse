using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Customer
    {
        //field = Alan Tanımlamak
        public string FirstName;

        //property = Özellik tanımlamak
        public int Id { get; set; }
        //public string FirstName { get; set; }

        //private string _firstName
        //public string FirstName
        //{
        // get
        // {
        // return "Mr." + _firstName;
        // }
        // set
        // {
        // _firstName=value;
        // }
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
