using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Entities
{
    /// <summary>
    /// دستاورد برنامه
    /// </summary>
    public class Achievement : BaseEntity
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// رابط دستاورد های برنامه و طرح درس
        /// </summary>
        public virtual ICollection<CoursePlanAchievement> CoursePlanAchievements { get; set; }


    }
}
