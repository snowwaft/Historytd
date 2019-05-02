using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Newinfosoft.Historytd.Repository.Migrations
{
    public partial class AddPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_T_BASIC_EVENT_BeginDate",
                table: "T_BASIC_EVENT",
                newName: "IDX_BASIC_EVENT_DATE");

            migrationBuilder.CreateTable(
                name: "T_BASIC_PERSON",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FamilyName = table.Column<string>(maxLength: 16, nullable: false),
                    FirstName = table.Column<string>(maxLength: 16, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 16, nullable: false),
                    Birthday = table.Column<int>(nullable: true),
                    Deathday = table.Column<int>(nullable: true),
                    HeadImage = table.Column<string>(maxLength: 200, nullable: true),
                    Abstract = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_BASIC_PERSON", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_BASIC_PERSON_NAME",
                table: "T_BASIC_PERSON",
                column: "FamilyName");

            migrationBuilder.CreateIndex(
                name: "IDX_BASIC_PERSON_DATE",
                table: "T_BASIC_PERSON",
                columns: new[] { "Birthday", "Deathday" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_BASIC_PERSON");

            migrationBuilder.RenameIndex(
                name: "IDX_BASIC_EVENT_DATE",
                table: "T_BASIC_EVENT",
                newName: "IX_T_BASIC_EVENT_BeginDate");
        }
    }
}
