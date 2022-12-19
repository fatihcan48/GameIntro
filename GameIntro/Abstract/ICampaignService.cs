using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public interface ICampaignService
    {
        void AddCampaign();
        void UpdateCampaign();
        void DeleteCampaign();
    }
}
