using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatrimonioSenaiTaguatinga.Entities;

namespace PatrimonioSenaiTaguatinga.EntityConfigurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Sobrenome).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(50);
            builder.Property(x => x.IdNivel).IsRequired();
            builder.HasOne(x => x.Nivel).WithMany(x => x.Usuario).HasForeignKey(x => x.IdNivel);

        }
    }
}