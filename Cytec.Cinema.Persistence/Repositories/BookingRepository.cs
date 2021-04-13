using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cytec.Cinema.Application.Contracts.Persistence;
using Cytec.Cinema.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cytec.Cinema.Persistence.Repositories
{
    public class BookingRepository: BaseRepository<Booking>, IBookingRepository

    {
        public BookingRepository(CinemaDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            return await _dbContext.Bookings.ToListAsync();
        }
    }
}
