using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class GetAllBookings : IRequest<List<BookingsVm>>
    {
    }
}
