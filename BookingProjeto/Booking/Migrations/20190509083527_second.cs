using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Imagem",
                table: "TipoQuarto",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Imagem",
                table: "Hoteis",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "TipoQuarto",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Hoteis",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }
    }
}
