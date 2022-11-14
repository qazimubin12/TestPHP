using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPHP.Entities;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace TestPHP.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DSContext : IdentityDbContext<User>, IDisposable
    {
        public DSContext() : base("MyConnection")
        {

        }

        public static DSContext Create()
        {
            return new DSContext();
        }
        public DbSet<Product> Products { get; set; }

    }
}
