using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LP.LikeTeacher.Domain.Entities
{
    public class Professor
    {
        public Professor()
        {
            ProfessorID = new Guid();
            Enderecos = new List<Endereco>();
        }
        public Guid ProfessorID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }


        /// <summary>
        /// definir um relacionamento 1:N é adicionar no lado "1" uma coleção de objetos do tipo "N".
        /// </summary>
        public virtual ICollection<Endereco> Enderecos { get; set; }
    

    }
}
