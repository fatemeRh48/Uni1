using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// مدرس
    /// </summary>
    public class Teacher : BaseEntity
    {
        #region Properties

        /// <summary>
        /// کد اختصاصی
        /// </summary>
        public string DedicatedCode { get; set; }
        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// مرتبه دانشگاهی
        /// </summary>
        public AcademicRank AcademicRank { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// تحصیلات
        /// </summary>
        public virtual ICollection<Education> Educations { get; set; }
        /// <summary>
        /// طرح های درس
        /// </summary>
        public virtual ICollection<CoursePlan> CoursePlans { get; set; }
        /// <summary>
        /// گزینه های مدرس
        /// </summary>
        public virtual ICollection<TeacherOption> TeacherOptions { get; set; }

        #endregion
    }
}
