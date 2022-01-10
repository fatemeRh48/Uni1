using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// کاربر سیستم
    /// </summary>
    public class User : BaseEntity
    {
        #region Properties

        /// <summary>
        /// نام کاربری
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// شماره موبایل
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// کلمه عبور
        /// </summary>
        public string Password { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// نشست های کاربر
        /// </summary>
        public virtual ICollection<UserToken> UserTokens { get; set; }

        #endregion
    }
}
