using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت کاربر
    /// </summary>
    public class UserConfiguration : EntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            #region Properties

            builder?.Property(x => x.UserName)
               .IsRequired()
               .HasMaxLength(200);

            builder?.Property(x => x.Mobile)
               .IsRequired()
               .HasMaxLength(50);

            builder?.Property(x => x.Password)
               .IsRequired()
               .HasMaxLength(200);

            #endregion

            #region Relations

            builder?.HasMany(x => x.UserTokens)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            #endregion
        }
    }
}
