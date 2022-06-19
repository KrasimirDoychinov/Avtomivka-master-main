using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avtomivka.A.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colon_AspNetUsers_UserId",
                schema: "17118057",
                table: "Colon");

            migrationBuilder.DropForeignKey(
                name: "FK_WashReservation_AspNetUsers_UserId",
                schema: "17118057",
                table: "WashReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_WashReservation_Colon_ColonId",
                schema: "17118057",
                table: "WashReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_WashReservation_Program_ProgramId",
                schema: "17118057",
                table: "WashReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_WashReservation_Worker_WorkerId",
                schema: "17118057",
                table: "WashReservation");

            migrationBuilder.DropTable(
                name: "log_17118057",
                schema: "17118057");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Worker",
                schema: "17118057",
                table: "Worker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WashReservation",
                schema: "17118057",
                table: "WashReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Program",
                schema: "17118057",
                table: "Program");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colon",
                schema: "17118057",
                table: "Colon");

            migrationBuilder.RenameTable(
                name: "Worker",
                schema: "17118057",
                newName: "Workers");

            migrationBuilder.RenameTable(
                name: "WashReservation",
                schema: "17118057",
                newName: "WashReservations");

            migrationBuilder.RenameTable(
                name: "Program",
                schema: "17118057",
                newName: "Programs");

            migrationBuilder.RenameTable(
                name: "Colon",
                schema: "17118057",
                newName: "Colons");

            migrationBuilder.RenameColumn(
                name: "Modified_17118057",
                table: "Workers",
                newName: "Modified");

            migrationBuilder.RenameColumn(
                name: "Modified_17118057",
                table: "WashReservations",
                newName: "Modified");

            migrationBuilder.RenameIndex(
                name: "IX_WashReservation_WorkerId",
                table: "WashReservations",
                newName: "IX_WashReservations_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WashReservation_UserId",
                table: "WashReservations",
                newName: "IX_WashReservations_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_WashReservation_ProgramId",
                table: "WashReservations",
                newName: "IX_WashReservations_ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_WashReservation_ColonId",
                table: "WashReservations",
                newName: "IX_WashReservations_ColonId");

            migrationBuilder.RenameColumn(
                name: "Modified_17118057",
                table: "Programs",
                newName: "Modified");

            migrationBuilder.RenameColumn(
                name: "Modified_17118057",
                table: "Colons",
                newName: "Modified");

            migrationBuilder.RenameIndex(
                name: "IX_Colon_UserId",
                table: "Colons",
                newName: "IX_Colons_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WashReservations",
                table: "WashReservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programs",
                table: "Programs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colons",
                table: "Colons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colons_AspNetUsers_UserId",
                table: "Colons",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WashReservations_AspNetUsers_UserId",
                table: "WashReservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WashReservations_Colons_ColonId",
                table: "WashReservations",
                column: "ColonId",
                principalTable: "Colons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WashReservations_Programs_ProgramId",
                table: "WashReservations",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WashReservations_Workers_WorkerId",
                table: "WashReservations",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colons_AspNetUsers_UserId",
                table: "Colons");

            migrationBuilder.DropForeignKey(
                name: "FK_WashReservations_AspNetUsers_UserId",
                table: "WashReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_WashReservations_Colons_ColonId",
                table: "WashReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_WashReservations_Programs_ProgramId",
                table: "WashReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_WashReservations_Workers_WorkerId",
                table: "WashReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WashReservations",
                table: "WashReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Programs",
                table: "Programs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colons",
                table: "Colons");

            migrationBuilder.EnsureSchema(
                name: "17118057");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "Worker",
                newSchema: "17118057");

            migrationBuilder.RenameTable(
                name: "WashReservations",
                newName: "WashReservation",
                newSchema: "17118057");

            migrationBuilder.RenameTable(
                name: "Programs",
                newName: "Program",
                newSchema: "17118057");

            migrationBuilder.RenameTable(
                name: "Colons",
                newName: "Colon",
                newSchema: "17118057");

            migrationBuilder.RenameColumn(
                name: "Modified",
                schema: "17118057",
                table: "Worker",
                newName: "Modified_17118057");

            migrationBuilder.RenameColumn(
                name: "Modified",
                schema: "17118057",
                table: "WashReservation",
                newName: "Modified_17118057");

            migrationBuilder.RenameIndex(
                name: "IX_WashReservations_WorkerId",
                schema: "17118057",
                table: "WashReservation",
                newName: "IX_WashReservation_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WashReservations_UserId",
                schema: "17118057",
                table: "WashReservation",
                newName: "IX_WashReservation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_WashReservations_ProgramId",
                schema: "17118057",
                table: "WashReservation",
                newName: "IX_WashReservation_ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_WashReservations_ColonId",
                schema: "17118057",
                table: "WashReservation",
                newName: "IX_WashReservation_ColonId");

            migrationBuilder.RenameColumn(
                name: "Modified",
                schema: "17118057",
                table: "Program",
                newName: "Modified_17118057");

            migrationBuilder.RenameColumn(
                name: "Modified",
                schema: "17118057",
                table: "Colon",
                newName: "Modified_17118057");

            migrationBuilder.RenameIndex(
                name: "IX_Colons_UserId",
                schema: "17118057",
                table: "Colon",
                newName: "IX_Colon_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker",
                schema: "17118057",
                table: "Worker",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WashReservation",
                schema: "17118057",
                table: "WashReservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Program",
                schema: "17118057",
                table: "Program",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colon",
                schema: "17118057",
                table: "Colon",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "log_17118057",
                schema: "17118057",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false),
                    Modified_17118057 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Operation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Table = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_log_17118057", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Colon_AspNetUsers_UserId",
                schema: "17118057",
                table: "Colon",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WashReservation_AspNetUsers_UserId",
                schema: "17118057",
                table: "WashReservation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WashReservation_Colon_ColonId",
                schema: "17118057",
                table: "WashReservation",
                column: "ColonId",
                principalSchema: "17118057",
                principalTable: "Colon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WashReservation_Program_ProgramId",
                schema: "17118057",
                table: "WashReservation",
                column: "ProgramId",
                principalSchema: "17118057",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WashReservation_Worker_WorkerId",
                schema: "17118057",
                table: "WashReservation",
                column: "WorkerId",
                principalSchema: "17118057",
                principalTable: "Worker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
