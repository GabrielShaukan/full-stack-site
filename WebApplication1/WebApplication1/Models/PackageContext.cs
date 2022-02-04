using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class PackageContext:DbContext
    {
        public PackageContext(DbContextOptions<PackageContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Package> Packages { get; set; }
    }
}
