using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventures.Model.DAL
{
    public class AdventuresContext : DbContext
    {

        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<EmpTrans> EmpTrans { get; set; }
        public DbSet<RespEmpresa> RespsEmpresas { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<PacoteCliente> PacoteClientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PacoteCliente>().HasKey(pc => new { pc.ClienteId, pc.PacoteId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=AdventuresDb;Integrated Security=true");
        }

    }
}
