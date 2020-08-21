using Chronos.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chronos.Infra.Data.EntityConfig
{
	public class FuncionalidadeConfig : IEntityTypeConfiguration<Funcionalidade>
	{
		public void Configure(EntityTypeBuilder<Funcionalidade> builder)
		{
			builder.HasKey(p => p.Id);

			builder.Property(p => p.Descricao)
			.HasMaxLength(200)
			.IsRequired();

			builder.Property(p => p.ProjetoId)
				.IsRequired();

			builder.Property(p => p.MenuId)
				.IsRequired();

			// 1 : 1 => Funcionalidade : Sds
			builder.HasOne(f => f.Sds)
				.WithOne(d => d.Funcionalidade);

			//// 1 : N => Funcionalidade : Diagramas
			builder.HasMany(f => f.Diagramas)
				.WithOne(d => d.Funcionalidade)
				.HasForeignKey(d => d.FuncionalidadeId);

			//// 1 : N => Funcionalidade : Manuais
			builder.HasMany(f => f.Manuais)
				.WithOne(d => d.Funcionalidade)
				.HasForeignKey(d => d.FuncionalidadeId);

			builder.OwnsOne(p => p.CodigoFuncionalidade, cm =>
			 {
				 cm.Property(p => p.PrefixoProjeto)
				 .HasColumnName("PrefixoProjeto")
				 .HasColumnType("varchar(3)");

				 cm.Property(p => p.PrefixoMenu)
				 .HasColumnName("PrefixoMenu")
				 .HasColumnType("varchar(3)");

				 cm.Property(p => p.SequencialNumerico)
				 .HasColumnName("SequencialNumerico")
				 .HasColumnType("int");

				 cm.Property(p => p.IdentificacaoCompleta)
				 .HasColumnName("IdentificacaoCompleta")
				 .HasColumnType("varchar(11)");
			 });

			builder.Property(p => p.DataCadastro)
				.HasColumnType("Date");

			builder.Ignore(c => c.Projeto);
			builder.Ignore(c => c.Menu);
			builder.Ignore(c => c.FuncionalidadePai);
			builder.Ignore(c => c.Sds);
			builder.Ignore(c => c.ValidationResult);
			builder.Ignore(c => c.CascadeMode);

			builder.ToTable("Funcionalidade");
		}
	}
}
