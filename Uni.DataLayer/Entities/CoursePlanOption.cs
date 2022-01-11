using Uni.DataLayer.Entities.Common;
using Uni.DataLayer.Enums;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// گزینه های طرح درس
    /// </summary>
    public class CoursePlanOption : BaseEntity
    {
        #region Properties

        /// <summary>
        /// شناسه طرح درس
        /// </summary>
        public long CoursePlanId { get; set; }
        /// <summary>
        /// نوع گزینه طرح درس
        /// </summary>
        public CoursePlanOptionType Type { get; set; }
        /// <summary>
        /// مقدار
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// طرح درس
        /// </summary>
        public virtual CoursePlan CoursePlan { get; set; }

        #endregion
    }
}
