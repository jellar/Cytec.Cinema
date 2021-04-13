using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Cytec.Cinema.Application.Contracts.Persistence;
using Cytec.Cinema.Application.Features.Shows.Queries;
using Cytec.Cinema.Application.Profiles;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace Cytec.Cinema.Application.Tests
{
    public class GetShowsQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IShowRepository> _mockShowRepository;
        private readonly GetShowsQueryHandler _getShowsQueryHandler;

        public GetShowsQueryHandlerTests()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfile());
                });
                var mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
            var mockLogger = new Mock<ILogger<GetShowsQueryHandler>>();
            _mockShowRepository = new Mock<IShowRepository>();

            _getShowsQueryHandler = new GetShowsQueryHandler(_mockShowRepository.Object, _mapper, mockLogger.Object);
        }

        [Test]
        public async Task GetValidNumberOfShowsTest()
        {
            _mockShowRepository.Setup(s => s.GetShows()).ReturnsAsync(Shows.GetShows());

            var result = await _getShowsQueryHandler.Handle(new GetShowsQuery(), CancellationToken.None);

            Assert.AreEqual(result.Count, 2);
        }

        [Test]
        public void InvalidShowsTest()
        {
           
            _mockShowRepository.Setup(s => s.GetShows()).ThrowsAsync(new Exception());

            Assert.ThrowsAsync<Exception>(() => _getShowsQueryHandler.Handle(new GetShowsQuery(), CancellationToken.None));
        }
    }
}
