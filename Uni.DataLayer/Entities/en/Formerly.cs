using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities.en
{
    /// <summary>
    /// لیست دروس ارائه شده در 5 سال اخیر
    /// </summary>
    public class Formerly:BaseEntity
    {
        #region property
       /// <summary>
       /// عنوان درس
       /// </summary>
        public string CourseSubject { get; set; }
        /// <summary>
        /// مقطع
        /// </summary>
       
        public string Grade { get; set; }
        /// <summary>
        /// انتشارات اصلی در 5 سال اخیر
        /// </summary>
        public string MainPublications { get; set; }
        
       /// <summary>
       /// عضویت در جوامع حرفه ای
       /// </summary>
    
        public string Membership { get; set; }
        /// <summary>
        /// ثبت اختراع
        /// </summary>
    
        public string Invention { get; set; }
  
        /// <summary>
        /// زمینه های تحقیقاتی
        /// </summary>
        
        public string Field { get; set; }
      
        /// <summary>
        /// پروژه های ارتباط با صنعت
        /// </summary>
      
        public string Project { get; set; }
       
        /// <summary>
        /// افتخارات و جوايز
        /// </summary>

        public string Award { get; set; }
     
        /// <summary>
        /// فعالیت های اجرايی دانشگاهی و حرفه ای در پنج سال اخیر
        /// </summary>
        public string Activity { get; set; }
      
        /// <summary>
        /// سایر
        /// </summary>
        public string Other { get; set; }
        /// <summary>
        /// آدرس صفحات شخصی
        /// </summary>
        public string PersonalAccount { get; set; }
        /// <summary>
        /// شناسه کاربر
        /// </summary>
        public int ProfesorId { get; set; }


        #endregion

        #region relations

        /// <summary>
        /// اطلاعات کاربر
        /// </summary>
        public virtual User Profesor { get; set; }
        
        #endregion



    }
}
