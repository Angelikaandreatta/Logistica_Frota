using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class EntregaMap : IEntityTypeConfiguration<Entrega>
    {
        public void Configure(EntityTypeBuilder<Entrega> builder)
        {
            builder.ToTable("Entregas");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Usuario_Id)
                .HasColumnName("Usuario_Id")
                .IsRequired();

            builder.Property(e => e.Veiculo_Id)
                .HasColumnName("Veiculo_Id")
                .IsRequired();

            builder.Property(e => e.Endereco_Id)
                .HasColumnName("Endereco_Id")
                .IsRequired();

            builder.Property(e => e.Status)
                .HasColumnName("Status")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Estimativa_Entrega)
                .HasColumnName("Estimativa_Entrega")
                .IsRequired();

            builder.Property(e => e.Data_Entrega)
                .HasColumnName("Data_Entrega");

            builder.HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.Usuario_Id);

            builder.HasOne(e => e.Veiculo)
                .WithMany()
                .HasForeignKey(e => e.Veiculo_Id);

            builder.HasOne(e => e.Endereco_Entrega)
                .WithMany()
                .HasForeignKey(e => e.Endereco_Id);
        }
    }
}
