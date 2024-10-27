using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class Endereco_EntregaMap : IEntityTypeConfiguration<Endereco_Entrega>
    {
        public void Configure(EntityTypeBuilder<Endereco_Entrega> builder)
        {
            builder.ToTable("Enderecos_Entregas");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Rua)
                .HasColumnName("Rua")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Bairro)
                .HasColumnName("Bairro")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Cidade)
                .HasColumnName("Cidade")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Estado)
                .HasColumnName("Estado")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Cep)
                .HasColumnName("Cep")
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
