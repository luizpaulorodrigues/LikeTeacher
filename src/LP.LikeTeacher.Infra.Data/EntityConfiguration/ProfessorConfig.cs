using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.LikeTeacher.Domain;
using LP.LikeTeacher.Domain.Entities;

namespace LP.LikeTeacher.Infra.Data.EntityConfiguration
{
    public class ProfessorConfig : EntityTypeConfiguration<Professor>
    {
        public ProfessorConfig()
        {
            HasKey(p => p.ProfessorID);                      

            Property(p => p.Cpf)
                 .IsRequired()
                 .HasMaxLength(11)
                 .IsFixedLength()
                 .HasColumnAnnotation("Index", new IndexAnnotation(
                     new IndexAttribute() { IsUnique = true }));

            Property(p => p.Rg)
                .IsRequired()
                .HasMaxLength(9)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute() { IsUnique = true }));

            Property(p => p.Nome)
                .IsRequired()               
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(p => p.Idade)
                .IsRequired();

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(p => p.Telefone)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnType("varchar");

            Property(p => p.Ativo)
                .IsRequired();

            Property(p => p.DataNascimento)
                .IsRequired()
                .HasColumnName("Data_Nascimento");

            Property(p => p.DataCadastro)
                .IsRequired()
                .HasColumnName("Data_Cadastro");

          ToTable("tb_professores");


            //para relacionamento N:N
            ///*Curso tem uma lista de Professores*/
            //HasMany(x => x.ProfessorLista)
            //    .WithMany(x => x.CursoLista) //...e professores uma lista de Cursos
            //    .Map(m => //esse relacionamento será mapeado em uma terceira tabela
            //    {
            //        m.MapLeftKey("CursoId"); //chave da esquerda será de CursoId
            //        m.MapRightKey("ProfessorId"); //Chave da direita será ProfessorId
            //        m.ToTable("CursoProfessor");// e o nome da tabela será CursoProfessor
            //    });

        }

    }
}
