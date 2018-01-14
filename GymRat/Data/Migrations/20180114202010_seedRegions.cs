using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GymRat.Data.Migrations
{
    public partial class seedRegions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID_MeasureID",
                table: "BodyRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "MeasureID",
                table: "BodyRegions",
                newName: "MeasureUserID");

            migrationBuilder.RenameIndex(
                name: "IX_BodyRegions_MeasureBodyRegionID_MeasureID",
                table: "BodyRegions",
                newName: "IX_BodyRegions_MeasureBodyRegionID_MeasureUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements",
                columns: new[] { "BodyRegionID", "UserID" });

            migrationBuilder.AddForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID_MeasureUserID",
                table: "BodyRegions",
                columns: new[] { "MeasureBodyRegionID", "MeasureUserID" },
                principalTable: "Measurements",
                principalColumns: new[] { "BodyRegionID", "UserID" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID_MeasureUserID",
                table: "BodyRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "MeasureUserID",
                table: "BodyRegions",
                newName: "MeasureID");

            migrationBuilder.RenameIndex(
                name: "IX_BodyRegions_MeasureBodyRegionID_MeasureUserID",
                table: "BodyRegions",
                newName: "IX_BodyRegions_MeasureBodyRegionID_MeasureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements",
                columns: new[] { "BodyRegionID", "ID" });

            migrationBuilder.AddForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID_MeasureID",
                table: "BodyRegions",
                columns: new[] { "MeasureBodyRegionID", "MeasureID" },
                principalTable: "Measurements",
                principalColumns: new[] { "BodyRegionID", "ID" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
