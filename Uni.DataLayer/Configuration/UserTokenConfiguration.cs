using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت نشست های کاربر
    /// </summary>
    public class UserTokenConfiguration : EntityConfiguration<UserToken>
    {
        public override void Configure(EntityTypeBuilder<UserToken> builder)
        {
            #region Properties


            builder?.Property(x => x.UserId)
                .IsRequired();

            builder?.Property(x => x.AccessToken)
                .IsRequired()
                .HasMaxLength(500);

            builder?.Property(x => x.DeviceName)
                .IsRequired(false);

            builder?.Property(x => x.RefreshToken)
                .IsRequired()
                .HasMaxLength(300);

            builder?.Property(x => x.AccessTokenExpireDateTime)
                .IsRequired();

            #endregion

            #region Relations

            builder?.HasOne(x => x.User)
               .WithMany(x => x.UserTokens)
               .HasForeignKey(x => x.UserId);

            #endregion
        }
    }
}
