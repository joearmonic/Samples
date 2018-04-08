using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TCC.Web.Services.DAL.TerminalProgramming;
using TunstallCareChatDataAccess;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChat.Controllers
{
    [Route("api/[controller]")]
    public class TerminalController : Controller
    {
        private TCCDbContext _context;

        public TerminalController(TCCDbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<TerminalModel> GetAll()
        {
            _context.Set<TerminalModel>().ToList();
            return _context.Terminals.ToList();
        }
    }
}
