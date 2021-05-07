using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopManager.Abstract;
using CoffeeShopManager.Entities;

namespace CoffeeShopManager.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;


        }
    }
}
