using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت طرح درس
    /// </summary>
    public class CoursePlanConfiguration : EntityConfiguration<CoursePlan>
    {
        public override void Configure(EntityTypeBuilder<CoursePlan> builder)
        {
            #region Properties

            builder?.Property(x => x.RegisterDate)
               .IsRequired();

            builder?.Property(x => x.CourseId)
               .IsRequired();

            builder?.Property(x => x.TeacherId)
               .IsRequired();

            builder?.Property(x => x.ReferenceBooks)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Goals)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Results)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Headings)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.EducationalFacilities)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Homeworks)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Projects)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.OtherSources)
               .IsRequired(false)
               .HasMaxLength(1200);

            #endregion

            #region Relations

            builder?.HasOne(x => x.Course)
               .WithMany(x => x.CoursePlans)
               .HasForeignKey(x => x.CourseId);

            builder?.HasOne(x => x.Teacher)
               .WithMany(x => x.CoursePlans)
               .HasForeignKey(x => x.TeacherId);

            builder?.HasMany(x => x.CoursePlanAchievements)
               .WithOne(x => x.CoursePlan)
               .HasForeignKey(x => x.CoursePlanId);

            #endregion
        }
    }
}
