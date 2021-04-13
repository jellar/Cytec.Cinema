using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cytec.Cinema.Application.Contracts.Persistence;
using Cytec.Cinema.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cytec.Cinema.Persistence.Repositories
{
    public class ShowRepository : BaseRepository<Show>, IShowRepository
    {
        public ShowRepository(CinemaDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Show>> GetShows()
        {
            return await _dbContext.Shows.Include(s => s.Screen).Include(m => m.Movie)
                .ToListAsync();
        }

        public async Task<Show> GetShow(int id)
        {
            return await _dbContext.Shows.Include(s => s.Screen)
                .Include(m => m.Movie).Where(s => s.Id == id).FirstOrDefaultAsync();

        }
    }
}
