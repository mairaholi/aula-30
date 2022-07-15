using Microsoft.EntityFrameworkCore;

namespace aula_30.Models
{
    public class Escola : DbContext
    {
        public Escola(DbContextOptions<Escola> options) : base(options)
        {
        }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Instituicao>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Aluno>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Instituicao>()
                .HasMany(x => x.Alunos) 
                .WithOne(x => x.Instituicao)
                .HasForeignKey(x => x.InstituicaoId);

        }
    }
}
