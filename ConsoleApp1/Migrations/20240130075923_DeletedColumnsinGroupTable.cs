using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Relations.Migrations
{
    /// <inheritdoc />
    public partial class DeletedColumnsinGroupTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScheduleEndTime",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ScheduleStartTime",
                table: "Groups");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "ScheduleEndTime",
                table: "Groups",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ScheduleStartTime",
                table: "Groups",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
