using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت رابط دستاورد برنامه و طرح درس
    /// </summary>
    public class CoursePlanAchievementConfiguration : EntityConfiguration<CoursePlanAchievement>
    {
        public override void Configure(EntityTypeBuilder<CoursePlanAchievement> builder)
        {
            #region Properties

            builder?.Property(x => x.CoursePlanId)
               .IsRequired(true);

            builder?.Property(x => x.AchievementId)
               .IsRequired(true);

            builder?.Property(x => x.Value)
               .IsRequired(true)
               .HasConversion<string>();

            #endregion

            #region Relations

            builder?.HasOne(x => x.Achievement)
               .WithMany(x => x.CoursePlanAchievements)
               .HasForeignKey(x => x.AchievementId);

            builder?.HasOne(x => x.CoursePlan)
               .WithMany(x => x.CoursePlanAchievements)
               .HasForeignKey(x => x.AchievementId);

            #endregion
        }
    }
}
