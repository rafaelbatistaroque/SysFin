using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFin.Domain.Entities;
using System;

namespace SysFin.Data.BD.EntitiesMap
{
    public class FaturaMap : IEntityTypeConfiguration<Fatura>
    {
        public void Configure(EntityTypeBuilder<Fatura> builder)
        {
            builder.ToTable("Faturas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataChegada).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.DataVencimento).IsRequired();
            builder.Property(x => x.MesReferencia).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Observacao).HasMaxLength(100);

            builder.HasOne(x => x.Prestador);
        }
    }
}
