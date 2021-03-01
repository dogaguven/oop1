using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface ICampaignService
    {
        void CampaignAdd(Campaign campaign);
        void CampaignUpdate(Campaign campaign);
        void CampaignDelete(Campaign campaign);

    }
}
