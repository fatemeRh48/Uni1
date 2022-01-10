using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// ارتباط درس با دستاورد های برنامه
    /// </summary>
    public class CourseAchievement : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شناسه درس
        /// </summary>
        public long CourseId { get; set; }
        /// <summary>
        /// شناسه دستاورد
        /// </summary>
        public long AchievementId { get; set; }
        /// <summary>
        /// مقدار دستاورد
        /// </summary>
        public AchievementValue Value { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// واحد درسی
        /// </summary>
        public virtual Course Course { get; set; }
        /// <summary>
        /// دستاورد
        /// </summary>
        public virtual Achievement Achievement { get; set; }

        #endregion
    }
}
