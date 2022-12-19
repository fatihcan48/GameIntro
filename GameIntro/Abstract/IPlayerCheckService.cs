using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckPlayerIsReal(PlayerCheck playerCheck);
    }
}
