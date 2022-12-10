using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal customerDal = new EfCustomerDal();
            CustomerManager customerManager = new CustomerManager(customerDal);
            var result = customerManager.GetCustomerDetail();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.FirstName + " " + customer.LastName + " - " + customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            






            Console.ReadLine();
        }
    }
}
