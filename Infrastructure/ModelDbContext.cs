using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace Infrastructure
{
    public class ModelDbContext(DbContextOptions<ModelDbContext> options, IUserIdProvider userIdProvider) : DbContext(options)
    {

        public DbSet<Model> Models { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = userIdProvider.ToString(); // "_currentUserService.UserId";
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.IsActive = true;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = userIdProvider.ToString();
                        entry.Entity.LastModified = DateTime.Now;
                        break;

                    case EntityState.Deleted:
                        entry.Entity.LastModifiedBy = userIdProvider.ToString();
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
