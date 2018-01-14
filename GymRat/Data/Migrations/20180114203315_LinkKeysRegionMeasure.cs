using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GymRat.Data.Migrations
{
    public partial class LinkKeysRegionMeasure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID_MeasureUserID",
                table: "BodyRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_BodyRegions_MeasureBodyRegionID_MeasureUserID",
                table: "BodyRegions");

            migrationBuilder.DropColumn(
                name: "MeasureUserID",
                table: "BodyRegions");

            migrationBuilder.AlterColumn<int>(
                name: "BodyRegionID",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements",
                column: "BodyRegionID");

            migrationBuilder.CreateIndex(
                name: "IX_BodyRegions_MeasureBodyRegionID",
                table: "BodyRegions",
                column: "MeasureBodyRegionID");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID",
                table: "BodyRegions",
                column: "MeasureBodyRegionID",
                principalTable: "Measurements",
                principalColumn: "BodyRegionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID",
                table: "BodyRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_BodyRegions_MeasureBodyRegionID",
                table: "BodyRegions");

            migrationBuilder.AlterColumn<int>(
                name: "BodyRegionID",
                table: "Measurements",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "MeasureUserID",
                table: "BodyRegions",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Measurements",
                table: "Measurements",
                columns: new[] { "BodyRegionID", "UserID" });

            migrationBuilder.CreateIndex(
                name: "IX_BodyRegions_MeasureBodyRegionID_MeasureUserID",
                table: "BodyRegions",
                columns: new[] { "MeasureBodyRegionID", "MeasureUserID" });

            migrationBuilder.AddForeignKey(
                name: "FK_BodyRegions_Measurements_MeasureBodyRegionID_MeasureUserID",
                table: "BodyRegions",
                columns: new[] { "MeasureBodyRegionID", "MeasureUserID" },
                principalTable: "Measurements",
                principalColumns: new[] { "BodyRegionID", "UserID" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
