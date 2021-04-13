using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Cytec.Cinema.Application.Contracts.Persistence;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class GetShowsQueryHandler : IRequestHandler<GetShowsQuery, List<ShowDetailsVm>>
    {
        private readonly IShowRepository _showRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetShowsQueryHandler> _logger;

        public GetShowsQueryHandler(IShowRepository showRepository, IMapper mapper, ILogger<GetShowsQueryHandler> logger)
        {
            _showRepository = showRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<ShowDetailsVm>> Handle(GetShowsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _showRepository.GetShows();
                var shows = _mapper.Map<List<ShowDetailsVm>>(result);
                return shows;
            }
            catch (Exception e)
            {
                _logger.LogError("Get shows failed -" + e);
                throw;
            }
           
        }
    }
}
