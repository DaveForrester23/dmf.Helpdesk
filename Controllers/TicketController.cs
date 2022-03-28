using dmf.Helpdesk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace dmf.Helpdesk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TicketController> _logger;

        public TicketController(ILogger<TicketController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TicketModel> Get()
        {
            var tickets = new List<TicketModel>()
            {
                new TicketModel()
                {
                    DateCreated = DateTime.UtcNow,
                    TicketNo = "TICKET00001",
                    Title = "Myday Cms Unabel to Create New Pages",
                    Description = "When I attemp to Create new pages I get a Gateway Request Timeout",
                    RequesterUsername = "Bob from Brighton"
                }
            };

            return tickets.ToArray();
        }
    }
}