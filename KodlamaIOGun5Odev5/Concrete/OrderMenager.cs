using KodlamaIOGun5Odev5.Abstract;
using KodlamaIOGun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Concrete
{
    public class OrderMenager : IOrderService
    {
   
 
    

        public void Sale(Product product, Customer customer, Campaign campaign)
        {
            double champPrice = product.Price - (product.Price * campaign.DiscountRate / 100);
            Console.WriteLine("{0} bought the game {1} real price is {2} with discount {3}", customer.FirsName, product.Name, product.Price, champPrice);
        }
    }
}
