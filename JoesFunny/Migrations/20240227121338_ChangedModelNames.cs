using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoesFunny.Migrations
{
    /// <inheritdoc />
    public partial class ChangedModelNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "address",
                table: "PersonalInformation",
                newName: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "PersonalInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "PersonalInformation",
                newName: "address");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "PersonalInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
