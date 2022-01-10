using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.DataLayer.Enums
{
    /// <summary>
    /// مرتبه دانشگاهی
    /// </summary>
    public enum AcademicRank
    {
        [Description("مربی آموزشیار و مربی")]
        Instructor ,
        [Description("استادیار")]
        AssistantProfessor ,
        [Description("دانشیار")]
        AssociateProfessor ,
        [Description("استاد")]
        Professor ,

    }
}
