using KodlamaIOGun5Odev5.Abstract;
using KodlamaIOGun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Concrete
{
    public class CampaignMenager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} is Added", campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} is Deleted", campaign.CampaignName);
        }

       

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} is Updated", campaign.CampaignName);
        }
    }
}
