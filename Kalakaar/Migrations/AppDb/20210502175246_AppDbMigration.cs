using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kalakaar.Migrations.AppDb
{
    public partial class AppDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Course",
            //    columns: table => new
            //    {
            //        CourseId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CourseCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Price = table.Column<int>(type: "int", nullable: false),
            //        Avail = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Image1Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Image2Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ImgBanner = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Instructor = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NoOfLectures = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Fees = table.Column<int>(type: "int", nullable: false),
            //        Duration = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Course", x => x.CourseId);
            //    });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Avail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image1Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgBanner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Course");

            migrationBuilder.DropTable(
                name: "Shop");

        }
    }
}
