using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت تحصیلات
    /// </summary>
    public class EducationConfiguration : EntityConfiguration<Education>
    {
        public override void Configure(EntityTypeBuilder<Education> builder)
        {
            #region Properties

            builder?.Property(x => x.TeacherId)
              .IsRequired(true);

            builder?.Property(x => x.Grade)
              .IsRequired(true)
              .HasConversion<string>();

            builder?.Property(x => x.EducationalField)
               .IsRequired(true)
               .HasMaxLength(500);


            builder?.Property(x => x.GraduationYear)
               .IsRequired(false)
               .HasMaxLength(50);

            builder?.Property(x => x.PlaceOfGraduation)
               .IsRequired(false)
               .HasMaxLength(200);


            #endregion

            #region Relations

            builder?.HasOne(x => x.Teacher)
               .WithMany(x => x.Educations)
               .HasForeignKey(x => x.TeacherId);

            #endregion
        }
    }
}
