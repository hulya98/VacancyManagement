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
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {

            builder.HasData(
            new Quiz { Id = 1, Question = "What is the purpose of using JWT (JSON Web Tokens) in a web application?", VacancyId = 1 },
            new Quiz { Id = 2, Question = "Which of the following is a key feature of RESTful APIs?", VacancyId = 1 },
            new Quiz { Id = 3, Question = "In a microservices architecture, what is the primary role of a message broker?", VacancyId = 1 },
            new Quiz { Id = 4, Question = "Which HTTP method is typically used to update a resource in a RESTful API?", VacancyId = 1 },
            new Quiz { Id = 5, Question = "What is the primary benefit of using microservices?", VacancyId = 1 },
            new Quiz { Id = 6, Question = "What does CQRS stand for in the context of system architecture?", VacancyId = 1 },
            new Quiz { Id = 7, Question = "What is the main purpose of OAuth in web applications?", VacancyId = 1 },
            new Quiz { Id = 8, Question = "Which design pattern is commonly used to provide an interface for creating objects in a system?", VacancyId = 1 },
            new Quiz { Id = 9, Question = "In Domain-Driven Design, what is a bounded context?", VacancyId = 1 },
            new Quiz { Id = 10, Question = "Which protocol is commonly used for real-time communication between clients and servers?", VacancyId = 1 },
            new Quiz { Id = 11, Question = "What is the difference between vertical and horizontal scaling in cloud computing?", VacancyId = 1 },
            new Quiz { Id = 12, Question = "What is the purpose of the Repository pattern in software design?", VacancyId = 1 },
            new Quiz { Id = 13, Question = "Which architectural style is specifically designed for decoupling systems?", VacancyId = 1 },
            new Quiz { Id = 14, Question = "What does CAP theorem stand for in distributed systems?", VacancyId = 1 },
            new Quiz { Id = 15, Question = "Which principle in SOLID design focuses on software entities being open for extension but closed for modification?", VacancyId = 1 },




            new Quiz { Id = 16, Question = "What are the key components of a successful talent management strategy?", VacancyId = 2 },
            new Quiz { Id = 17, Question = "How do you identify high-potential employees within an  organization?", VacancyId = 2 },
            new Quiz { Id = 18, Question = "What methods do you use for conducting employee performance         evaluations?", VacancyId = 2 },
            new Quiz { Id = 19, Question = "Describe the importance of employee engagement in talent    management.", VacancyId = 2 },
            new Quiz { Id = 20, Question = "How can organizations effectively develop leadership skills among       employees?", VacancyId = 2 },
            new Quiz { Id = 21, Question = "What role does feedback play in employee development?", VacancyId = 2 },
            new Quiz { Id = 22, Question = "Explain how succession planning benefits an organization.", VacancyId = 2 },
            new Quiz { Id = 23, Question = "What strategies can be implemented to retain top talent?", VacancyId = 2 },
            new Quiz { Id = 24, Question = "How do you approach designing training programs for employees?", VacancyId = 2 },
            new Quiz { Id = 25, Question = "Discuss the significance of diversity and inclusion in talent       management.", VacancyId = 2 },
            new Quiz { Id = 26, Question = "What tools or software do you find effective for tracking employee      development?", VacancyId = 2 },
            new Quiz { Id = 27, Question = "How do you assess the effectiveness of training and development initiatives?", VacancyId = 2 },
            new Quiz { Id = 28, Question = "What are some common challenges faced in talent management?", VacancyId = 2 },
            new Quiz { Id = 29, Question = "How can mentoring and coaching contribute to employee development?", VacancyId = 2 },
            new Quiz { Id = 30, Question = "What is the role of data analytics in improving talent management practices?", VacancyId = 2 }
);


        }
    }
}
