using Chronos.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chronos.Infra.Data.EntityConfig
{
    public class DiagramaConfig : IEntityTypeConfiguration<Diagrama>
    {
        public void Configure(EntityTypeBuilder<Diagrama> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomeArquivo)
            .HasMaxLength(100)
            .IsRequired();

            builder.Property(p => p.DataCadastro)
                .HasColumnType("Date");

            builder.Ignore(c => c.Funcionalidade);
            builder.Ignore(c => c.ValidationResult);
            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Diagrama");
        }
    }
}
