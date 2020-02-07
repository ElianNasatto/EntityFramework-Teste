using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Contexto : DbContext
    {
        public Contexto(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<Contexto>(new CreateDatabaseIfNotExists<Contexto>());
        }

        public DbSet<Class1> Class { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
