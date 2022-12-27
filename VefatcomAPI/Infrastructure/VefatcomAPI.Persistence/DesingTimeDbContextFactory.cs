using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Persistence.Contexts;

namespace VefatcomAPI.Persistence
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<VefatcomAPIDbContext>
    {
        public VefatcomAPIDbContext CreateDbContext(string[] args)
        {
          

            DbContextOptionsBuilder<VefatcomAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
