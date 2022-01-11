using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت مدرس
    /// </summary>
    public class TeacherConfiguration : EntityConfiguration<Teacher>
    {
        public override void Configure(EntityTypeBuilder<Teacher> builder)
        {
            #region Properties

            builder?.Property(x => x.DedicatedCode)
               .IsRequired()
               .HasMaxLength(200);

            builder?.Property(x => x.FullName)
               .IsRequired()
               .HasMaxLength(200);

            builder?.Property(x => x.AcademicRank)
               .IsRequired()
               .HasConversion<string>();

            #endregion

            #region Relations

            builder?.HasMany(x => x.Educations)
               .WithOne(x => x.Teacher)
               .HasForeignKey(x => x.TeacherId);

            builder?.HasMany(x => x.CoursePlans)
               .WithOne(x => x.Teacher)
               .HasForeignKey(x => x.TeacherId);

            builder?.HasMany(x => x.TeacherOptions)
                .WithOne(x => x.Teacher)
                .HasForeignKey(x => x.TeacherId);

            #endregion
        }
    }
}
