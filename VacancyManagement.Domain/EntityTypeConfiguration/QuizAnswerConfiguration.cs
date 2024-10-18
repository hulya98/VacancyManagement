using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.EntityTypeConfiguration
{
    public class QuizAnswerConfiguration : IEntityTypeConfiguration<QuizAnswer>
    {
        public void Configure(EntityTypeBuilder<QuizAnswer> builder)
        {

            builder.HasData(
            new QuizAnswer { Id = 1, QuizId = 1, Item = "A", Title = "To store session data on the client side" },
            new QuizAnswer { Id = 2, QuizId = 1, Item = "B", Title = "To authenticate users and manage user sessions securely", IsCorrect = true },
            new QuizAnswer { Id = 3, QuizId = 1, Item = "C", Title = "To encrypt all user data" },

            new QuizAnswer { Id = 4, QuizId = 2, Item = "A", Title = "They always require a message queue" },
            new QuizAnswer { Id = 5, QuizId = 2, Item = "B", Title = "They use HTTP methods like GET, POST, PUT, DELETE", IsCorrect = true },
            new QuizAnswer { Id = 6, QuizId = 2, Item = "C", Title = "They require a relational database for data storage" },

            new QuizAnswer { Id = 7, QuizId = 3, Item = "A", Title = "To enable communication and data exchange between services asynchronously", IsCorrect =   true },
            new QuizAnswer { Id = 8, QuizId = 3, Item = "B", Title = "To handle authentication across all services" },
            new QuizAnswer { Id = 9, QuizId = 3, Item = "C", Title = "To ensure that each service runs on a different server" },

            new QuizAnswer { Id = 10, QuizId = 4, Item = "A", Title = "GET" },
            new QuizAnswer { Id = 11, QuizId = 4, Item = "B", Title = "POST" },
            new QuizAnswer { Id = 12, QuizId = 4, Item = "C", Title = "PUT", IsCorrect = true },

            new QuizAnswer { Id = 13, QuizId = 5, Item = "A", Title = "Easier maintenance and independent scaling", IsCorrect = true },
            new QuizAnswer { Id = 14, QuizId = 5, Item = "B", Title = "Lower development costs" },
            new QuizAnswer { Id = 15, QuizId = 5, Item = "C", Title = "Increased monolith stability" },

            new QuizAnswer { Id = 16, QuizId = 6, Item = "A", Title = "Command Query Responsibility Segregation", IsCorrect = true },
            new QuizAnswer { Id = 17, QuizId = 6, Item = "B", Title = "Continuous Query and Response Systems" },
            new QuizAnswer { Id = 18, QuizId = 6, Item = "C", Title = "Centralized Queue Redundancy System" },

            new QuizAnswer { Id = 19, QuizId = 7, Item = "A", Title = "To provide a framework for authentication" },
            new QuizAnswer { Id = 20, QuizId = 7, Item = "B", Title = "To enable third-party services to access user data without exposing credentials", IsCorrect   =    true },
            new QuizAnswer { Id = 21, QuizId = 7, Item = "C", Title = "To manage passwords securely" },

            new QuizAnswer { Id = 22, QuizId = 8, Item = "A", Title = "Factory Pattern", IsCorrect = true },
            new QuizAnswer { Id = 23, QuizId = 8, Item = "B", Title = "Observer Pattern" },
            new QuizAnswer { Id = 24, QuizId = 8, Item = "C", Title = "Singleton Pattern" },

            new QuizAnswer { Id = 25, QuizId = 9, Item = "A", Title = "A logical boundary that defines the scope of a domain", IsCorrect = true },
            new QuizAnswer { Id = 26, QuizId = 9, Item = "B", Title = "An area of shared data between systems" },
            new QuizAnswer { Id = 27, QuizId = 9, Item = "C", Title = "A network of microservices" },

            new QuizAnswer { Id = 28, QuizId = 10, Item = "A", Title = "HTTP" },
            new QuizAnswer { Id = 29, QuizId = 10, Item = "B", Title = "WebSockets", IsCorrect = true },
            new QuizAnswer { Id = 30, QuizId = 10, Item = "C", Title = "SOAP" },

            new QuizAnswer { Id = 31, QuizId = 11, Item = "A", Title = "Vertical scaling adds resources to an existing server", IsCorrect = true },
            new QuizAnswer { Id = 32, QuizId = 11, Item = "B", Title = "Horizontal scaling removes unnecessary services" },
            new QuizAnswer { Id = 33, QuizId = 11, Item = "C", Title = "Vertical scaling adds new services to the system" },

            new QuizAnswer { Id = 34, QuizId = 12, Item = "A", Title = "To abstract data access logic and manage queries", IsCorrect = true },
            new QuizAnswer { Id = 35, QuizId = 12, Item = "B", Title = "To manage all business logic in one place" },
            new QuizAnswer { Id = 36, QuizId = 12, Item = "C", Title = "To ensure thread safety in distributed systems" },

            new QuizAnswer { Id = 37, QuizId = 13, Item = "A", Title = "Service-Oriented Architecture", IsCorrect = true },
            new QuizAnswer { Id = 38, QuizId = 13, Item = "B", Title = "Monolithic Architecture" },
            new QuizAnswer { Id = 39, QuizId = 13, Item = "C", Title = "Client-Server Architecture" },

            new QuizAnswer { Id = 40, QuizId = 14, Item = "A", Title = "Consistency, Availability, Partition tolerance", IsCorrect = true },
            new QuizAnswer { Id = 41, QuizId = 14, Item = "B", Title = "Consistency, Adaptability, Performance" },
            new QuizAnswer { Id = 42, QuizId = 14, Item = "C", Title = "Concurrency, Availability, Performance" },

            new QuizAnswer { Id = 43, QuizId = 15, Item = "A", Title = "Open for extension but closed for modification", IsCorrect = true },
            new QuizAnswer { Id = 44, QuizId = 15, Item = "B", Title = "Open for modification but closed for extension" },
            new QuizAnswer { Id = 45, QuizId = 15, Item = "C", Title = "Open for inheritance but closed for overriding" },




            new QuizAnswer { Id = 46, QuizId = 16, Item = "A", Title = "To develop job descriptions" },
            new QuizAnswer { Id = 47, QuizId = 16, Item = "B", Title = "To manage employee records" },
            new QuizAnswer { Id = 48, QuizId = 16, Item = "C", Title = "To align talent strategies with business goals", IsCorrect = true },
            new QuizAnswer { Id = 49, QuizId = 16, Item = "D", Title = "To recruit new employees" },

            new QuizAnswer { Id = 50, QuizId = 17, Item = "A", Title = "Through performance reviews" },
            new QuizAnswer { Id = 51, QuizId = 17, Item = "B", Title = "By analyzing training participation" },
            new QuizAnswer { Id = 52, QuizId = 17, Item = "C", Title = "Using assessment centers", IsCorrect = true },
            new QuizAnswer { Id = 53, QuizId = 17, Item = "D", Title = "By conducting exit interviews" },

            new QuizAnswer { Id = 54, QuizId = 18, Item = "A", Title = "To set salary levels" },
            new QuizAnswer { Id = 55, QuizId = 18, Item = "B", Title = "To provide developmental feedback", IsCorrect = true },
            new QuizAnswer { Id = 56, QuizId = 18, Item = "C", Title = "To determine promotions" },
            new QuizAnswer { Id = 57, QuizId = 18, Item = "D", Title = "To conduct recruitment" },

            new QuizAnswer { Id = 58, QuizId = 19, Item = "A", Title = "It reduces turnover" },
            new QuizAnswer { Id = 59, QuizId = 19, Item = "B", Title = "It enhances company reputation" },
            new QuizAnswer { Id = 60, QuizId = 19, Item = "C", Title = "It improves productivity", IsCorrect = true },
            new QuizAnswer { Id = 61, QuizId = 19, Item = "D", Title = "It ensures compliance" },

            new QuizAnswer { Id = 62, QuizId = 20, Item = "A", Title = "By promoting company culture" },
            new QuizAnswer { Id = 63, QuizId = 20, Item = "B", Title = "Through mentoring programs", IsCorrect = true },
            new QuizAnswer { Id = 64, QuizId = 20, Item = "C", Title = "By providing online courses" },
            new QuizAnswer { Id = 65, QuizId = 20, Item = "D", Title = "By hosting workshops" },

            new QuizAnswer { Id = 66, QuizId = 21, Item = "A", Title = "It is not important" },
            new QuizAnswer { Id = 67, QuizId = 21, Item = "B", Title = "It helps identify strengths and weaknesses", IsCorrect = true },
            new QuizAnswer { Id = 68, QuizId = 21, Item = "C", Title = "It is a one-time process" },
            new QuizAnswer { Id = 69, QuizId = 21, Item = "D", Title = "It should be avoided" },

            new QuizAnswer { Id = 70, QuizId = 22, Item = "A", Title = "It reduces operational costs" },
            new QuizAnswer { Id = 71, QuizId = 22, Item = "B", Title = "It ensures knowledge transfer", IsCorrect = true },
            new QuizAnswer { Id = 72, QuizId = 22, Item = "C", Title = "It improves company culture" },
            new QuizAnswer { Id = 73, QuizId = 22, Item = "D", Title = "It is not beneficial" },

            new QuizAnswer { Id = 74, QuizId = 23, Item = "A", Title = "By offering competitive salaries" },
            new QuizAnswer { Id = 75, QuizId = 23, Item = "B", Title = "Through career development opportunities", IsCorrect = true },
            new QuizAnswer { Id = 76, QuizId = 23, Item = "C", Title = "By enhancing benefits packages" },
            new QuizAnswer { Id = 77, QuizId = 23, Item = "D", Title = "By increasing workload" },

            new QuizAnswer { Id = 78, QuizId = 24, Item = "A", Title = "By focusing only on technical skills" },
            new QuizAnswer { Id = 79, QuizId = 24, Item = "B", Title = "Through needs assessments", IsCorrect = true },
            new QuizAnswer { Id = 80, QuizId = 24, Item = "C", Title = "By implementing mandatory training" },
            new QuizAnswer { Id = 81, QuizId = 24, Item = "D", Title = "By ignoring employee feedback" },

            new QuizAnswer { Id = 82, QuizId = 25, Item = "A", Title = "It fosters creativity" },
            new QuizAnswer { Id = 83, QuizId = 25, Item = "B", Title = "It promotes innovation", IsCorrect = true },
            new QuizAnswer { Id = 84, QuizId = 25, Item = "C", Title = "It is not significant" },
            new QuizAnswer { Id = 85, QuizId = 25, Item = "D", Title = "It creates conflict" },

            new QuizAnswer { Id = 86, QuizId = 26, Item = "A", Title = "For tracking employee attendance" },
            new QuizAnswer { Id = 87, QuizId = 26, Item = "B", Title = "For evaluating performance metrics", IsCorrect = true },
            new QuizAnswer { Id = 88, QuizId = 26, Item = "C", Title = "For managing payroll" },
            new QuizAnswer { Id = 89, QuizId = 26, Item = "D", Title = "For conducting interviews" },

            new QuizAnswer { Id = 90, QuizId = 27, Item = "A", Title = "By collecting feedback from participants", IsCorrect = true },
            new QuizAnswer { Id = 91, QuizId = 27, Item = "B", Title = "By ignoring outcomes" },
            new QuizAnswer { Id = 92, QuizId = 27, Item = "C", Title = "By comparing training costs only" },
            new QuizAnswer { Id = 93, QuizId = 27, Item = "D", Title = "By evaluating employee engagement" },

            new QuizAnswer { Id = 94, QuizId = 28, Item = "A", Title = "Lack of resources" },
            new QuizAnswer { Id = 95, QuizId = 28, Item = "B", Title = "Resistance to change" },
            new QuizAnswer { Id = 96, QuizId = 28, Item = "C", Title = "Ineffective communication", IsCorrect = true },
            new QuizAnswer { Id = 97, QuizId = 28, Item = "D", Title = "Inadequate training" },

            new QuizAnswer { Id = 98, QuizId = 29, Item = "A", Title = "It increases employee satisfaction" },
            new QuizAnswer { Id = 99, QuizId = 29, Item = "B", Title = "It reduces training costs" },
            new QuizAnswer { Id = 100, QuizId = 29, Item = "C", Title = "It provides personalized support", IsCorrect = true },
            new QuizAnswer { Id = 101, QuizId = 29, Item = "D", Title = "It promotes competition among employees" },

            new QuizAnswer { Id = 102, QuizId = 30, Item = "A", Title = "For compliance reasons" },
            new QuizAnswer { Id = 103, QuizId = 30, Item = "B", Title = "To optimize recruitment processes" },
            new QuizAnswer { Id = 104, QuizId = 30, Item = "C", Title = "To enhance talent management practices", IsCorrect = true },
            new QuizAnswer { Id = 105, QuizId = 30, Item = "D", Title = "It is not useful" }
);

        }

    }
}
