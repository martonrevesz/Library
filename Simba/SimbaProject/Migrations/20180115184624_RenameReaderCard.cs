using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SimbaProject.Migrations
{
    public partial class RenameReaderCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReaderCards",
                table: "ReaderCards");

            migrationBuilder.RenameTable(
                name: "ReaderCards",
                newName: "Readers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Readers",
                table: "Readers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Readers",
                table: "Readers");

            migrationBuilder.RenameTable(
                name: "Readers",
                newName: "ReaderCards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReaderCards",
                table: "ReaderCards",
                column: "Id");
        }
    }
}
