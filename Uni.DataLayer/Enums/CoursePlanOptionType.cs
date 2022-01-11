using System.ComponentModel;

namespace Uni.DataLayer.Enums
{
    /// <summary>
    /// نوع گزینه های طرح درس
    /// </summary>
    public enum CoursePlanOptionType
    {
        [Description("توضیحات")]
        ReferenceBooks ,
        [Description("اهداف")]
        Goals ,
        [Description("نتایج")]
        Results ,
        [Description("سرفصل ها")]
        Headings ,
        [Description("امکانات آموزشی")]
        EducationalFacilities ,
        [Description("تکالیف")]
        Homeworks ,
        [Description("پروژه ها")]
        Projects ,
        [Description("سایر منابع")]
        OtherSources 
    }
}
