using KodlamaIOGun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
