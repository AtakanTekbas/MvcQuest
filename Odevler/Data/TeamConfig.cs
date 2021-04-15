using Odevler.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Odevler.Data
{
    public class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(c => c.TeamID);
            builder.Property(p => p.TeamID).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Symbol).IsRequired();
            builder.Property(p => p.CountryID).IsRequired();
            builder.Property(p => p.EstablishmentDate).IsRequired().HasDefaultValueSql("CURRENT_DATE()");

            // ilişki alanı
            builder.HasMany(x => x.Players)
                .WithOne(y => y.Team);
            builder.HasOne(c => c.Country)
                .WithMany(y => y.Teams);
        }
    }
}
