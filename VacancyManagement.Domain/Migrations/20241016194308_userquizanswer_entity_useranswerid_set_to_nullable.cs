using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacancyManagement.Domain.Migrations
{
    /// <inheritdoc />
    public partial class userquizanswer_entity_useranswerid_set_to_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserAnswerId",
                table: "UserQuizAnswers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserAnswerId",
                table: "UserQuizAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
