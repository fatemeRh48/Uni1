using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Uni.DataLayer.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    NumberOfUnit = table.Column<int>(type: "integer", nullable: false),
                    Grade = table.Column<string>(type: "text", nullable: false),
                    Assessment = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    CourseType = table.Column<string>(type: "text", nullable: false),
                    CourseShare = table.Column<string>(type: "text", nullable: false),
                    IsOptional = table.Column<bool>(type: "boolean", nullable: false),
                    PrerequisiteCourseIds = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DedicatedCode = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    FullName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    AcademicRank = table.Column<string>(type: "text", nullable: false),
                    WebSiteUrl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    ResearchField = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Resume = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Books = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Articles = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Projects = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Activities = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Inventions = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Honors = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    MembershipInCommunities = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    OtherDescription = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Mobile = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursePlans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegisterDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    TeacherId = table.Column<long>(type: "bigint", nullable: false),
                    ReferenceBooks = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Goals = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Results = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Headings = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    EducationalFacilities = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Homeworks = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    Projects = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    OtherSources = table.Column<string>(type: "character varying(1200)", maxLength: 1200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursePlans_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoursePlans_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherId = table.Column<long>(type: "bigint", nullable: false),
                    Grade = table.Column<string>(type: "text", nullable: false),
                    PlaceOfGraduation = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    GraduationYear = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    EducationalField = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    AccessToken = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    RefreshToken = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    AccessTokenExpireDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeviceName = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoursePlanAchievements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoursePlanId = table.Column<long>(type: "bigint", nullable: false),
                    AchievementId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePlanAchievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursePlanAchievements_Achievements_AchievementId",
                        column: x => x.AchievementId,
                        principalTable: "Achievements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoursePlanAchievements_CoursePlans_AchievementId",
                        column: x => x.AchievementId,
                        principalTable: "CoursePlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursePlanAchievements_AchievementId",
                table: "CoursePlanAchievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePlans_CourseId",
                table: "CoursePlans",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePlans_TeacherId",
                table: "CoursePlans",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_TeacherId",
                table: "Education",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTokens_UserId",
                table: "UserTokens",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursePlanAchievements");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "CoursePlans");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
