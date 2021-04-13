using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using Cytec.Cinema.Application.Contracts.Persistence;
using Cytec.Cinema.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Cytec.Cinema.Application.Features.Shows.Commands
{
    public class BookingCommandHandler : IRequestHandler<BookingCommand>
    {
        private readonly IAsyncRepository<Booking> _bookingRepository;
        private readonly ILogger<BookingCommandHandler> _logger;

        public BookingCommandHandler(IAsyncRepository<Booking> bookingRepository, ILogger<BookingCommandHandler> logger)
        {
            _bookingRepository = bookingRepository;
            _logger = logger;
        }
        public async Task<Unit> Handle(BookingCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var booking = new Booking()
                {
                    MovieTitle = request.Movie,
                    BookingDate = DateTime.Now,
                    Amount = request.Tickets * request.Price,
                    CreatedDate = DateTime.Now,
                    Tickets = request.Tickets,
                    User = request.User,
                    UserEmail = request.UserEmail
                };

                var newBooking = await _bookingRepository.AddAsync(booking);
                return new Unit();
            }
            catch (Exception e)
            {
                _logger.LogError("Booking failed - " + e);
                throw;
            }

        }
    }
}
