using GameIntro.Abstract;
using GameIntro.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Adapters
{
    public class MernisCheckAdapter : IPlayerCheckService
    {
        public bool CheckPlayerIsReal(PlayerCheck playerCheck)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            var x = client.TCKimlikNoDogrulaAsync(long.Parse(playerCheck.NationalIdentity), playerCheck.FirstName,
                playerCheck.LastName, playerCheck.DateOfBirth.Year);
            var y = x.Result.Body.TCKimlikNoDogrulaResult;
            return y;
        }
    }
}
