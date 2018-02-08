using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using LP.LikeTeacher.Domain;
using LP.LikeTeacher.Domain.Entities;

namespace LP.LikeTeacher.Infra.Data.EntityConfiguration
{
    public class EnderecoConfig :EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            
            HasKey(e => e.EnderecoId);

            Property(e => e.Cep)
                .IsRequired();

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(e => e.Numero)
                .IsRequired();

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(e => e.Complemento)
                .HasMaxLength(200)
                .HasColumnType("varchar");

            HasRequired(e => e.Professor)
                .WithMany(s => s.Enderecos)
                .HasForeignKey(e => e.ProfessorId);

            ToTable("tb_enderecos");
                
                
        }

    }
}
