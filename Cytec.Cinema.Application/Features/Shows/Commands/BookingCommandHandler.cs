using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using Cytec.Cinema.Application.Contracts.Persistence;
using Cytec.Cinema.Domain;
using MediatR;

namespace Cytec.Cinema.Application.Features.Shows.Commands
{
    public class BookingCommandHandler : IRequestHandler<BookingCommand>
    {
        private readonly IAsyncRepository<Booking> _bookingRepository;

        public BookingCommandHandler(IAsyncRepository<Booking> bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public async Task<Unit> Handle(BookingCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var booking = new Booking()
                {
                    BookingDate = new DateTime(),
                    Amount = request.Tickets * request.Price,
                    ShowId = request.Id,
                    CreatedDate = new DateTime(),
                    Tickets = request.Tickets
                };

                var newBooking = await _bookingRepository.AddAsync(booking);
                return new Unit();
            }
            catch (Exception e)
            {
                
                throw;
            }

        }
    }
}
