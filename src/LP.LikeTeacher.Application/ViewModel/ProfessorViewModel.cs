using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LP.LikeTeacher.Domain.Entities;

namespace LP.LikeTeacher.Application.ViewModel
{
    public class ProfessorViewModel
    {

        public ProfessorViewModel()
        {
            ProfessorID = Guid.NewGuid();
            Enderecos = new List<EnderecoViewModel>();
           
        }
        [Key]
        public Guid ProfessorID { get; set; }

        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [MaxLength(100,ErrorMessage = "Máximo de {0} Caracteres.")]
        [MinLength(2,ErrorMessage = "Mínimo de {0} Caractres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é Obrigatório.")]
        [MaxLength(11, ErrorMessage = "Máximo de {0} Caracteres.")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo RG é Obrigatório.")]
        [MaxLength(8, ErrorMessage = "Máximo de {0} Caracteres.")]
        [DisplayName("RG")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "O campo Idade é Obrigatório")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "O campo E-mail é Obrigatório")]
        [MaxLength(100,ErrorMessage = "Máximo de {0} Caracteres.")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é Obrigatório")]
        public string Telefone { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public ICollection<EnderecoViewModel> Enderecos { get; set; }

     
       

    }
}
