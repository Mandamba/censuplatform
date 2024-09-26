using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Enterprise.Census.Management.API.Migrations
{
    /// <inheritdoc />
    public partial class altered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpokenLanguages_languages_LanguagesId",
                table: "SpokenLanguages");

            migrationBuilder.DropIndex(
                name: "IX_SpokenLanguages_LanguagesId",
                table: "SpokenLanguages");

            migrationBuilder.DropColumn(
                name: "LanguagesId",
                table: "SpokenLanguages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Person",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Person",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.CreateIndex(
                name: "IX_SpokenLanguages_LanguageId",
                table: "SpokenLanguages",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpokenLanguages_languages_LanguageId",
                table: "SpokenLanguages",
                column: "LanguageId",
                principalTable: "languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpokenLanguages_languages_LanguageId",
                table: "SpokenLanguages");

            migrationBuilder.DropIndex(
                name: "IX_SpokenLanguages_LanguageId",
                table: "SpokenLanguages");

            migrationBuilder.AddColumn<long>(
                name: "LanguagesId",
                table: "SpokenLanguages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ExpirationDate",
                table: "Person",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfBirth",
                table: "Person",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_SpokenLanguages_LanguagesId",
                table: "SpokenLanguages",
                column: "LanguagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpokenLanguages_languages_LanguagesId",
                table: "SpokenLanguages",
                column: "LanguagesId",
                principalTable: "languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
