﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Uni.DataLayer;

#nullable disable

namespace Uni.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220110173041_init-db")]
    partial class initdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Uni.DataLayer.Entities.Achievement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Assessment")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("CourseShare")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CourseType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOptional")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("NumberOfUnit")
                        .HasColumnType("integer");

                    b.Property<string>("PrerequisiteCourseIds")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.CoursePlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EducationalFacilities")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("Goals")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("Headings")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("Homeworks")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OtherSources")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("Projects")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("ReferenceBooks")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Results")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<long>("TeacherId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("CoursePlans");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.CoursePlanAchievement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AchievementId")
                        .HasColumnType("bigint");

                    b.Property<long>("CoursePlanId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AchievementId");

                    b.ToTable("CoursePlanAchievements");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.Education", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EducationalField")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GraduationYear")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PlaceOfGraduation")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<long>("TeacherId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("AcademicRank")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Activities")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("Articles")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("Books")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DedicatedCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Honors")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("Inventions")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MembershipInCommunities")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("OtherDescription")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("Projects")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("ResearchField")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Resume")
                        .HasMaxLength(1200)
                        .HasColumnType("character varying(1200)");

                    b.Property<string>("WebSiteUrl")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.UserToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("AccessToken")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("AccessTokenExpireDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeviceName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.CoursePlan", b =>
                {
                    b.HasOne("Uni.DataLayer.Entities.Course", "Course")
                        .WithMany("CoursePlans")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Uni.DataLayer.Entities.Teacher", "Teacher")
                        .WithMany("CoursePlans")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.CoursePlanAchievement", b =>
                {
                    b.HasOne("Uni.DataLayer.Entities.Achievement", "Achievement")
                        .WithMany("CoursePlanAchievements")
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Uni.DataLayer.Entities.CoursePlan", "CoursePlan")
                        .WithMany("CoursePlanAchievements")
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Achievement");

                    b.Navigation("CoursePlan");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.Education", b =>
                {
                    b.HasOne("Uni.DataLayer.Entities.Teacher", "Teacher")
                        .WithMany("Educations")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.UserToken", b =>
                {
                    b.HasOne("Uni.DataLayer.Entities.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.Achievement", b =>
                {
                    b.Navigation("CoursePlanAchievements");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.Course", b =>
                {
                    b.Navigation("CoursePlans");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.CoursePlan", b =>
                {
                    b.Navigation("CoursePlanAchievements");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.Teacher", b =>
                {
                    b.Navigation("CoursePlans");

                    b.Navigation("Educations");
                });

            modelBuilder.Entity("Uni.DataLayer.Entities.User", b =>
                {
                    b.Navigation("UserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
