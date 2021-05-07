using CoffeeShopManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopManager.Abstract
{
    public interface ICustomerService
    {
        public void Save(Customer customer);
    }
}
