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
        /// <summary>
        /// کتاب های مرجع
        /// </summary>
        public string? ReferenceBooks { get; set; }
        /// <summary>
        /// اهداف
        /// </summary>
        public string? Goals { get; set; }
        /// <summary>
        /// نتایج
        /// </summary>
        public string? Results { get; set; }
        /// <summary>
        /// سرفصل ها
        /// </summary>
        public string? Headings { get; set; }
        /// <summary>
        /// امکانات آموزشی
        /// </summary>
        public string? EducationalFacilities { get; set; }
        /// <summary>
        /// تکالیف
        /// </summary>
        public string? Homeworks { get; set; }
        /// <summary>
        /// پروژه ها
        /// </summary>
        public string? Projects { get; set; }
        /// <summary>
        /// سایر منابع 
        /// </summary>
        public string? OtherSources { get; set; }

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

        #endregion
    }
}
