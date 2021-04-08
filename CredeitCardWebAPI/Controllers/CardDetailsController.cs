using CredeitCardWebAPI.Models;
using CredeitCardWebAPI.Services;
using CredeitCardWebAPI.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CardDetailsController : ControllerBase
    {
        #region Generic
        private readonly ICardCommonService _cardCommonService;
        public static ICreditCard _creditCard;

        public CardDetailsController(ICardCommonService cardCommonService)
        {
            _cardCommonService = cardCommonService;
        }

        #endregion

        #region Get
        /// <summary>
        /// Added By Tarun
        /// Added On 8 April 2021 
        /// </summary>
        /// <returns></returns>
        // Get: api/Cards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDetails>>> GetCards()
        {
            return await _cardCommonService.GetCardDetails();
        }

        /// <summary>
        /// Added By Tarun
        /// Added On 8 April 2021 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpGet("{id}/{type}")]
        public async Task<ActionResult<CardDetailsViewModel>> GetCardDetails(int id, string type)
        {
            //Get Card Type

            
                switch (type)
            {

                case "MoneyBack":
                    _creditCard = new MoneyBackService();
                    break;
                case "Platinum":
                    _creditCard = new PlatinumService();
                    break;
                case "Titanium":
                    _creditCard = new TitaniumService();
                    break;
            }
            CardDetailsViewModel cardDetailsViewModel = new CardDetailsViewModel();
            if (id != 0)
            {
                cardDetailsViewModel.CardType = _creditCard.GetCardType(id);
                cardDetailsViewModel.CardLimit = _creditCard.GetCreditLimit(id);
                cardDetailsViewModel.CardAnnualCharge = _creditCard.GetAnnualCharge(id);
            }
            if (string.IsNullOrEmpty(cardDetailsViewModel.CardType) && cardDetailsViewModel.CardLimit == 0 && cardDetailsViewModel.CardAnnualCharge == 0)
                cardDetailsViewModel = null;

            if (cardDetailsViewModel == null)
            {
                return NotFound();
            }
            else
            {
                return cardDetailsViewModel;
            }
        }

        #endregion
    }
}
