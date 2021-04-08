using CredeitCardWebAPI.Models;
using CredeitCardWebAPI.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Services
{
    public class CardCommonService : ICardCommonService
    {
        #region Generic
        private readonly ApplicationDBContext _context;

        public CardCommonService(ApplicationDBContext context)
        {
            _context = context;
        }

        #endregion

        #region Get 
        /// <summary>
        /// Added By Tarun
        /// Added On 8 April 2021 
        /// </summary>
        /// <returns></returns>
        public async Task<List<CardDetails>> GetCardDetails()
        {
            List<CardDetails> cardDetails;
            try
            {
                cardDetails = new List<CardDetails>();

                cardDetails = await _context.CardDetails.ToListAsync();
            }
            catch (Exception ex)
            {
                cardDetails = new List<CardDetails>();
            }
            return cardDetails;
        }

        #endregion
    }
}
