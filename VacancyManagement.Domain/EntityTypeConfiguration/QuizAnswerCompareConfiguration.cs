using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.RawSqlDtos;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.EntityTypeConfiguration
{
    public class QuizAnswerCompareConfiguration : IEntityTypeConfiguration<QuizAnswerCompare>
    {
        public void Configure(EntityTypeBuilder<QuizAnswerCompare> builder)
        {
            builder.HasNoKey();
        }
    }
}
