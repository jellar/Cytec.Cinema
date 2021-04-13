using Cytec.Cinema.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cytec.Cinema.Application.Contracts.Persistence
{
    public interface IShowRepository : IAsyncRepository<Show>
    {
        Task<IEnumerable<Show>> GetShows();

        Task<Show> GetShow(int id);
    }
}
