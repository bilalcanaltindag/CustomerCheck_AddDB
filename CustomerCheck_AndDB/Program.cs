using CustomerCheck_AndDB.Abstract;
using CustomerCheck_AndDB.Concrete;
using CustomerCheck_AndDB.Entities;
using System;

namespace CustomerCheck_AndDB
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager();
            customerManager.Save(new Customer { NationalityId = "28861499108", FirstName = "Engin", LastName = "Demiroğ" , DateOfBirth = new DateTime(1985,1,6) });
        }
    }
}
