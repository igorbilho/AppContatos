namespace AppContatos.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContatosModel : DbContext
    {
        public ContatosModel()
            : base("name=ContatosModel")
        {
        }

        public virtual DbSet<pessoa> pessoa { get; set; }
        public virtual DbSet<telefone> telefone { get; set; }
        public virtual DbSet<email> email { get; set; }
        public virtual DbSet<endereco> endereco { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<pessoa>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.telefone)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<telefone>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<telefone>()
                .Property(e => e.ddi)
                .IsUnicode(false);

            modelBuilder.Entity<telefone>()
                .Property(e => e.ddd)
                .IsUnicode(false);

            modelBuilder.Entity<telefone>()
                .Property(e => e.telefone1)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.email)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<email>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<email>()
                .Property(e => e.email1)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.endereco)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.endereco1)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.complemento)
                .IsUnicode(false);
        }
    }
}
