using System.ComponentModel;

namespace Uni.DataLayer.Enums
{
    /// <summary>
    /// نوع گزینه های استاد
    /// </summary>
    public enum TeacherOptionType
    {
        [Description("آدرس صفحه اینترنتی")]
        WebSiteUrl ,
        [Description("زمینه تحقیقاتی")]
        ResearchField ,
        [Description("رزومه")]
        Resume ,
        [Description("کتاب ها")]
        Books ,
        [Description("مقالات")]
        Articles ,
        [Description("پروژه ها")]
        Projects ,
        [Description("فعالیت ها")]
        Activities ,
        [Description("اختراعات")]
        Inventions ,
        [Description("افتخارات")]
        Honors ,
        [Description("عضویت در جوامع حرفه ای ")]
        MembershipInCommunities ,
        [Description("سایر توضیحات")]
        OtherDescription ,
        [Description("درس های 5 سال اخیر")]
        CourseHistory
    }
}
