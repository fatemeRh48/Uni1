
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uni.DataLayer.Entities.en;
using Uni.DataLayer.Entities.syllabus;

namespace Uni.DataLayer.Configuration
{
    public class FormerlyConfiguration : EntityConfiguration<Formerly>
    {
        public override void Configure(EntityTypeBuilder<Formerly> builder)
        {
            #region Properties

            #endregion

            #region Relations

            builder.HasOne(x => x.Profesor)
                .WithMany(x => x.Formerlies)
                .HasForeignKey(x => x.ProfesorId);

            #endregion
        }

        
    }
    
    public class EducationConfiguration : EntityConfiguration<Education>
    {
        public override void Configure(EntityTypeBuilder<Education> builder)
        {
            #region Properties

            #endregion

            #region Relations

            builder.HasOne(x => x.User)
                .WithMany(x => x.Educations)
                .HasForeignKey(x => x.UserId);

            #endregion
        }


    }
 
    public class UserConfiguration : EntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            #region Properties

            #endregion

            #region Relations

            builder.HasMany(x => x.Educations)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.Formerlies)
                .WithOne(x => x.Profesor)
                .HasForeignKey(x => x.ProfesorId); 
            

            #endregion
        }


    }
  
    public class CoursesConfiguration : EntityConfiguration<Courses>
    {
        public override void Configure(EntityTypeBuilder<Courses> builder)
        {
            #region Properties

            #endregion

            #region Relations

            builder.HasOne(x => x.Syllabus)
                .WithOne(x => x.Courses)
                .HasForeignKey<Syllabus>(x => x.CoursesId);
             


            #endregion
        }


    }

    public class SyllabusConfiguration : EntityConfiguration<Syllabus>
    {
        public override void Configure(EntityTypeBuilder<Syllabus> builder)
        {
            #region Properties

            #endregion

            #region Relations

            builder.HasOne(x => x.EducationalMaterials)
                .WithOne(x => x.syllabus)
                .HasForeignKey<EducationalMaterials>(x => x.SyllabusId);



            builder.HasOne(x => x.Courses)
                .WithOne(x => x.Syllabus)
                .HasForeignKey<Syllabus>(x => x.CoursesId);


            #endregion
        }


    }

}
