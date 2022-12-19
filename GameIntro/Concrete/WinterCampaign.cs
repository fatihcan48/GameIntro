using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class WinterCampaign : BaseCampaignManager
    {
        public override void AddCampaign()
        {
            Console.WriteLine(" %5 DISCOUNT FOR YOU !!! ");
        }
    }
}
