using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Domain.Entities;
using VefatcomAPI.Domain.Entities.Common;

namespace VefatcomAPI.Persistence.Contexts
{
    public class VefatcomAPIDbContext : DbContext
    {
        public VefatcomAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Dead> Deads { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
       
        
     
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker : Entitiyler üzerinden yapılan değişikliklerin yada yeni eklenen verilerinin yakalanmasını sağlayan property.
          var datas =  ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                 _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };

            }
                
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
