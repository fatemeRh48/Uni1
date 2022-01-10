using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities.syllabus
{
    /// <summary>
    /// مواد و امکانات آموزشی مورد نیاز دانشجو و استاد
    /// </summary>
    public class EducationalMaterials: BaseEntity
    {
        #region property
        /// <summary>
        /// افزودن مورد
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// افزودن تکالیف
        /// </summary>
        public string Assignments { get; set; }
        /// <summary>
        /// افزودن پروژه
        /// </summary>
        public string Projects { get; set; }
        /// <summary>
        /// افزودن سایر مراجع
        /// </summary>
        public string OtherReferences { get; set; }

        public int SyllabusId { get; set; }

        #endregion

        #region Relationships

        public Syllabus syllabus { get; set; }
      
        #endregion

    }
}
