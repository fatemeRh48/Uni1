using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.DataLayer.Configuration.Common;
using Uni.DataLayer.Entities;

namespace Uni.DataLayer.Configuration
{
    /// <summary>
    /// تنظیمات مربوط به موجودیت گزینه های مدرس
    /// </summary>
    public class TeacherOptionConfiguration : EntityConfiguration<TeacherOption>
    {
        public override void Configure(EntityTypeBuilder<TeacherOption> builder)
        {
            #region Properties

            builder?.Property(x => x.TeacherId)
               .IsRequired();

            builder?.Property(x => x.Type)
               .IsRequired();

            builder?.Property(x => x.Value)
               .HasMaxLength(200)
               .IsRequired();

            #endregion

            #region Relations

            builder?.HasOne(x => x.Teacher)
               .WithMany(x => x.TeacherOptions)
               .HasForeignKey(x => x.TeacherId);

            #endregion
        }
    }
}