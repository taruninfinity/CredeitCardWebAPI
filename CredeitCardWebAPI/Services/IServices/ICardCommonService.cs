using CredeitCardWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Services.IServices
{
    public interface ICardCommonService
    {
        Task<List<CardDetails>> GetCardDetails();
    }
}
