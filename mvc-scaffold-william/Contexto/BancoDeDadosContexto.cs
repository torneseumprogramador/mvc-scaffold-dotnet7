using Microsoft.EntityFrameworkCore;
using mvc_scaffold_william.Models;

namespace mvc_scaffold_william.Contexto;

public class BancoDeDadosContexto : DbContext
{ 
    public BancoDeDadosContexto(DbContextOptions<BancoDeDadosContexto> options)
        : base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; } = default!;
    public DbSet<Curso> Cursos { get; set; } = default!;
    public DbSet<Matricula> Matriculas { get; set; } = default!;
}