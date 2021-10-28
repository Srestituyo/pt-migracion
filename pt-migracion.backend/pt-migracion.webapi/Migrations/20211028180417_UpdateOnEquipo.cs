using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pt_migracion.webapi.Migrations
{
    public partial class UpdateOnEquipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EstadoId",
                table: "Equipo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_EstadoId",
                table: "Equipo",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Estados_EstadoId",
                table: "Equipo",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Estados_EstadoId",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_EstadoId",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Equipo");
        }
    }
}
