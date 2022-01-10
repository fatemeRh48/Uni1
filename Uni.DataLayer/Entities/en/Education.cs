using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities.en
{
    public class Education:BaseEntity
    {
        #region Education
        public string Grade { get; set; }
        public string PlaceOfGraduation { get; set; }
        public int YearOfGraduation { get; set; }
        public string FieldOfStudy { get; set; }
        public int UserId { get; set; }
        #endregion

        #region Relationships
        public virtual User User { get; set; }

        #endregion
    }
}
