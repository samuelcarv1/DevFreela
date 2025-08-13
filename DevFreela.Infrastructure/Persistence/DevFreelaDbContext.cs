using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext : DbContext
    {

        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; private set; }
        public DbSet<User> Users { get; private set; }

        public DbSet<Skill> Skills { get; private set; }

        public DbSet<UserSkill> UserSkills { get; set; }

        public DbSet<ProjectComment> ProjectComments { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Freelancer)
                .WithMany(f => f.FreelanceProjects)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Client)
                .WithMany(f => f.OwnedProjects)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProjectComment>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<ProjectComment>()
                .HasOne(p => p.Project)
                .WithMany(f => f.Comments)
                .HasForeignKey(p => p.IdProject);

            modelBuilder.Entity<ProjectComment>()
                .HasOne(p => p.User)
                .WithMany(f => f.Comments)
                .HasForeignKey(p => p.IdUser);

            modelBuilder.Entity<Skill>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<User>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Skills)
                .WithOne()
                .HasForeignKey(p => p.IdSkill)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserSkill>()
                .HasKey(p => p.Id);

        }

    }
}
