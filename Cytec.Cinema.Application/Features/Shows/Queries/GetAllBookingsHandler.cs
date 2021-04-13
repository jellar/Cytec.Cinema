using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Cytec.Cinema.Application.Contracts.Persistence;
using Cytec.Cinema.Domain;
using MediatR;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class GetAllBookingsHandler : IRequestHandler<GetAllBookings, List<BookingsVm>>
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public GetAllBookingsHandler(IBookingRepository bookingRepository, IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }
        public async Task<List<BookingsVm>> Handle(GetAllBookings request, CancellationToken cancellationToken)
        {
            var result = await _bookingRepository.GetAllBookings();
            var bookings = _mapper.Map<List<BookingsVm>>(result);
            return bookings;
        }
    }
}
