namespace Academico2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Banco : DbContext
    {
        public Banco()
            : base("name=Banco")
        {
        }

        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.CPF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.Telefone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .Property(e => e.Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Professor>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Professor>()
                .Property(e => e.Cpf)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Professor>()
                .Property(e => e.Biografia)
                .IsUnicode(false);
        }
    }
}
