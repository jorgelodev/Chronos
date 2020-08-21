using Chronos.Business.Entities;
using Chronos.Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Chronos.Infra.Data.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options) {
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                        e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(
                    e => e.GetForeignKeys())) 
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
                       
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        public DbSet<Sds> Sds { get; set; }
        public DbSet<Manual> Manual { get; set; }
        public DbSet<Diagrama> Diagrama { get; set; }
        public DbSet<Funcionalidade> Funcionalidade { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<Menu> Menu { get; set; }
    }
}
