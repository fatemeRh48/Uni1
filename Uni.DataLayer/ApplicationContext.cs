using Microsoft.EntityFrameworkCore;
using Uni.DataLayer.Configuration;
using Uni.DataLayer.Entities.en;
using Uni.DataLayer.Entities.syllabus;

namespace Uni.DataLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
               
        }

        public DbSet<User> User { get; set; }
        public DbSet<Formerly> formerly { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Syllabus> syllabus { get; set; }
        public DbSet<Courses> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FormerlyConfiguration());
            modelBuilder.ApplyConfiguration(new EducationConfiguration());
            modelBuilder.ApplyConfiguration(new SyllabusConfiguration());
            modelBuilder.ApplyConfiguration(new CoursesConfiguration());

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }

    }
}
