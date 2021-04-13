using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cytec.Cinema.Application.Contracts.Persistence;
using Cytec.Cinema.Application.Features.Shows.Commands;
using Cytec.Cinema.Domain;
using MediatR;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.Extensions.Logging;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class BookingQueryHandler : IRequestHandler<BookingQuery, BookingCommand>
    {
        private readonly IShowRepository _showRepository;
        private readonly ILogger<BookingQueryHandler> _logger;


        public BookingQueryHandler(IShowRepository showRepository, ILogger<BookingQueryHandler> logger)
        {
            _showRepository = showRepository;
            _logger = logger;
        }
        public async Task<BookingCommand> Handle(BookingQuery request, CancellationToken cancellationToken)
        {
            var show = await _showRepository.GetShow(request.Id);
            if (show == null)
            {
                _logger.LogError("Get show failed: Show Id = " + request.Id );
                return new BookingCommand();
            }

            var command = new BookingCommand()
            {
                Id = request.Id,
                Movie = show.Movie.Title,
                Screen = show.Screen.Name,
                Price = show.Movie.Price,
                MovieTime = show.TimeStart
            };
            return command;
        }
    }
}
