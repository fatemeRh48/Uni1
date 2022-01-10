using System.ComponentModel;

namespace Uni.DataLayer.Enums
{
    /// <summary>
    /// سهم درس در اقناع نيازهاي ملاك 5
    /// </summary>
    public enum CourseShare
    {
        [Description("عمومی")]
        General,
        [Description("تخصصی")]
        Professional,
        [Description("مهندسی")]
        Engineering
    }   
}
