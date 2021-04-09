using CredeitCardWebAPI.Models;
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
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
    public class UserInfoController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public UserInfoController(ApplicationDBContext context)
        {
            _context = context;
        } 

        // Get: api/Users

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserInfo>>> GetCards()
        {
            return await _context.UserInfo.ToListAsync();
        }
    }
}
