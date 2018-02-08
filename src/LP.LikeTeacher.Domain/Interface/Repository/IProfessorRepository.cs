using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using LP.LikeTeacher.Domain;
using LP.LikeTeacher.Domain.Entities;
using LP.LikeTeacher.Domain.Interface.Repository;

namespace LP.LikeTeacher.Domain.Interface.Repository
{
    public interface IProfessorRepository : IRepository<Professor>
    {
        Professor PesquisarPorCpf(string cpf);
        Professor PesquisarPorEmail(string email);
        IEnumerable<Professor> PesquisarAtivos();

    }
}