using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopManager.Abstract;
using CoffeeShopManager.Entities;
using MernisServiceReference;

namespace CoffeeShopManager.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(customer.NationalityId,customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}
