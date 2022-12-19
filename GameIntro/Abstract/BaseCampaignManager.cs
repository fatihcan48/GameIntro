using GameIntro.Concrete;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService 
    {
    
    public virtual void AddCampaign()
    {
        Console.WriteLine(" %10 DISCOUNT FOR YOU !!! ");
    }
    public void DeleteCampaign()
    {
        Console.WriteLine("Campaign deleted.");
    }
    public void UpdateCampaign()
        {
            Console.WriteLine("Campaign updated.");

        }
    }
}
