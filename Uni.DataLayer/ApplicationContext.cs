using Microsoft.EntityFrameworkCore;
using Uni.DataLayer.Configuration;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
               
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherOption> TeacherOptions { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CoursePlan> CoursePlans { get; set; }
        public DbSet<CoursePlanOption> CoursePlanOptions { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<CoursePlanAchievement> CoursePlanAchievements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherOptionConfiguration());
            modelBuilder.ApplyConfiguration(new EducationConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CoursePlanConfiguration());
            modelBuilder.ApplyConfiguration(new CoursePlanOptionConfiguration());
            modelBuilder.ApplyConfiguration(new AchievementConfiguration());
            modelBuilder.ApplyConfiguration(new CoursePlanAchievementConfiguration());


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }

    }
}
