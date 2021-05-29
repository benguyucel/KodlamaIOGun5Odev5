using KodlamaIOGun5Odev5.Abstract;
using KodlamaIOGun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Concrete
{
    public class CustomerMenager : ICustomerService
    {
        ICustomerCheckService __customerCheckService;
public CustomerMenager(ICustomerCheckService customerCheckService)
        {
            __customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (__customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("{0} information has been added",customer.FirsName);
            }
            else
            {
                Console.WriteLine("Not a real person");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} information has been Deleted", customer.FirsName);
        }

        public void Update(Customer customer)
        {
            if (__customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("{0} information has been updated", customer.FirsName);
            }
            else
            {
                Console.WriteLine("Not a real person");
            }
        }
    }
}
