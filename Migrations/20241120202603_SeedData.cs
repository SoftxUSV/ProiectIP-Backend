using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProiectIP.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Description", "EstablishedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Facultatea de Inginerie Electrica si Stiinta Calculatoarelor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIESC" },
                    { 2, "Facultatea de Economie, Administrație și Afaceri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FEAA" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "FacultyId", "Name", "Overview" },
                values: new object[,]
                {
                    { 1, 1, "Calculatoare", "" },
                    { 2, 1, "Automatica", "" },
                    { 3, 2, "Contabilitate", "" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Capacity", "Name", "SpecializationId", "YearOfStudy" },
                values: new object[,]
                {
                    { 1, 0, "3112b", 1, 0 },
                    { 2, 0, "4112a", 2, 0 },
                    { 3, 0, "5112a", 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "Duration", "GroupId", "Location", "Name", "ScheduledDate" },
                values: new object[,]
                {
                    { 1, 0, 1, "C202", "Proiectarea Bazelor de Date", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 0, 2, "E101", "Matematici Speciale", new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
