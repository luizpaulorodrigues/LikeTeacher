using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LP.LikeTeacher.Domain.Interface.Repository;
using LP.LikeTeacher.Domain.Entities;
using LP.LikeTeacher.Infra.Data.Context;

namespace LP.LikeTeacher.Infra.Data.Repository
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        public IEnumerable<Professor> PesquisarAtivos()
        {
            return Buscar(c => c.Ativo);
        }

        public Professor PesquisarPorCpf(string cpf)
        {
            return Buscar(c => c.Cpf == cpf).FirstOrDefault();
        }

        public Professor PesquisarPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        public override void Remover(Guid id)
        {
            var objRemove = ObterPorId(id);
            objRemove.Ativo = false;
            Atualizar(objRemove);
        }

        public override IEnumerable<Professor> ObterTodos()
        {
            return Db.Professores.OrderBy(c => c.DataCadastro);
        }
    }
}
