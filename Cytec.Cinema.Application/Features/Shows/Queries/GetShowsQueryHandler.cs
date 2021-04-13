using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Cytec.Cinema.Application.Contracts.Persistence;
using MediatR;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class GetShowsQueryHandler : IRequestHandler<GetShowsQuery, List<ShowDetailsVm>>
    {
        private readonly IShowRepository _showRepository;
        private readonly IMapper _mapper;

        public GetShowsQueryHandler(IShowRepository showRepository, IMapper mapper)
        {
            _showRepository = showRepository;
            _mapper = mapper;
        }

        public async Task<List<ShowDetailsVm>> Handle(GetShowsQuery request, CancellationToken cancellationToken)
        {
            var result = await _showRepository.GetShows();
            var shows = _mapper.Map<List<ShowDetailsVm>>(result);
            return shows;
        }
    }
}
