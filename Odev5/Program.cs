using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2000, FirstName = "Doğa", LastName = "Güven", TcNo = "58658987550" });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(new Campaign { CampaignId = 12321, CampaignName = "Sepette %25 indirim!", CampaignDate = "3-8 Mart Arası" });
        }

        
        
    }
}
