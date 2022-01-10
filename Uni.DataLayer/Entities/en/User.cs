
using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities.en
{
    public class User:BaseEntity
    {
        #region property
        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// مرتبه دانشگاهی
        /// </summary>
        public string AcademicRank { get; set; }
  
        /// <summary>
        /// مقطع
        /// </summary>
        public string Grade { get; set; }
        /// <summary>
        /// محل اخذ مدرک
        /// </summary>
        public string PlaceOfGraduation { get; set; }
        /// <summary>
        /// سال فارغ التحصیلی
        /// </summary>
        
        public int YearOfGraduation { get; set; }
        /// <summary>
        /// رشته تحصیلی
        /// </summary>
        public string FieldOfStudy { get; set; }     
        /// <summary>
        /// تجربه کاری
        /// </summary>
        public string WorkExperience { get; set; }

        #endregion
        #region Relations
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection <Formerly> Formerlies { get; set; }
      
        #endregion

    }
}
