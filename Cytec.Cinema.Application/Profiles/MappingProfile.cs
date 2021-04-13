using AutoMapper;
using Cytec.Cinema.Application.Features.Shows.Queries;
using Cytec.Cinema.Domain;

namespace Cytec.Cinema.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Show, ShowDetailsVm>();
            CreateMap<Screen, ScreenVm>();
            CreateMap<Movie, MovieVm>();
            CreateMap<Booking, BookingsVm>();
        }
    }
}
