using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class TeenagerCampaign : BaseCampaignManager
    {
        public override void AddCampaign()
        {
            Console.WriteLine("CONGRATULATION %15 DISCOUNT FOR YOU !!! ");
        }

    }
}
