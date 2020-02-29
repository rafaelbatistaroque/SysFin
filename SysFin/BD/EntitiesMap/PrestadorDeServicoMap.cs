using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysFin.Domain.Entities;
using SysFin.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysFin.Data.BD.EntitiesMap
{
    public class PrestadorDeServicoMap : IEntityTypeConfiguration<PrestadorDeServico>
    {
        public void Configure(EntityTypeBuilder<PrestadorDeServico> builder)
        {
            builder.ToTable("PrestadoresDeServico");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(100);

            builder.HasMany(x => x.Faturas).WithOne(x => x.Prestador).OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new PrestadorDeServico(nome: "Energisa", descricao: "Prestador de servico")
            );
        }
    }
}
