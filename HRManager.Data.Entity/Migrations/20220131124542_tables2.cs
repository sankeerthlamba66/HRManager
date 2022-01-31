using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManager.Data.Entity.Migrations
{
    public partial class tables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationTexts_Organizations1_OrganizationId",
                table: "ApplicationTexts");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Organizations1_OrganizationId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizations1",
                table: "Organizations1");

            migrationBuilder.RenameTable(
                name: "Organizations1",
                newName: "Organizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationTexts_Organizations_OrganizationId",
                table: "ApplicationTexts",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organizations_OrganizationId",
                table: "Users",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationTexts_Organizations_OrganizationId",
                table: "ApplicationTexts");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Organizations_OrganizationId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations");

            migrationBuilder.RenameTable(
                name: "Organizations",
                newName: "Organizations1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizations1",
                table: "Organizations1",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationTexts_Organizations1_OrganizationId",
                table: "ApplicationTexts",
                column: "OrganizationId",
                principalTable: "Organizations1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organizations1_OrganizationId",
                table: "Users",
                column: "OrganizationId",
                principalTable: "Organizations1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
