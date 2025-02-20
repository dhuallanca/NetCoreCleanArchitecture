using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ModelDbContext(DbContextOptions<ModelDbContext> options) : DbContext(options)
    {
        public DbSet<Model> Models { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "_currentUserService.UserId";
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.IsActive = true;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = "_currentUserService.UserId";
                        entry.Entity.LastModified = DateTime.Now;
                        break;

                    case EntityState.Deleted:
                        entry.Entity.LastModifiedBy = "_currentUserService.UserId";
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.IsActive = false;
                        break;
                }
            }

            var result = await base.SaveChangesAsync(cancellationToken);

            return result;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
