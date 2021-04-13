using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Cytec.Cinema.Application.Features.Shows.Commands
{
    public class BookingCommand : IRequest
    {
        public int Id { get; set; }
        public string Movie { get; set; }
        public string Screen { get; set; }
        public DateTime MovieTime { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public int Tickets { get; set; }

    }
}
