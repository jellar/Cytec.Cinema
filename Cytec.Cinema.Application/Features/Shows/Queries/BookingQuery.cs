using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Cytec.Cinema.Application.Features.Shows.Commands;
using MediatR;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class BookingQuery : IRequest<BookingCommand>
    {
        public int Id { get; set; }
    }
}
