using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SysFin.Data.BD.EntitiesMap;
using SysFin.Domain.Entities;

namespace SysFin.Data.BD
{
    public class SysFinDataContext : DbContext
    {
        public DbSet<Fatura> Faturas { get; set; }
        private IConfiguration Config { get;}
        public DbSet<PrestadorDeServico> PrestadoresDeServico { get; set; }
        public SysFinDataContext(DbContextOptions options, IConfiguration config)
            : base(options)
        {
            Config = config;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PrestadorDeServicoMap());
            builder.ApplyConfiguration(new FaturaMap());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.GetConnectionString("DataContext"));
        }
    }
}
