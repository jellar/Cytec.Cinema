using Cytec.Cinema.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cytec.Cinema.Persistence.Configurations
{
    public class ShowConfiguration : IEntityTypeConfiguration<Show>
    {
        public void Configure(EntityTypeBuilder<Show> builder)
        {
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.TimeStart).IsRequired();
            builder.Property(s => s.TimeEnd).IsRequired();
        }
    }
}