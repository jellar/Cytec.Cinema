using System.Collections.Generic;
using Cytec.Cinema.Domain;

namespace Cytec.Cinema.Application.Tests
{
    public static class Shows
    {
        
        public static List<Show> GetShows()
        {
            var shows = new List<Show>()
            {
                new Show()
                {
                    Id = 1,
                    Movie = new Movie() {Title = "Test Movie"},
                    Screen = new Screen() {Name = "Test Screen"},
                },
                new Show()
                {
                    Id = 2,
                    Movie = new Movie() {Title = "Test Movie"},
                    Screen = new Screen() {Name = "Test Screen"},
                }
            };
            return shows;
        }
    }
}