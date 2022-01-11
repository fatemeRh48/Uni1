using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// گزینه های مدرس
    /// </summary>
    public class TeacherOption : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شناسه مدرس
        /// </summary>
        public long TeacherId { get; set; }
        /// <summary>
        /// نوع گزینه
        /// </summary>
        public TeacherOptionType Type { get; set; }
        /// <summary>
        /// مقدار
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// استاد
        /// </summary>
        public virtual Teacher Teacher { get; set; }

        #endregion

    }
}
