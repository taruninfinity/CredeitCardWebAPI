using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Models
{
    public class CardDetailsViewModel
    {
        public string CardType { get; set; }
        public int CardLimit { get; set; }
        public int CardAnnualCharge { get; set; }

    }
}
