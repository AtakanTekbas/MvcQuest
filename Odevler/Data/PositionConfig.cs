using Odevler.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Odevler.Data
{
    public class PositionConfig : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(c => c.PositionID);
            builder.Property(p => p.PositionID).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();


            // ilişki alanı
            builder.HasMany(o => o.Players)
                .WithOne(y => y.Position);

        }
    }
}
