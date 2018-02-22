using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GymRat.Migrations
{
    public partial class updatedWorkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Workouts");

            migrationBuilder.RenameColumn(
                name: "ExerciseID",
                table: "Workouts",
                newName: "SelectedExercise");

            migrationBuilder.RenameColumn(
                name: "Rep",
                table: "Sets",
                newName: "ExpectedReps");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Workouts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ActualReps",
                table: "Sets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpectedReps",
                table: "Exercises",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpectedSets",
                table: "Exercises",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "ActualReps",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "ExpectedReps",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExpectedSets",
                table: "Exercises");

            migrationBuilder.RenameColumn(
                name: "SelectedExercise",
                table: "Workouts",
                newName: "ExerciseID");

            migrationBuilder.RenameColumn(
                name: "ExpectedReps",
                table: "Sets",
                newName: "Rep");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Workouts",
                nullable: true);
        }
    }
}
