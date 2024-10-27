using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(u => u.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Email)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Senha)
                .HasColumnName("Senha")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Acesso)
                .HasColumnName("Acesso")
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
