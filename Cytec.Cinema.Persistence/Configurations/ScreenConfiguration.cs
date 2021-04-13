using System;
using System.Collections.Generic;
using System.Text;
using Cytec.Cinema.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cytec.Cinema.Persistence.Configurations
{
    public class ScreenConfiguration : IEntityTypeConfiguration<Screen>
    {
        public void Configure(EntityTypeBuilder<Screen> builder)
        {
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(125);
            builder.Property(s => s.ScreenCapacity).IsRequired();
        }
    }
}
