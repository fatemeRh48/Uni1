using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// درس
    /// </summary>
    public class Course : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شماره درس
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// تعداد واحد
        /// </summary>
        public int NumberOfUnit { get; set; }
        /// <summary>
        /// مقطع تحصیلی
        /// </summary>
        public Grade Grade { get; set; }
        /// <summary>
        /// ارزشیابی
        /// </summary>
        public string? Assessment { get; set; }
        /// <summary>
        /// نوع درس
        /// </summary>
        public CourseType CourseType { get; set; }
        /// <summary>
        /// سهم درس
        /// </summary>
        public CourseShare CourseShare { get; set; }
        /// <summary>
        /// اختیاری است / نیست
        /// </summary>
        public bool IsOptional { get; set; }
        /// <summary>
        /// شناسه درس های پیش نیاز
        /// </summary>
        public string PrerequisiteCourseIds { get; set; }

        #endregion

        #region Relations
        
        /// <summary>
        /// طرح درس
        /// </summary>
        public virtual ICollection<CoursePlan> CoursePlans { get; set; }

        #endregion
    }
}
