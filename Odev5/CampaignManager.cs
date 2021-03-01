using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
