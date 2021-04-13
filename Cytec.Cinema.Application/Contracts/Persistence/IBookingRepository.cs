using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cytec.Cinema.Domain;

namespace Cytec.Cinema.Application.Contracts.Persistence
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAllBookings();
    }
}
