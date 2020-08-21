using Chronos.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chronos.Infra.Data.EntityConfig
{
    public class ProjetoConfig : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomeProjeto)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Prefixo)
                .HasMaxLength(3)
                .IsRequired();

            // 1 : N => Projeto : Funcionalidades
            builder.HasMany(p => p.Funcionalidades)
                .WithOne(m => m.Projeto)
                .HasForeignKey(m => m.ProjetoId);

            // 1 : N => Projeto : Menus
            builder.HasMany(p => p.Menus)
                .WithOne(m => m.Projeto)
                .HasForeignKey(m => m.ProjetoId);

            builder.Property(p => p.DataCadastro)
                .HasColumnType("Date");

            builder.Ignore(c => c.ValidationResult);
            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Projeto");
        }
    }
}
