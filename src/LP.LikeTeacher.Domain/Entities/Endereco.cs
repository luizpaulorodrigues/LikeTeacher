using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.LikeTeacher.Domain.Entities
{
    public class Endereco
    {
        public Endereco()
        {
            EnderecoId = new Guid();
        }
        public Guid EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }

        public Guid ProfessorId { get; set; }

        /// <summary>
        /// Sempre que definirmos uma propriedade de tipo não primitivo, 
        /// como uma classe definida por nós, é preciso usar a palavra reservada virtual. 
        /// Por meio dela o Entity Framework consegue preencher esse objeto em tempo de execução 
        /// usando reflection
        /// 
        /// 
        /// Para definir um relacionamento 1:N é adicionar do lado "N" uma propriedade do tipo "1".
        /// </summary>
        public virtual Professor Professor { get; set; }
        
    }
}
