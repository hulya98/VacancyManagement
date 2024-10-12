using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VacancyManagement.Domain.Migrations
{
    /// <inheritdoc />
    public partial class config_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CV = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CVName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VacancyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVacancies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VacancyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVacancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserVacancies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserVacancies_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacancyRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VacancyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacancyRequirements_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizAnswers_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, "Admin" },
                    { 2, null, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CV", "CVName", "CreatedDate", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { 1, null, null, null, "qeriblih@gmail.com", "Admin", "Admin", "123", "+994 51 359 86 44" });

            migrationBuilder.InsertData(
                table: "Vacancies",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "BACK-END DEVELOPER" },
                    { 2, true, "İstedadların idarəolunması və inkişaf üzrə mütəxəssis" }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Question", "VacancyId" },
                values: new object[,]
                {
                    { 1, "What is the purpose of using JWT (JSON Web Tokens) in a web application?", 1 },
                    { 2, "Which of the following is a key feature of RESTful APIs?", 1 },
                    { 3, "In a microservices architecture, what is the primary role of a message broker?", 1 },
                    { 4, "What does talent management include?", 2 },
                    { 5, "What are the key factors in creating development plans?", 2 },
                    { 6, "How can a talent management specialist increase employee motivation?", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedDate", "RoleId", "UserId" },
                values: new object[] { 1, null, 1, 1 });

            migrationBuilder.InsertData(
                table: "VacancyRequirements",
                columns: new[] { "Id", "Requirement", "VacancyId" },
                values: new object[,]
                {
                    { 1, "Sərbəst araşdırma bacarığı;", 1 },
                    { 2, "Komanda ilə işləmək bacarığı;", 1 },
                    { 3, "Yaradıcı düşünmə və problemləri həll etmə bacarığı;", 1 },
                    { 4, "C# OOP üzrə biliklər;", 1 },
                    { 5, "NET Core üzrə biliklər;", 1 },
                    { 6, "Şirkətdaxili istedad bazasının təşkili üçün aidiyyatı struktur rəhbərləri ilə birgə işlərin görülməsi;", 2 },
                    { 7, "İstedadların performans göstəricilərinin analiz olunması;", 2 },
                    { 8, "İstedadların davamlı inkişafına dəstək göstərilməsi;", 2 },
                    { 9, "İntranet Platformasının yeni funksionallıqlarla mütəmadi inkişaf etdirilməsi və effektivliyinə nəzarət;", 2 },
                    { 10, "Key role, critical skills holder və high potential anlayışlara dair müvafiq təsvirin və kriteriyaların formalaşdırmaq;", 2 }
                });

            migrationBuilder.InsertData(
                table: "QuizAnswers",
                columns: new[] { "Id", "IsCorrect", "Item", "QuizId", "Title" },
                values: new object[,]
                {
                    { 1, false, "A", 1, "To store session data on the client side" },
                    { 2, true, "B", 1, "To authenticate users and manage user sessions securely" },
                    { 3, false, "C", 1, "To encrypt all user data" },
                    { 4, false, "A", 2, "They always require a message queue" },
                    { 5, true, "B", 2, "They use HTTP methods like GET, POST, PUT, DELETE" },
                    { 6, false, "C", 2, "They require a relational database for data storage" },
                    { 7, true, "A", 3, "To enable communication and data exchange between services asynchronously" },
                    { 8, false, "B", 3, "To handle authentication across all services" },
                    { 9, false, "C", 3, "To ensure that each service runs on a different server" },
                    { 10, false, "A", 4, "Only hiring and firing employees" },
                    { 11, false, "B", 4, "Financial management" },
                    { 12, true, "C", 4, "Selecting, developing, and retaining employees with long-term strategies" },
                    { 13, true, "A", 5, "Employee skills and organizational needs" },
                    { 14, false, "B", 5, "Only the directives from the managers" },
                    { 15, false, "C", 5, "The company's revenue reports" },
                    { 16, true, "A", 6, "By offering only financial rewards" },
                    { 17, false, "B", 6, "By providing career development opportunities and fostering employee growth" },
                    { 18, false, "C", 6, "By forcing them to attend monthly training sessions" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnswers_QuizId",
                table: "QuizAnswers",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_VacancyId",
                table: "Quizzes",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVacancies_UserId",
                table: "UserVacancies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVacancies_VacancyId",
                table: "UserVacancies",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyRequirements_VacancyId",
                table: "VacancyRequirements",
                column: "VacancyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizAnswers");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserVacancies");

            migrationBuilder.DropTable(
                name: "VacancyRequirements");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vacancies");
        }
    }
}
