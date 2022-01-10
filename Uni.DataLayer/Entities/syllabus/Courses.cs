
using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities.syllabus
{
    public class Courses:BaseEntity
    {
        #region Prerequisite Courses
        public string PrerequisiteCourse { get; set; }
        /// <summary>
        /// منابع
        /// </summary>
        public string SourceBook { get; set; }


        /// <summary>
        /// Course Purpose
        /// </summary>
        public string CoursePurpose { get; set; }
        
        /// <summary>
        /// Course Results
        /// </summary>
        public string CourseResult { get; set; }
      

        /// <summary>
        /// Syllabus
        /// </summary>
        public string Item { get; set; }

        #endregion


        #region Relations
        public Syllabus Syllabus { get; set; }
        #endregion

    }
}
