using CoffeeShopManager.Abstract;
using CoffeeShopManager.Concrete;
using CoffeeShopManager.Entities;
using System;
using CoffeeShopManager.Adapters;

namespace CoffeeShopManager
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
         
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 7, 11), FirstName = "Onur", LastName = "Aygün",
                NationalityId = 22351922152 });
            Console.ReadLine();
        }

    }
}
