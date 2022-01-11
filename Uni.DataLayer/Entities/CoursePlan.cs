using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// طرح درس
    /// </summary>
    public class CoursePlan : BaseEntity
    {
        #region Properties

        /// <summary>
        /// تاریخ تنظیم
        /// </summary>
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// شناسه درس
        /// </summary>
        public long CourseId { get; set; }
        /// <summary>
        /// شناسه مدرس
        /// </summary>
        public long TeacherId{ get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// درس
        /// </summary>
        public virtual Course Course { get; set; }
        /// <summary>
        /// مدرس
        /// </summary>
        public virtual Teacher Teacher{ get; set; }
        /// <summary>
        /// رابط دستاورد های برنامه
        /// </summary>
        public virtual ICollection<CoursePlanAchievement> CoursePlanAchievements { get; set; }
        /// <summary>
        /// گزینه های طرح درس
        /// </summary>
        public virtual ICollection<CoursePlanOption> CoursePlanOptions { get; set; }

        #endregion
    }
}
