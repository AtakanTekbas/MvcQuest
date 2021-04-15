using Odevler.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Odevler.Data
{
    public class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(c => c.PlayerID);
            builder.Property(p => p.PlayerID).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Surname).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Value).IsRequired();
            builder.Property(p => p.BirthDate).IsRequired().HasDefaultValueSql("CURRENT_DATE()");
            //ilişki

            builder.HasOne(y => y.Team)
                .WithMany(x => x.Players);
            builder.HasOne(c => c.Country)
                .WithMany(x => x.Players);
            builder.HasOne(o => o.Position)
                .WithMany(x => x.Players);
        }
    }
}
