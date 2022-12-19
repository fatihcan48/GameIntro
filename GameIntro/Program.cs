using GameIntro.Abstract;
using GameIntro.Adapters;
using GameIntro.Concrete;
using GameIntro.Entities;

namespace GameIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayerService playerManager = new PlayerManager(new MernisCheckAdapter());
            Player player = new Player()
            {
                DateOfBirth = new DateTime(1995, 1, 27),
                EmailAdress = "fatihcan@gmail.com",
                FirstName = "Fatih Can",
                LastName = "Türkmen",
                NationalIdentity = "12345678910",
                PhoneNumber = "05555554444"
            };
           
            playerManager.Add(player);    // Oyuncu ekleme işlemi..
            Console.WriteLine("\n***************************************\n");

            ISaleService saleService = new SalesManager(new TeenagerCampaign());
                
            saleService.Sales(player);  // Oyun satış işlemi..
            Console.WriteLine("\n***************************************\n");

            saleService.CampaignSales(player);  // Kampanyalı Oyun satış işlemi..


            Console.ReadKey();
        }
    }
}