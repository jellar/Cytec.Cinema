using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class GetShowsQuery : IRequest<List<ShowDetailsVm>>
    {
        
    }
}
