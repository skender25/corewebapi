using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corewebapi.Model
{
    public class CourseContext : DbContext
    {
        // Replace your connection string here
        readonly string connectionstring = "Server=tcp:demo89000.database.windows.net,1433;Initial Catalog=pruebaconalex;Persist Security Info=False;User ID=demouser;Password=Demo123456789-;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(connectionstring);
            base.OnConfiguring(options);
        }
    }

    
}
