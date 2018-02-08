using System;
using System.Collections;
using System.Collections.Generic;
using LP.LikeTeacher.Application.ViewModel;

namespace LP.LikeTeacher.Application.Interfaces
{
    public interface IProfessorAppService : IDisposable
    {
        ProfessorEnderecoViewModel Adicionar(ProfessorEnderecoViewModel professorEnderecoViewModel);
        ProfessorViewModel ObterPorId(Guid id);
        IEnumerable<ProfessorViewModel> ObterTodos();
        ProfessorViewModel ObterPorCpf(string cpf);
        ProfessorViewModel ObterPorEmail(string email);
        ProfessorViewModel Atualizar(ProfessorViewModel professorViewModel);
        void Remover(Guid id);
    }
}