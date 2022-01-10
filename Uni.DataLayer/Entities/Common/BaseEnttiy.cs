namespace Uni.DataLayer.Entities.Common
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// تاریخ ایجاد
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// آخرین بروزرسانی
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// حذف شده / نشده
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
