using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// واحد درسی
    /// </summary>
    public class Course : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شناسه استاد
        /// </summary>
        public long ProfessorId { get; set; }
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
        public string Assessment { get; set; }
        /// <summary>
        /// تاریخ تنظیم
        /// </summary>
        public DateTime RegisterDate { get; set; }
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
        /// درس های پیش نیاز
        /// </summary>
        public string Prerequisite { get; set; }
        /// <summary>
        /// کتاب های منبع
        /// </summary>
        public string ResourceBook { get; set; }
        /// <summary>
        /// اهداف
        /// </summary>
        public string Goals { get; set; }
        /// <summary>
        /// نتایج
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// سرفصل
        /// </summary>
        public string Heading { get; set; }
        /// <summary>
        /// امکانات آموزشی
        /// </summary>
        public string EducationalFacilities { get; set; }
        /// <summary>
        /// تکالیف
        /// </summary>
        public string Homeworks { get; set; }
        /// <summary>
        /// پروژه ها
        /// </summary>
        public string Projects { get; set; }
        /// <summary>
        /// سایر منابع 
        /// </summary>
        public string OtherResource { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// رابط دستاورد های برنامه
        /// </summary>
        public virtual ICollection<CourseAchievement> CourseAchievements { get; set; }

        #endregion
    }
}
