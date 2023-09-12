using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CepaApp.API.Data;
using CepaApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CepaApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _context.Accounts;
        }

        [HttpGet("{id}")]
        public Account GetById(int id){

            return _context.Accounts.FirstOrDefault(account =>
                    account.UserID == id);
        }
    }
}