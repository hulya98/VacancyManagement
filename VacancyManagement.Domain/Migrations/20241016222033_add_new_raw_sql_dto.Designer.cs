﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VacancyManagement.Domain;

#nullable disable

namespace VacancyManagement.Domain.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241016222033_add_new_raw_sql_dto")]
    partial class add_new_raw_sql_dto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VacancyManagement.Domain.Dtos.RawSqlDtos.QuizAnswerCompare", b =>
                {
                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("QuizAnswerCompares");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VacancyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VacancyId");

                    b.ToTable("Quizzes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Question = "What is the purpose of using JWT (JSON Web Tokens) in a web application?",
                            VacancyId = 1
                        },
                        new
                        {
                            Id = 2,
                            Question = "Which of the following is a key feature of RESTful APIs?",
                            VacancyId = 1
                        },
                        new
                        {
                            Id = 3,
                            Question = "In a microservices architecture, what is the primary role of a message broker?",
                            VacancyId = 1
                        },
                        new
                        {
                            Id = 4,
                            Question = "What does talent management include?",
                            VacancyId = 2
                        },
                        new
                        {
                            Id = 5,
                            Question = "What are the key factors in creating development plans?",
                            VacancyId = 2
                        },
                        new
                        {
                            Id = 6,
                            Question = "How can a talent management specialist increase employee motivation?",
                            VacancyId = 2
                        });
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.QuizAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("QuizAnswers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCorrect = false,
                            Item = "A",
                            QuizId = 1,
                            Title = "To store session data on the client side"
                        },
                        new
                        {
                            Id = 2,
                            IsCorrect = true,
                            Item = "B",
                            QuizId = 1,
                            Title = "To authenticate users and manage user sessions securely"
                        },
                        new
                        {
                            Id = 3,
                            IsCorrect = false,
                            Item = "C",
                            QuizId = 1,
                            Title = "To encrypt all user data"
                        },
                        new
                        {
                            Id = 4,
                            IsCorrect = false,
                            Item = "A",
                            QuizId = 2,
                            Title = "They always require a message queue"
                        },
                        new
                        {
                            Id = 5,
                            IsCorrect = true,
                            Item = "B",
                            QuizId = 2,
                            Title = "They use HTTP methods like GET, POST, PUT, DELETE"
                        },
                        new
                        {
                            Id = 6,
                            IsCorrect = false,
                            Item = "C",
                            QuizId = 2,
                            Title = "They require a relational database for data storage"
                        },
                        new
                        {
                            Id = 7,
                            IsCorrect = true,
                            Item = "A",
                            QuizId = 3,
                            Title = "To enable communication and data exchange between services asynchronously"
                        },
                        new
                        {
                            Id = 8,
                            IsCorrect = false,
                            Item = "B",
                            QuizId = 3,
                            Title = "To handle authentication across all services"
                        },
                        new
                        {
                            Id = 9,
                            IsCorrect = false,
                            Item = "C",
                            QuizId = 3,
                            Title = "To ensure that each service runs on a different server"
                        },
                        new
                        {
                            Id = 10,
                            IsCorrect = false,
                            Item = "A",
                            QuizId = 4,
                            Title = "Only hiring and firing employees"
                        },
                        new
                        {
                            Id = 11,
                            IsCorrect = false,
                            Item = "B",
                            QuizId = 4,
                            Title = "Financial management"
                        },
                        new
                        {
                            Id = 12,
                            IsCorrect = true,
                            Item = "C",
                            QuizId = 4,
                            Title = "Selecting, developing, and retaining employees with long-term strategies"
                        },
                        new
                        {
                            Id = 13,
                            IsCorrect = true,
                            Item = "A",
                            QuizId = 5,
                            Title = "Employee skills and organizational needs"
                        },
                        new
                        {
                            Id = 14,
                            IsCorrect = false,
                            Item = "B",
                            QuizId = 5,
                            Title = "Only the directives from the managers"
                        },
                        new
                        {
                            Id = 15,
                            IsCorrect = false,
                            Item = "C",
                            QuizId = 5,
                            Title = "The company's revenue reports"
                        },
                        new
                        {
                            Id = 16,
                            IsCorrect = true,
                            Item = "A",
                            QuizId = 6,
                            Title = "By offering only financial rewards"
                        },
                        new
                        {
                            Id = 17,
                            IsCorrect = false,
                            Item = "B",
                            QuizId = 6,
                            Title = "By providing career development opportunities and fostering employee growth"
                        },
                        new
                        {
                            Id = 18,
                            IsCorrect = false,
                            Item = "C",
                            QuizId = 6,
                            Title = "By forcing them to attend monthly training sessions"
                        });
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Guest"
                        });
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CVName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "qeriblih@gmail.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            Password = "123",
                            PhoneNumber = "+994 51 359 86 44"
                        });
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.UserQuizAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("UserAnswerId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VacancyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserQuizAnswers");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.UserVacancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VacancyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VacancyId");

                    b.ToTable("UserVacancies");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.Vacancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vacancies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "BACK-END DEVELOPER"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Name = "İstedadların idarəolunması və inkişaf üzrə mütəxəssis"
                        });
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.VacancyRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Requirement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VacancyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VacancyId");

                    b.ToTable("VacancyRequirements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Requirement = "Sərbəst araşdırma bacarığı;",
                            VacancyId = 1
                        },
                        new
                        {
                            Id = 2,
                            Requirement = "Komanda ilə işləmək bacarığı;",
                            VacancyId = 1
                        },
                        new
                        {
                            Id = 3,
                            Requirement = "Yaradıcı düşünmə və problemləri həll etmə bacarığı;",
                            VacancyId = 1
                        },
                        new
                        {
                            Id = 4,
                            Requirement = "C# OOP üzrə biliklər;",
                            VacancyId = 1
                        },
                        new
                        {
                            Id = 5,
                            Requirement = "NET Core üzrə biliklər;",
                            VacancyId = 1
                        },
                        new
                        {
                            Id = 6,
                            Requirement = "Şirkətdaxili istedad bazasının təşkili üçün aidiyyatı struktur rəhbərləri ilə birgə işlərin görülməsi;",
                            VacancyId = 2
                        },
                        new
                        {
                            Id = 7,
                            Requirement = "İstedadların performans göstəricilərinin analiz olunması;",
                            VacancyId = 2
                        },
                        new
                        {
                            Id = 8,
                            Requirement = "İstedadların davamlı inkişafına dəstək göstərilməsi;",
                            VacancyId = 2
                        },
                        new
                        {
                            Id = 9,
                            Requirement = "İntranet Platformasının yeni funksionallıqlarla mütəmadi inkişaf etdirilməsi və effektivliyinə nəzarət;",
                            VacancyId = 2
                        },
                        new
                        {
                            Id = 10,
                            Requirement = "Key role, critical skills holder və high potential anlayışlara dair müvafiq təsvirin və kriteriyaların formalaşdırmaq;",
                            VacancyId = 2
                        });
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.Quiz", b =>
                {
                    b.HasOne("VacancyManagement.Domain.Entities.Vacancy", "Vacancy")
                        .WithMany("Quizzes")
                        .HasForeignKey("VacancyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vacancy");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.QuizAnswer", b =>
                {
                    b.HasOne("VacancyManagement.Domain.Entities.Quiz", "Quiz")
                        .WithMany("QuizAnswers")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("VacancyManagement.Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacancyManagement.Domain.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.UserVacancy", b =>
                {
                    b.HasOne("VacancyManagement.Domain.Entities.User", "User")
                        .WithMany("UserVacancies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacancyManagement.Domain.Entities.Vacancy", "Vacancy")
                        .WithMany("UserVacancies")
                        .HasForeignKey("VacancyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Vacancy");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.VacancyRequirement", b =>
                {
                    b.HasOne("VacancyManagement.Domain.Entities.Vacancy", "Vacancy")
                        .WithMany("VacancyRequirements")
                        .HasForeignKey("VacancyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vacancy");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.Quiz", b =>
                {
                    b.Navigation("QuizAnswers");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.User", b =>
                {
                    b.Navigation("UserRoles");

                    b.Navigation("UserVacancies");
                });

            modelBuilder.Entity("VacancyManagement.Domain.Entities.Vacancy", b =>
                {
                    b.Navigation("Quizzes");

                    b.Navigation("UserVacancies");

                    b.Navigation("VacancyRequirements");
                });
#pragma warning restore 612, 618
        }
    }
}
