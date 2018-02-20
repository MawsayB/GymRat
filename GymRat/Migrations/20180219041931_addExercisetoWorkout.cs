using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GymRat.Migrations
{
    public partial class addExercisetoWorkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseLabels");

            migrationBuilder.DropColumn(
                name: "LabelID",
                table: "Exercises");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Workouts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseID",
                table: "Workouts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Workouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "ExerciseID",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Workouts");

            migrationBuilder.AddColumn<int>(
                name: "LabelID",
                table: "Exercises",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ExerciseLabels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseLabels", x => x.ID);
                });
        }
    }
}
