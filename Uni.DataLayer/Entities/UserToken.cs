using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// نشست های کاربر
    /// </summary>
    public class UserToken : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شناسه کاربر
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// توکن در دسترس
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// توکن بازیابی
        /// </summary>
        public string RefreshToken { get; set; }
        /// <summary>
        /// زمان انتقضا توکن
        /// </summary>
        public DateTime AccessTokenExpireDateTime { get; set; }
        /// <summary>
        /// نام دستگاه
        /// </summary>
        public string DeviceName { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// کاربر
        /// </summary>
        public virtual User User { get; set; }

        #endregion
    }
}
