using Iterometro.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Iterometro.Infrastructure.Mappers
{
    public class AtorContagemMapper : IEntityTypeConfiguration<AtorContagem>
    {
        public void Configure(EntityTypeBuilder<AtorContagem> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.Nome)
                .IsRequired();

            builder.Property(x => x.Contador)
                .IsRequired();

            builder.Property(x => x.DataContagem)
                .IsRequired();

        }
    }
}
