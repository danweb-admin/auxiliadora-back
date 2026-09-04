using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RccManager.Domain.Entities;

namespace RccManager.Infra.Mappings
{
    public class InscricaoCampoValoresMap : IEntityTypeConfiguration<InscricaoCampoValores>
    {
        //public void Configure(EntityTypeBuilder<Local> builder)
        //{
        //    builder.ToTable("Locais");

        //    builder.HasKey(l => l.Id);

        //    builder.Property(l => l.Id)
        //        .IsRequired();

        //    builder.Property(l => l.NomeLocal);

        //    builder.Property(l => l.ImagemMapa)
        //        .HasColumnType("nvarchar(max)")
        //        .IsRequired(false);

        //    builder.Property(l => l.Latitude)
        //        .HasColumnType("float")
        //        .IsRequired();

        //    builder.Property(l => l.Longitude)
        //        .HasColumnType("float")
        //        .IsRequired();

        //    builder.Property(l => l.Endereco)
        //        .HasMaxLength(200)
        //        .IsRequired();

        //    builder.Property(l => l.Complemento)
        //        .HasMaxLength(100)
        //        .IsRequired(false);

        //    builder.Property(l => l.Bairro)
        //        .HasMaxLength(100)
        //        .IsRequired(false);

        //    builder.Property(l => l.Cidade)
        //        .HasMaxLength(100)
        //        .IsRequired(false);

        //    builder.Property(l => l.Estado)
        //        .HasMaxLength(50)
        //        .IsRequired(false);

        //    builder.Property(l => l.EventoId)
        //        .IsRequired();

        //    // 🔹 Relacionamento 1:1 com Evento
        //    builder.HasOne(l => l.Evento)
        //        .WithOne(e => e.Local)
        //        .HasForeignKey<Local>(l => l.EventoId)
        //        .OnDelete(DeleteBehavior.Cascade);
        //}
        public void Configure(EntityTypeBuilder<InscricaoCampoValores> builder)
        {
            builder.ToTable("Locais");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                .IsRequired();

            builder.Property(l => l.InscricaoId);

            builder.Property(l => l.EventoCampoId);

            builder.Property(l => l.Valor)
                .HasColumnType("varchar(100)")
                .IsRequired();

            

            // 🔹 Relacionamento 1:1 com Evento
            builder.HasOne(l => l.EventoCampo)
                .WithOne(e => e.InscricaoCampoValor)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
