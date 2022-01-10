using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.DataLayer.Enums
{
    /// <summary>
    /// نوع تحصیلات
    /// </summary>
    public enum Grade
    {
        [Description("دکتری")]
        PHD ,
        [Description("فوق لیسانس")]
        Master,
        [Description("لیسانس")]
        Expert
    }
}
