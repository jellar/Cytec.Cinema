using Cytec.Cinema.App.Models;
using Cytec.Cinema.Application.Contracts.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cytec.Cinema.Application.Features.Shows.Commands;
using Cytec.Cinema.Application.Features.Shows.Queries;
using MediatR;

namespace Cytec.Cinema.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;
        private readonly IShowRepository _showRepository;

        public HomeController(ILogger<HomeController> logger, IMediator mediator )
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var shows = await _mediator.Send(new GetShowsQuery() { });
            return View(shows);
        }

        [HttpGet("booking/{id}")]
        public async Task<IActionResult> Booking([FromRoute] BookingQuery query)
        {
            var model = await _mediator.Send(query);
            return View(model);
        }

        [HttpPost("booking/{id}")]
        public async Task<IActionResult> Booking([FromForm] BookingCommand command)
        {
            _logger.LogInformation("Booking started for movie - " + command.Movie);
            if (ModelState.IsValid)
            {
                try
                {
                    await _mediator.Send(command);
                    return RedirectToAction("List");
                }
                catch (Exception e)
                {
                    _logger.LogError("Booking failed - " + e);
                    throw;
                }
                
            }

            return View(command);
        }

        public async Task<IActionResult> List()
        {
            var bookings = await _mediator.Send(new GetAllBookings());
            return View(bookings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
