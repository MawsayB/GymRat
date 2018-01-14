using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GymRat.Data.Migrations
{
    public partial class seeRegions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeasureBodyRegionID",
                table: "BodyRegions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeasureID",
                table: "BodyRegions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BodyRegions_MeasureBodyRegionID_MeasureID",
                table: "BodyRegions",
                columns: new[] { "MeasureBodyRegionID", "MeasureID" });

            migrationBuilder.AddForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID_MeasureID",
                table: "BodyRegions",
                columns: new[] { "MeasureBodyRegionID", "MeasureID" },
                principalTable: "Measurements",
                principalColumns: new[] { "BodyRegionID", "ID" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID_MeasureID",
                table: "BodyRegions");

            migrationBuilder.DropIndex(
                name: "IX_BodyRegions_MeasureBodyRegionID_MeasureID",
                table: "BodyRegions");

            migrationBuilder.DropColumn(
                name: "MeasureBodyRegionID",
                table: "BodyRegions");

            migrationBuilder.DropColumn(
                name: "MeasureID",
                table: "BodyRegions");
        }
    }
}
