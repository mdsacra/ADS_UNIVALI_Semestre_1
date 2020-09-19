using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventure
{
    public class Context : DbContext
    {
        
        public Context() : base()
        {
            
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<EmpTrans> EmpTrans { get; set; }
        public DbSet<ResponsavelEmpresa> RespEmps { get; set; }

    }
}
