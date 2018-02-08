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
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<ProfessorViewModel, Professor>();
            CreateMap<ProfessorEnderecoViewModel, Professor>();

            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ProfessorEnderecoViewModel,Endereco>();

           

        }

    }
}
