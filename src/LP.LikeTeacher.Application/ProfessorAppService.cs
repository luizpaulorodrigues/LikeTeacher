using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.LikeTeacher.Application.Interfaces;
using LP.LikeTeacher.Application.ViewModel;
using LP.LikeTeacher.Infra.Data.Repository;
using  AutoMapper;
using LP.LikeTeacher.Domain.Entities;

namespace LP.LikeTeacher.Application
{
    public class ProfessorAppService : IProfessorAppService
    {
        private readonly ProfessorRepository _professorRepository;

       public ProfessorAppService()
        {
            _professorRepository = new ProfessorRepository();
        }

        public ProfessorEnderecoViewModel Adicionar(ProfessorEnderecoViewModel professorEnderecoViewModel)
        {
            var professor = Mapper.Map<Professor>(professorEnderecoViewModel);
            var endereco = Mapper.Map<Endereco>(professorEnderecoViewModel);

            professor.Enderecos.Add(endereco);
            _professorRepository.Adicionar(professor);


            return professorEnderecoViewModel;
        }
       
        public ProfessorViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<ProfessorViewModel>(_professorRepository.ObterPorId(id));
            
        }

        public IEnumerable<ProfessorViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ProfessorViewModel>>(_professorRepository.ObterTodos());
        }

        public ProfessorViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<ProfessorViewModel>(_professorRepository.PesquisarPorCpf(cpf));
        }

        public ProfessorViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<ProfessorViewModel>(_professorRepository.PesquisarPorEmail(email));
        }

        public ProfessorViewModel Atualizar(ProfessorViewModel professorViewModel)
        {
            var professor = Mapper.Map<Professor>(professorViewModel);
            _professorRepository.Atualizar(professor);
            return professorViewModel;
        }

        public void Remover(Guid id)
        {
            _professorRepository.Remover(id);
        }

        public void Dispose()
        {
            _professorRepository.Dispose();
            GC.SuppressFinalize(this);
        }

       
    }
}
