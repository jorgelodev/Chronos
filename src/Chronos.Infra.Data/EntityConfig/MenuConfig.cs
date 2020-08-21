using Chronos.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chronos.Infra.Data.EntityConfig
{
    public class MenuConfig : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.ProjetoId)
                .IsRequired();

            builder.Property(p => p.NomeMenu)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Prefixo)
                .HasMaxLength(3)
                .IsRequired();

            // 1 : N => Menu : Funcionalidades
            builder.HasMany(m => m.Funcionalidades)
                .WithOne(f => f.Menu)
                .HasForeignKey(f => f.MenuId);

            builder.Property(p => p.DataCadastro)
                .HasColumnType("Date");
                        
            builder.Ignore(c => c.ValidationResult);
            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Menu");
        }
    }
}
