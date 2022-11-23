﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class VeículoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculo");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .UseIdentityColumn();

            builder.Property(c => c.Marca)
                .HasColumnName("Marca");

            builder.Property(c => c.Modelo)
               .HasColumnName("Modelo");

            builder.Property(c => c.Tamanho)
              .HasColumnName("Tamanho");

            builder.Property(c => c.Finalidade)
              .HasColumnName("Finalidade");

            builder.Property(c => c.Combustivel)
             .HasColumnName("Combustivel");

            builder.Property(c => c.TipoVeiculo)
             .HasColumnName("TipoVeiculo");
        }
    }
}
