using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class removemissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Missions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    MissionAvilability = table.Column<string>(type: "text", nullable: false),
                    MissionDescription = table.Column<string>(type: "text", nullable: false),
                    MissionDocuments = table.Column<string>(type: "text", nullable: false),
                    MissionImages = table.Column<string>(type: "text", nullable: false),
                    MissionOrganisationDetail = table.Column<string>(type: "text", nullable: false),
                    MissionOrganisationName = table.Column<string>(type: "text", nullable: false),
                    MissionSkillId = table.Column<string>(type: "text", nullable: false),
                    MissionThemeId = table.Column<string>(type: "text", nullable: false),
                    MissionTitle = table.Column<string>(type: "text", nullable: false),
                    MissionType = table.Column<string>(type: "text", nullable: false),
                    MissionVideoUrl = table.Column<string>(type: "text", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RegistrationDeadLine = table.Column<DateTime>(type: "date", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalSheets = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.Id);
                });
        }
    }
}
