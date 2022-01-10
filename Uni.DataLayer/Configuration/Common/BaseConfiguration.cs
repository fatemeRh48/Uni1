using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Configuration.Common
{
    /// <summary>
    /// تنظیمات مربوط به کلاس پایه موجودیت های نرم افزار
    /// </summary>
    public class EntityConfiguration<TEntity>
        : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder?.HasKey(b => b.Id);

            builder?.Property(b => b.CreateDate)
                .IsRequired();

            builder?.Property(b => b.LastUpdateTime)
                .IsRequired();

            builder?.Property(x => x.IsDeleted)
                .IsRequired();
        }
    }
}
