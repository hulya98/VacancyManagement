﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos;
using VacancyManagement.Domain.Dtos.Quiz;
using VacancyManagement.Domain.Dtos.QuizAnswer;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Domain.Dtos.UserQuizAnswer;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Dtos.Vacancy;
using VacancyManagement.Domain.Dtos.VacancyRequirement;
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
			CreateMap<UserVacancy, UserVacancyViewDto>()
				.ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User))
				.ForMember(dest => dest.Vacancy, opt => opt.MapFrom(src => src.Vacancy))
				.ReverseMap();

            CreateMap<UserVacancy, UserQuizResultView>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User))
                .ForMember(dest => dest.Vacancy, opt => opt.MapFrom(src => src.Vacancy))
                .ReverseMap();

            CreateMap<Vacancy, VacancyViewDto>().ReverseMap();
			CreateMap<Vacancy, VacancyRequest>().ReverseMap();

			CreateMap<VacancyRequirement, VacancyRequirementViewDto>().ReverseMap();
			CreateMap<VacancyRequirement, VacancyRequirementRequest>().ReverseMap();

			CreateMap<UserQuizAnswer, UserQuizAnswerViewDto>().ReverseMap();
			CreateMap<UserQuizAnswer, UserQuizAnswerRequest>().ReverseMap();

			CreateMap<Quiz, QuizRequest>().ReverseMap();

			CreateMap<QuizAnswer, QuizAnswerViewDto>().ReverseMap();

			CreateMap<Quiz, QuizViewDto>()
				.ForMember(dest => dest.QuizzAnswers, opt => opt.MapFrom(src => src.QuizAnswers));
		}
	}
}
