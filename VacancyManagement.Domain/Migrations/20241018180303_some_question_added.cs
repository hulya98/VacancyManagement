using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VacancyManagement.Domain.Migrations
{
    /// <inheritdoc />
    public partial class some_question_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Question", "VacancyId" },
                values: new object[,]
                {
                    { 16, "What are the key components of a successful talent management strategy?", 2 },
                    { 17, "How do you identify high-potential employees within an  organization?", 2 },
                    { 18, "What methods do you use for conducting employee performance         evaluations?", 2 },
                    { 19, "Describe the importance of employee engagement in talent    management.", 2 },
                    { 20, "How can organizations effectively develop leadership skills among       employees?", 2 },
                    { 21, "What role does feedback play in employee development?", 2 },
                    { 22, "Explain how succession planning benefits an organization.", 2 },
                    { 23, "What strategies can be implemented to retain top talent?", 2 },
                    { 24, "How do you approach designing training programs for employees?", 2 },
                    { 25, "Discuss the significance of diversity and inclusion in talent       management.", 2 },
                    { 26, "What tools or software do you find effective for tracking employee      development?", 2 },
                    { 27, "How do you assess the effectiveness of training and development initiatives?", 2 },
                    { 28, "What are some common challenges faced in talent management?", 2 },
                    { 29, "How can mentoring and coaching contribute to employee development?", 2 },
                    { 30, "What is the role of data analytics in improving talent management practices?", 2 }
                });

            migrationBuilder.InsertData(
                table: "QuizAnswers",
                columns: new[] { "Id", "IsCorrect", "Item", "QuizId", "Title" },
                values: new object[,]
                {
                    { 46, false, "A", 16, "To develop job descriptions" },
                    { 47, false, "B", 16, "To manage employee records" },
                    { 48, true, "C", 16, "To align talent strategies with business goals" },
                    { 49, false, "D", 16, "To recruit new employees" },
                    { 50, false, "A", 17, "Through performance reviews" },
                    { 51, false, "B", 17, "By analyzing training participation" },
                    { 52, true, "C", 17, "Using assessment centers" },
                    { 53, false, "D", 17, "By conducting exit interviews" },
                    { 54, false, "A", 18, "To set salary levels" },
                    { 55, true, "B", 18, "To provide developmental feedback" },
                    { 56, false, "C", 18, "To determine promotions" },
                    { 57, false, "D", 18, "To conduct recruitment" },
                    { 58, false, "A", 19, "It reduces turnover" },
                    { 59, false, "B", 19, "It enhances company reputation" },
                    { 60, true, "C", 19, "It improves productivity" },
                    { 61, false, "D", 19, "It ensures compliance" },
                    { 62, false, "A", 20, "By promoting company culture" },
                    { 63, true, "B", 20, "Through mentoring programs" },
                    { 64, false, "C", 20, "By providing online courses" },
                    { 65, false, "D", 20, "By hosting workshops" },
                    { 66, false, "A", 21, "It is not important" },
                    { 67, true, "B", 21, "It helps identify strengths and weaknesses" },
                    { 68, false, "C", 21, "It is a one-time process" },
                    { 69, false, "D", 21, "It should be avoided" },
                    { 70, false, "A", 22, "It reduces operational costs" },
                    { 71, true, "B", 22, "It ensures knowledge transfer" },
                    { 72, false, "C", 22, "It improves company culture" },
                    { 73, false, "D", 22, "It is not beneficial" },
                    { 74, false, "A", 23, "By offering competitive salaries" },
                    { 75, true, "B", 23, "Through career development opportunities" },
                    { 76, false, "C", 23, "By enhancing benefits packages" },
                    { 77, false, "D", 23, "By increasing workload" },
                    { 78, false, "A", 24, "By focusing only on technical skills" },
                    { 79, true, "B", 24, "Through needs assessments" },
                    { 80, false, "C", 24, "By implementing mandatory training" },
                    { 81, false, "D", 24, "By ignoring employee feedback" },
                    { 82, false, "A", 25, "It fosters creativity" },
                    { 83, true, "B", 25, "It promotes innovation" },
                    { 84, false, "C", 25, "It is not significant" },
                    { 85, false, "D", 25, "It creates conflict" },
                    { 86, false, "A", 26, "For tracking employee attendance" },
                    { 87, true, "B", 26, "For evaluating performance metrics" },
                    { 88, false, "C", 26, "For managing payroll" },
                    { 89, false, "D", 26, "For conducting interviews" },
                    { 90, true, "A", 27, "By collecting feedback from participants" },
                    { 91, false, "B", 27, "By ignoring outcomes" },
                    { 92, false, "C", 27, "By comparing training costs only" },
                    { 93, false, "D", 27, "By evaluating employee engagement" },
                    { 94, false, "A", 28, "Lack of resources" },
                    { 95, false, "B", 28, "Resistance to change" },
                    { 96, true, "C", 28, "Ineffective communication" },
                    { 97, false, "D", 28, "Inadequate training" },
                    { 98, false, "A", 29, "It increases employee satisfaction" },
                    { 99, false, "B", 29, "It reduces training costs" },
                    { 100, true, "C", 29, "It provides personalized support" },
                    { 101, false, "D", 29, "It promotes competition among employees" },
                    { 102, false, "A", 30, "For compliance reasons" },
                    { 103, false, "B", 30, "To optimize recruitment processes" },
                    { 104, true, "C", 30, "To enhance talent management practices" },
                    { 105, false, "D", 30, "It is not useful" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "QuizAnswers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
