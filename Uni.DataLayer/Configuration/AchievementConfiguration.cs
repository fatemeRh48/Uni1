using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت دستاورد برنامه
    /// </summary>
    public class AchievementConfiguration : EntityConfiguration<Achievement>
    {
        public override void Configure(EntityTypeBuilder<Achievement> builder)
        {
            #region Properties

            builder?.Property(x => x.Title)
              .IsRequired()
              .HasMaxLength(200);

            #endregion

            #region Relations

            builder?.HasMany(x => x.CoursePlanAchievements)
               .WithOne(x => x.Achievement)
               .HasForeignKey(x => x.AchievementId);

            #endregion
        }
    }
}
