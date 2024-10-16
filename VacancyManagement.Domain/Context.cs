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
using VacancyManagement.Domain.Dtos.RawSqlDtos;

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

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserVacancy> UserVacancies { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<VacancyRequirement> VacancyRequirements { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizAnswer> QuizAnswers { get; set; }
        public DbSet<UserQuizAnswer> UserQuizAnswers { get; set; }
        public DbSet<QuizAnswerCompare> QuizAnswerCompares { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserVacancyConfiguration());

            modelBuilder.ApplyConfiguration(new VacancyConfiguration());
            modelBuilder.ApplyConfiguration(new VacancyRequirementConfiguration());

            modelBuilder.ApplyConfiguration(new QuizConfiguration());
            modelBuilder.ApplyConfiguration(new QuizAnswerConfiguration());

            modelBuilder.Entity<QuizAnswerCompare>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var migrationsConnectionString = @"Server=localhost;Database=VacancyManagement;Trusted_connection=true;TrustServerCertificate=True;";
            //var migrationsConnectionString = @"Server=localhost;Database=VacancyManagement;User Id=sa;Password=Salamsalam1!;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(migrationsConnectionString);

        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
