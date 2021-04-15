using Odevler.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Odevler.Data
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(c => c.CountryID);
            builder.Property(p => p.CountryID).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();


            // ilişki alanı
            builder.HasMany(o => o.Players)
                .WithOne(y => y.Country);
            builder.HasMany(c => c.Teams)
                .WithOne(y => y.Country);

        }
    }
}
