using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class SalesManager : ISaleService 

    {
        ICampaignService _campaignService; 
        public SalesManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void CampaignSales(Player player)
        {
            _campaignService.AddCampaign();
            Console.WriteLine(player.FirstName + " purchased the game.");
        }

        public void Sales(Player player)
        {
            Console.WriteLine( player.FirstName + " purchased the game.");
        }
    }
}
