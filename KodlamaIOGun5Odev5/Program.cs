using KodlamaIOGun5Odev5.Adapters;
using KodlamaIOGun5Odev5.Concrete;
using KodlamaIOGun5Odev5.Entities;
using System;

namespace KodlamaIOGun5Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaign campaign  = new Campaign { Id = 5, CampaignName = "Yaz indirimi", DiscountRate = 20 };
            Customer customer = new Customer { Id = 1, FirsName = "Yücel", LastName = "bengü", DateOfBirth = new DateTime(1988, 05, 01), NationalityID = "22222222222222" };
            Product product = new Product { Id = 1, Price = 1000, Name = "AssasinCreed" };
           
            CustomerMenager customerMenager = new CustomerMenager(new CustomerCheckAdapter());
            
            customerMenager.Add(customer);
            CampaignMenager campaignMenager = new CampaignMenager();
            campaignMenager.Add(campaign);
            ProductMenager productMenager = new ProductMenager();
            productMenager.Add(product);

            OrderMenager orderMenager = new OrderMenager();
            orderMenager.Sale(product, customer, campaign);
        }
    }
}
