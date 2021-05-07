using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopManager.Entities;

namespace CoffeeShopManager.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
