using KodlamaIOGun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
