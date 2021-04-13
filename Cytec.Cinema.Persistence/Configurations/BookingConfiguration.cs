using Cytec.Cinema.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cytec.Cinema.Persistence.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.Property(b => b.BookingDate).IsRequired();
            builder.Property(b => b.User).IsRequired().HasMaxLength(65);
            builder.Property(b => b.UserEmail).IsRequired().HasMaxLength(65);
            builder.Property(b => b.ShowId).IsRequired();
            builder.Property(m => m.Amount).HasColumnType("decimal(8,2)");
        }
    }
}