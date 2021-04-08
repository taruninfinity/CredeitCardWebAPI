using CredeitCardWebAPI.Models;
using CredeitCardWebAPI.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Services
{
    public class MoneyBackService: ICreditCard
    {
        
        /// <summary>
        /// Added By Tarun
        /// Added On 8 April 2021 
        /// To Get Card Type
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetCardType(int id)
        {
            string cardType = "";
            using (var db = new ApplicationDBContext())
            {
                CardDetails cardDetails = db.CardDetails.FirstOrDefault(x => x.CardDetailId == id && x.IsActive && !x.IsDeleted);
                if (cardDetails != null)
                {
                    cardType = db.CardMasterTypes.FirstOrDefault(x => x.CardTypeId == cardDetails.CardTypeId && x.IsActive && !x.IsDeleted).CardType;
                }
            }
            return cardType;
        }

        /// <summary>
        /// Added By Tarun
        /// Added On 8 April 2021 
        /// To Get Card Limit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetCreditLimit(int id)
        {
            int cardCreditLimit = 0;
            using (var db = new ApplicationDBContext())
            {
                CardDetails cardDetails = db.CardDetails.FirstOrDefault(x => x.CardDetailId == id && x.IsActive && !x.IsDeleted);
                if (cardDetails != null)
                {
                    cardCreditLimit = cardDetails.CreditLimit;
                }
            }
            return cardCreditLimit;
        }

        /// <summary>
        /// Added By Tarun
        /// Added On 8 April 2021 
        /// To Get Card Annual Charge
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetAnnualCharge(int id)
        {
            int cardAnnualCharge = 0;
            using (var db = new ApplicationDBContext())
            {
                CardDetails cardDetails = db.CardDetails.FirstOrDefault(x => x.CardDetailId == id && x.IsActive && !x.IsDeleted);
                if (cardDetails != null)
                {
                    cardAnnualCharge = cardDetails.AnnualCharge;
                }
            }
            return cardAnnualCharge;
        }
    }
}
