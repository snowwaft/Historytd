using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Newinfosoft.Historytd.Repository.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_BASIC_EVENT",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    BeginDate = table.Column<int>(nullable: false),
                    EndDate = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Abstract = table.Column<string>(maxLength: 500, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_BASIC_EVENT", x => x.EventId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_BASIC_EVENT_BeginDate",
                table: "T_BASIC_EVENT",
                column: "BeginDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_BASIC_EVENT");
        }
    }
}
