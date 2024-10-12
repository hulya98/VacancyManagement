using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Dtos.Vacancy;
using VacancyManagement.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VacancyManagement.Domain.Mappers
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserRequest>().ReverseMap();
            CreateMap<UserViewDto, User>().ReverseMap();
            CreateMap<UserRequest, UserIncludeCVRequest>().ReverseMap();

            CreateMap<UserVacancy, UserVacancyRequest>().ReverseMap();
            CreateMap<UserVacancy, UserVacancyViewDto>().ReverseMap();

            CreateMap<Vacancy, VacancyViewDto>().ReverseMap();
        }
    }
}
