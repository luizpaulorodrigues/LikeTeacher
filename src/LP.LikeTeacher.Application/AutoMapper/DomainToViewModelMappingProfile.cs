using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.LikeTeacher.Application.ViewModel;
using LP.LikeTeacher.Domain.Entities;
using AutoMapper;

namespace LP.LikeTeacher.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<Professor, ProfessorViewModel>();
            CreateMap<Professor, ProfessorEnderecoViewModel>();
           
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Endereco, ProfessorEnderecoViewModel>();

           

        }

    }
}
