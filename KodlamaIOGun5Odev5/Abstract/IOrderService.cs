using KodlamaIOGun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Abstract
{
    public interface IOrderService
    {
        void Sale(Product product, Customer customer, Campaign campaign);
    }
}
