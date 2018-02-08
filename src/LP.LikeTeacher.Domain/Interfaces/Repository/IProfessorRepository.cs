using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.LikeTeacher.Domain.Entities;

namespace LP.LikeTeacher.Domain.Interfaces.Repository
{
    interface IProfessorRepository
    {

        Professor ObterPorCpf(string cpf);
        Professor ObterPorCadeiras(int CadeiraId);
       
    }
}
