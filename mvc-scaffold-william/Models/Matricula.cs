namespace mvc_scaffold_william.Models;

public class Matricula{

    public int Id {get;set;}
    public Aluno Aluno {get;set;} = default!;
    public Curso Curso {get;set;} = default!;
    public DateTime DataMatricula {get;set;}
    public DateTime DataFormatura {get;set;}
}