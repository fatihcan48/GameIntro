using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            
            if (_playerCheckService.CheckPlayerIsReal(player))
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " is added.");
            }
            else
            {
                throw new Exception("Not a valid player");
            }

        }
        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " is deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " is updated");

        }
    }
}
