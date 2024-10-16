using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacancyManagement.Domain.Migrations
{
    /// <inheritdoc />
    public partial class quiz_answer_stored_procedure_create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                        CREATE PROCEDURE QuizAndUserAnswerCompare
                            @VacancyId INT,
                            @UserId INT
                        AS
                        BEGIN
                            DECLARE @CorrectAnswers TABLE(
                              Quiz INT,
                              Question NVARCHAR(300),
                              CorrectAnswer NVARCHAR(300)
                            )
                            
                            DECLARE @UserAnswers TABLE(
                              Quiz INT,
                              Question NVARCHAR(300),
                              UserAnswer NVARCHAR(300)
                            )
                            
                            INSERT INTO @CorrectAnswers
                            select q.Id QuizId,q.Question,
                            qa.Title CorrectAnswer from dbo.QuizAnswers qa
                            INNER JOIN dbo.Quizzes q
                            ON qa.QuizId = q.Id 
                            where IsCorrect = 1 and q.VacancyId = @VacancyId
                            
                            INSERT INTO @UserAnswers
                            select q.Id QuizId,q.Question,
                             qa.Title UserAnswer from
                            dbo.QuizAnswers qa
                            INNER JOIN dbo.UserQuizAnswers uqa
                            ON uqa.UserAnswerId = qa.Id 
                            INNER JOIN dbo.Quizzes q
                            ON q.Id = qa.QuizId
                            where  q.VacancyId = @VacancyId AND uqa.UserId = @UserId
                            
                            select ca.Question,CorrectAnswer,UserAnswer from @CorrectAnswers ca
                            INNER JOIN @UserAnswers ua
                            ON ca.Quiz = ua.Quiz
END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE QuizAndUserAnswerCompare");
        }
    }
}
