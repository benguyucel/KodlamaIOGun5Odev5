using KodlamaIOGun5Odev5.Abstract;
using KodlamaIOGun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Concrete
{
    public class ProductMenager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("{0} Added",product.Name);
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
