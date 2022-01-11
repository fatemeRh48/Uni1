using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به گزینه های طرح درس
    /// </summary>
    public class CoursePlanOptionConfiguration : EntityConfiguration<CoursePlanOption>
    {
        public override void Configure(EntityTypeBuilder<CoursePlanOption> builder)
        {
            #region Properties

            builder?.Property(x => x.CoursePlanId)
               .IsRequired();

            builder?.Property(x => x.Type)
               .IsRequired();

            builder?.Property(x => x.Value)
               .HasMaxLength(200)
               .IsRequired();

            #endregion

            #region Relations

            builder?.HasOne(x => x.CoursePlan)
               .WithMany(x => x.CoursePlanOptions)
               .HasForeignKey(x => x.CoursePlanId);

            #endregion
        }
    }
}
