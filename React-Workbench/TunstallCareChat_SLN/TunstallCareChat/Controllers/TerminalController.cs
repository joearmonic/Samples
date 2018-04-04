using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TunstallCareChat.Controllers
{
    [Route("api/[controller]")]
    public class TerminalController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<TerminalModel> GetAll()
        {
            return new List<TerminalModel>();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // });
        }

        public class TerminalModel
        {
            public int TerminalId { get; set; }
            public string Number { get; set; }
            public int TemplateId { get; set; }
            public int CentreId { get; set; }
        }
    }
}
