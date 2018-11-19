using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TCC.Web.Services.DAL.TerminalProgramming;
using TunstallCareChat.ViewModels;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChat.Controllers
{
    [Route("api/[controller]")]
    public class TerminalController : Controller
    {
        private readonly TCCDbContext _context;
        private readonly IMapper _mapper;

        public TerminalController(TCCDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IEnumerable<TerminalViewModel> GetAll()
        {
            var terminals = _context.Terminals
            .Include(t => t.ConfigurationTemplate.Version)
            .Include(e => e.ControlCentre)
            .ToList();

            IEnumerable<TerminalViewModel> terminalsViewModel =
            _mapper.Map<IEnumerable<TerminalViewModel>>(
                terminals,
            opts => opts.Items["Culture"] = "es");
            return terminalsViewModel;
        }

        [HttpGet("[action]/{id}")]
        public TerminalModel Get(int id)
        {
            var terminal = _context.Terminals.Where(t => t.Id == id)
                .Include(t => t.ConfigurationTemplate.Version)
                .Include(e => e.ControlCentre)
                .Include(t => t.Configurations).FirstOrDefault();

            return terminal;
        }
    }
}
// src.ConfigurationTemplate.DescriptionDescriptor.Translations
//                 .Where(t => t.Locale.LangCodeId.Value == ((int)ctx.Items["Culture"]))
//                 .Select(t => t.Locale.LocaleString).FirstOrDefault()
