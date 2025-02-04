using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinQ_DB.Employee;

namespace LinQ_DB
{
    //DbContext class – it is responsible to communicate with database
    //DbSet - Represents the collection of all entities in the context, or that can be queried from the database, of a given type.
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=;Initial Catalog=; Trusted_Connection=true;TrustServerCertificate=True;");//change your connection as required
        }
    }
}
