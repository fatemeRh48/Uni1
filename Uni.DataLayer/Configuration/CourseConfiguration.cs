using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت درس
    /// </summary>
    public class CourseConfiguration : EntityConfiguration<Course>
    {
        public override void Configure(EntityTypeBuilder<Course> builder)
        {
            #region Properties

            builder?.Property(x => x.Number)
               .IsRequired(true)
               .HasMaxLength(200);

            builder?.Property(x => x.Title)
               .IsRequired(true)
               .HasMaxLength(200);

            builder?.Property(x => x.NumberOfUnit)
               .IsRequired(true);

            builder?.Property(x => x.Grade)
               .IsRequired(true)
               .HasConversion<string>();

            builder?.Property(x => x.Assessment)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.CourseType)
               .IsRequired(true)
               .HasConversion<string>();

            builder?.Property(x => x.CourseShare)
               .IsRequired(true)
               .HasConversion<string>();

            builder?.Property(x => x.IsOptional)
               .IsRequired(true);

            builder?.Property(x => x.PrerequisiteCourseIds)
               .IsRequired(false);

            #endregion

            #region Relations

            builder?.HasMany(x => x.CoursePlans)
               .WithOne(x => x.Course)
               .HasForeignKey(x => x.CourseId);

            #endregion
        }
    }
}
