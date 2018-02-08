using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace LP.LikeTeacher.Application.ViewModel
{
    public class ProfessorEnderecoViewModel
    {

        public ProfessorEnderecoViewModel()
        {
            ProfessorID = Guid.NewGuid();
            EnderecoId = Guid.NewGuid();
        }

        #region Professor

        [Key]
        public Guid ProfessorID { get; set; }

        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} Caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} Caractres.")]
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
        [DisplayName("Idade")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "O campo E-mail é Obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} Caracteres.")]
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

        public virtual ICollection<Endereco> Enderecos { get; set; }

        #endregion

        #region Endereço
        [Key]
        public Guid EnderecoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP")]
        [MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Numero")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Estado")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Estado { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Complemento { get; set; }

       


        #endregion



    }
}
