using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class VeiculoMap : IEntityTypeConfiguration<Veiculos>
    {
        public void Configure(EntityTypeBuilder<Veiculos> builder)
        {
            builder.ToTable("Veiculos");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(v => v.Placa)
                .HasColumnName("Placa")
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(v => v.Modelo)
                .HasColumnName("Modelo")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(v => v.Capacidade)
                .HasColumnName("Capacidade")
                .HasColumnType("decimal(10, 2)");

            builder.Property(v => v.Status)
                .HasColumnName("Status")
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
