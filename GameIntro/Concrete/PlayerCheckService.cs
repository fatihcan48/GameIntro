using GameIntro.Abstract;
using GameIntro.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class PlayerCheckService : IPlayerCheckService
    {
        public bool CheckPlayerIsReal(PlayerCheck playerCheck)
        {
            return true;
        }
    }
}
