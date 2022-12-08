using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
    public partial class AddGithubField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 21, 34, 25, 46, DateTimeKind.Utc).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2022, 12, 8, 21, 27, 43, 104, DateTimeKind.Utc).AddTicks(9289));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 21, 27, 43, 104, DateTimeKind.Utc).AddTicks(9289),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2022, 12, 8, 21, 34, 25, 46, DateTimeKind.Utc).AddTicks(6562));
        }
    }
}
