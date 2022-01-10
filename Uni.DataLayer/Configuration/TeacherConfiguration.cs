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

            builder?.Property(x => x.WebSiteUrl)
               .IsRequired(false)
               .HasMaxLength(200);

            builder?.Property(x => x.ResearchField)
               .IsRequired(false)
               .HasMaxLength(500);

            builder?.Property(x => x.Resume)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Books)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Articles)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Projects)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Activities)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Inventions)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.Honors)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.MembershipInCommunities)
               .IsRequired(false)
               .HasMaxLength(1200);

            builder?.Property(x => x.OtherDescription)
               .IsRequired(false)
               .HasMaxLength(1200);

            #endregion

            #region Relations

            builder?.HasMany(x => x.Educations)
               .WithOne(x => x.Teacher)
               .HasForeignKey(x => x.TeacherId);

            builder?.HasMany(x => x.CoursePlans)
               .WithOne(x => x.Teacher)
               .HasForeignKey(x => x.TeacherId);

            #endregion
        }
    }
}
