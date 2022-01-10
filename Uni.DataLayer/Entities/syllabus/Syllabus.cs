
using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities.syllabus
{
    public class Syllabus:BaseEntity
    {
        #region Basic Information
        /// <summary>
        /// شماره
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// نام درس
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// تعداد واحد
        /// </summary>
        public string NumberOfCredits { get; set; }
        /// <summary>
        /// مقطع
        /// </summary>
        public string Grade { get; set; }
        /// <summary>
        /// مدرس : 

        /// </summary>
        public string Instructor { get; set; }
        /// <summary>
        /// ارزشیابی : 

        /// </summary>
        public string Assessment { get; set; }
        /// <summary>
        /// سهم درس در اقناع نيازهاي ملاك 5 

        /// </summary>
        public string need { get; set; }
        /// <summary>
        /// تنظیم کننده و تاریخ تنظیم  

        /// </summary>
        public string SettingDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CoursesId { get; set; }
        /// <summary>
        /// ارتباط درس با دستاوردهاي برنامه :
        #endregion
        /// </summary>
        #region The Relation of the Course with the Achievements of the Program

        /// <summary>
        /// 1. به‌کارگیری دانش‌های ریاضی، علوم و مهندسی :

        /// </summary>
        public string Knowledge { get; set; }
        /// <summary>
        /// 2. طراحی و اجرای آزمایش‌ها و تحلیل و تفسیر داده ها :

        /// </summary>
       
       public string Interpretation { get; set; }
        /// <summary>
        /// 3. طراحی یک وسیله، سیستم یا فرایند، جهت رفع یک نیاز :
        /// </summary>

        public string DesigningADevice { get; set; }
        /// <summary>
        /// 4. کار در گروه‌های دارای عملکردهای متفاوت :

        /// </summary>

        public string GroupsFunctions { get; set; }
        /// <summary>
        /// 5. شناسایی، فرموله کردن و حل مشکلات مهندسی :

        /// </summary>

        public string IdentifyingFormulating { get; set; }
        /// <summary>
        /// 6. درک مسئولیت‌های حرفه‌ای و اخلاقی :

        /// </summary>
        public string Responsibility { get; set; }
        /// <summary>
        /// 7. ایجاد ارتباط موثر (شفاهی، نوشتاری و تصویری) :

        /// </summary>
        public string Communication { get; set; }
        /// <summary>
        /// 8. درک تاثیر راه حل‌‌های مهندسی بر جامعه محلی و جهانی :
        /// </summary>
        public string GlobalCommunity { get; set; }
        /// <summary>
        /// 9. درک ضرورت کسب مداوم آموزش در طول کار حرفه ای :

        /// </summary>
        public string Training{ get; set; }
        /// <summary>
        /// 10. آگاهی از مسایل معاصر :

        /// </summary>
        public string Issues { get; set; }
        /// <summary>
        /// 11. استفاده از فناوری‌ها، مهارت‌ها، و ابزارهای مدرن، در فعالیت‌های مهندسی :

        /// </summary>
        public string ModernTechnology{ get; set; }
        /// <summary>
        /// نوع درس :

        /// </summary>
        public string lessonType { get; set; }
        #endregion


        #region Relationships
        public EducationalMaterials EducationalMaterials { get; set; }
        public Courses Courses { get; set; }
        #endregion
    }
}
