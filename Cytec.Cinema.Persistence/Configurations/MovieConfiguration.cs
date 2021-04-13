using Cytec.Cinema.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cytec.Cinema.Persistence.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.Title).IsRequired().HasMaxLength(125);
            builder.Property(m => m.Description).HasMaxLength(255);
            builder.Property(m => m.RunningTime).IsRequired();
            builder.Property(m => m.Price).IsRequired().HasColumnType("decimal(8,2)");
        }
    }
}