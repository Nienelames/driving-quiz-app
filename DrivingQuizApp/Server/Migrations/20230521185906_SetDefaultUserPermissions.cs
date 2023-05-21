using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingQuizApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class SetDefaultUserPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CanGrantAccessToApp",
                table: "UserPermissions",
                newName: "IsWhitelisted");

            migrationBuilder.RenameColumn(
                name: "CanAccessApp",
                table: "UserPermissions",
                newName: "CanWhitelist");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsWhitelisted",
                table: "UserPermissions",
                newName: "CanGrantAccessToApp");

            migrationBuilder.RenameColumn(
                name: "CanWhitelist",
                table: "UserPermissions",
                newName: "CanAccessApp");
        }
    }
}
