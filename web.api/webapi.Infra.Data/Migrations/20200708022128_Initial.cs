using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisteredKeys",
                columns: table => new
                {
                    IdKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KeyValue = table.Column<string>(nullable: true),
                    KeyGroup = table.Column<string>(nullable: true),
                    KeyRelease = table.Column<string>(nullable: true),
                    KeyUsedTimestamp = table.Column<DateTime>(nullable: true),
                    KeyClosedTimestamp = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredKeys", x => x.IdKey);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisteredKeys");
        }
    }
}
