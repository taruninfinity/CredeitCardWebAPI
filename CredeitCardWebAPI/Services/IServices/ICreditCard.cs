using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Services.IServices
{
  public interface ICreditCard
    {   
        string GetCardType(int id);
        int GetCreditLimit(int id);
        int GetAnnualCharge(int id);
    }
}
