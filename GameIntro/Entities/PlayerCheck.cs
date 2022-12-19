using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Entities
{
    public class PlayerCheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class Player : PlayerCheck
    {
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
