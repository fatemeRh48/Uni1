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
        /// <summary>
        /// آدرس صفحه اینترنتی
        /// </summary>
        public string? WebSiteUrl { get; set; }
        /// <summary>
        /// زمینه تحقیقاتی
        /// </summary>
        public string? ResearchField { get; set; }
        /// <summary>
        /// تجربه کاری - رزومه
        /// </summary>
        public string? Resume { get; set; }
        /// <summary>
        /// کتاب ها
        /// </summary>
        public string? Books { get; set; }
        /// <summary>
        /// مقالات
        /// </summary>
        public string? Articles { get; set; }
        /// <summary>
        /// پروژه ها
        /// </summary>
        public string? Projects { get; set; }
        /// <summary>
        /// فعالیت ها
        /// </summary>
        public string? Activities { get; set; }
        /// <summary>
        /// اختراعات
        /// </summary>
        public string? Inventions { get; set; }
        /// <summary>
        /// افتخارات
        /// </summary>
        public string? Honors { get; set; }
        /// <summary>
        /// عضویت در جوامع
        /// </summary>
        public string? MembershipInCommunities { get; set; }        
        /// <summary>
        /// سایر توضیحات
        /// </summary>
        public string? OtherDescription { get; set; }

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

        #endregion
    }
}
