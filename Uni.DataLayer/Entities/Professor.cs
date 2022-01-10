using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// استاد
    /// </summary>
    public class Professor : BaseEntity
    {
        #region Properties

        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// مرتبه دانشگاهی
        /// </summary>
        public string AcademicRank { get; set; }
        /// <summary>
        /// تجربه کاری - رزومه
        /// </summary>
        public string Resume { get; set; }
        /// <summary>
        /// مقالات
        /// </summary>
        public string Articles { get; set; }
        /// <summary>
        /// عوضیت در جوامع
        /// </summary>
        public string MembershipInCommunities { get; set; }
        /// <summary>
        /// افتخارات
        /// </summary>
        public string Honors { get; set; }
        /// <summary>
        /// پروژه ها
        /// </summary>
        public string Projects { get; set; }
        /// <summary>
        /// فعالیت ها
        /// </summary>
        public string Activities { get; set; }
        /// <summary>
        /// اختراعات
        /// </summary>
        public string Inventions { get; set; }
        /// <summary>
        /// آدرس صفحه اینترنتی
        /// </summary>
        public string WebSiteUrl { get; set; }
        /// <summary>
        /// سایر توضیحات
        /// </summary>
        public string OtherDescription { get; set; }
        /// <summary>
        /// زمینه تحقیقاتی
        /// </summary>
        public string ResearchField { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// تحصیلات
        /// </summary>
        public virtual ICollection<Education> Educations { get; set; }

        #endregion


    }
}
