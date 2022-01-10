using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// تحصیلات استاد
    /// </summary>
    public class Education : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شناسه استاد
        /// </summary>
        public long ProfesserId { get; set; }
        /// <summary>
        /// مقطع
        /// </summary>
        public Grade Grade { get; set; }
        /// <summary>
        /// محل اخذ مدرک
        /// </summary>
        public string PlaceOfGraduation { get; set; }
        /// <summary>
        /// سال فارغ التحصیلی
        /// </summary>
        public string GraduationYear { get; set; }
        /// <summary>
        /// رشته تحصیلی
        /// </summary>
        public string EducationalField { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// استاد
        /// </summary>
        public virtual Professor Professor { get; set; }

        #endregion
    }
}
