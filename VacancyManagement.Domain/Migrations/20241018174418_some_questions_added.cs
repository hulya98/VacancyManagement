using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VacancyManagement.Domain.Migrations
{
    /// <inheritdoc />
    public partial class some_questions_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "GET");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "POST");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Title",
                value: "PUT");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 13,
                column: "Title",
                value: "Easier maintenance and independent scaling");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "Lower development costs");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 15,
                column: "Title",
                value: "Increased monolith stability");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Command Query Responsibility Segregation");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "Continuous Query and Response Systems");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 18,
                column: "Title",
                value: "Centralized Queue Redundancy System");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Question", "VacancyId" },
                values: new object[] { "Which HTTP method is typically used to update a resource in a RESTful API?", 1 });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Question", "VacancyId" },
                values: new object[] { "What is the primary benefit of using microservices?", 1 });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Question", "VacancyId" },
                values: new object[] { "What does CQRS stand for in the context of system architecture?", 1 });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Question", "VacancyId" },
                values: new object[,]
                {
                    { 7, "What is the main purpose of OAuth in web applications?", 1 },
                    { 8, "Which design pattern is commonly used to provide an interface for creating objects in a system?", 1 },
                    { 9, "In Domain-Driven Design, what is a bounded context?", 1 },
                    { 10, "Which protocol is commonly used for real-time communication between clients and servers?", 1 },
                    { 11, "What is the difference between vertical and horizontal scaling in cloud computing?", 1 },
                    { 12, "What is the purpose of the Repository pattern in software design?", 1 },
                    { 13, "Which architectural style is specifically designed for decoupling systems?", 1 },
                    { 14, "What does CAP theorem stand for in distributed systems?", 1 },
                    { 15, "Which principle in SOLID design focuses on software entities being open for extension but closed for modification?", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CVName",
                value: "26d0b125-12e5-4f3d-ac2e-5e77b5e95863-Hulya_Garibli_CV.pdf");

            migrationBuilder.InsertData(
                table: "QuizAnswers",
                columns: new[] { "Id", "IsCorrect", "Item", "QuizId", "Title" },
                values: new object[,]
                {
                    { 19, false, "A", 7, "To provide a framework for authentication" },
                    { 20, true, "B", 7, "To enable third-party services to access user data without exposing credentials" },
                    { 21, false, "C", 7, "To manage passwords securely" },
                    { 22, true, "A", 8, "Factory Pattern" },
                    { 23, false, "B", 8, "Observer Pattern" },
                    { 24, false, "C", 8, "Singleton Pattern" },
                    { 25, true, "A", 9, "A logical boundary that defines the scope of a domain" },
                    { 26, false, "B", 9, "An area of shared data between systems" },
                    { 27, false, "C", 9, "A network of microservices" },
                    { 28, false, "A", 10, "HTTP" },
                    { 29, true, "B", 10, "WebSockets" },
                    { 30, false, "C", 10, "SOAP" },
                    { 31, true, "A", 11, "Vertical scaling adds resources to an existing server" },
                    { 32, false, "B", 11, "Horizontal scaling removes unnecessary services" },
                    { 33, false, "C", 11, "Vertical scaling adds new services to the system" },
                    { 34, true, "A", 12, "To abstract data access logic and manage queries" },
                    { 35, false, "B", 12, "To manage all business logic in one place" },
                    { 36, false, "C", 12, "To ensure thread safety in distributed systems" },
                    { 37, true, "A", 13, "Service-Oriented Architecture" },
                    { 38, false, "B", 13, "Monolithic Architecture" },
                    { 39, false, "C", 13, "Client-Server Architecture" },
                    { 40, true, "A", 14, "Consistency, Availability, Partition tolerance" },
                    { 41, false, "B", 14, "Consistency, Adaptability, Performance" },
                    { 42, false, "C", 14, "Concurrency, Availability, Performance" },
                    { 43, true, "A", 15, "Open for extension but closed for modification" },
                    { 44, false, "B", 15, "Open for modification but closed for extension" },
                    { 45, false, "C", 15, "Open for inheritance but closed for overriding" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Only hiring and firing employees");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "Financial management");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Title",
                value: "Selecting, developing, and retaining employees with long-term strategies");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 13,
                column: "Title",
                value: "Employee skills and organizational needs");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "Only the directives from the managers");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 15,
                column: "Title",
                value: "The company's revenue reports");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "By offering only financial rewards");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "By providing career development opportunities and fostering employee growth");

            migrationBuilder.UpdateData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 18,
                column: "Title",
                value: "By forcing them to attend monthly training sessions");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Question", "VacancyId" },
                values: new object[] { "What does talent management include?", 2 });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Question", "VacancyId" },
                values: new object[] { "What are the key factors in creating development plans?", 2 });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Question", "VacancyId" },
                values: new object[] { "How can a talent management specialist increase employee motivation?", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CVName",
                value: null);
        }
    }
}
