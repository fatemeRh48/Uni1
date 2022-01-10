using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// تحصیلات مدرس
    /// </summary>
    public class Education : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شناسه مدرس
        /// </summary>
        public long TeacherId { get; set; }
        /// <summary>
        /// مقطع
        /// </summary>
        public Grade Grade { get; set; }
        /// <summary>
        /// محل اخذ مدرک
        /// </summary>
        public string? PlaceOfGraduation { get; set; }
        /// <summary>
        /// سال فارغ التحصیلی
        /// </summary>
        public string? GraduationYear { get; set; }
        /// <summary>
        /// رشته تحصیلی
        /// </summary>
        public string EducationalField { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// مدرس
        /// </summary>
        public virtual Teacher Teacher { get; set; }

        #endregion
    }
}
