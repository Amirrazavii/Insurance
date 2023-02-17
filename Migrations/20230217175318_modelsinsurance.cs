using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Insurance.Migrations
{
    /// <inheritdoc />
    public partial class modelsinsurance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rolluser",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Roll",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Insurancecalculation",
                table: "HistoryInsurances",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HistoryInsurances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Percent",
                table: "HistoryInsurances",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roll",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Insurancecalculation",
                table: "HistoryInsurances");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "HistoryInsurances");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "HistoryInsurances");

            migrationBuilder.AddColumn<int>(
                name: "Rolluser",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
