using System;
using System.Collections.Generic;
using System.Text;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class ShowDetailsVm
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public ScreenVm Screen { get; set; }
        public MovieVm Movie { get; set; }
        
    }

    public class ScreenVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ScreenCapacity { get; set; }

        public ICollection<MovieVm> Movies { get; set; }
    }

    public class MovieVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan RunningTime { get; set; }
        public decimal Price { get; set; }
    }
}
