using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// ارتباط طرح درس با دستاورد های برنامه
    /// </summary>
    public class CoursePlanAchievement : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شناسه طرح درس
        /// </summary>
        public long CoursePlanId { get; set; }
        /// <summary>
        /// شناسه دستاورد برنامه
        /// </summary>
        public long AchievementId { get; set; }
        /// <summary>
        /// میزان دستاورد
        /// </summary>
        public AchievementValue Value { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// طرح درس
        /// </summary>
        public virtual CoursePlan CoursePlan { get; set; }
        /// <summary>
        /// دستاورد
        /// </summary>
        public virtual Achievement Achievement { get; set; }

        #endregion
    }
}
