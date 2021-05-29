using KodlamaIOGun5Odev5.Abstract;
using KodlamaIOGun5Odev5.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Adapters
{
    public class CustomerCheckAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = client.TCKimlikNoDogrulaAsync(
                Convert.ToInt64(customer.NationalityID),
                customer.FirsName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.DateOfBirth.Year
                ).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
