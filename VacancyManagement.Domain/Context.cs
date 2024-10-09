using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;
using VacancyManagement.Domain.EntityTypeConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace VacancyManagement.Domain
{
    public sealed class Context : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options, IHttpContextAccessor httpContextAccessor)
        : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var migrationsConnectionString = @"Server=localhost;Database=VacancyManagement;Trusted_connection=true;TrustServerCertificate=True;";
            //var migrationsConnectionString = @"Server=localhost;Database=ERP;User Id=sa;Password=Salamsalam1!;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(migrationsConnectionString);

        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            var userId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        data.Entity.CreatedBy = userId;
                        break;
                    case EntityState.Modified:
                        data.Entity.ModifiedDate = DateTime.UtcNow;
                        data.Entity.ModifiedBy = userId;
                        break;
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
