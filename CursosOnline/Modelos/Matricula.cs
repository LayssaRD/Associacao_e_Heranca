using System;

namespace CursosOnline.Modelos;

public class Matricula(Aluno aluno, Curso curso, DateTime dataInscricao)
{
    public Aluno Aluno = aluno;
    public Curso Curso = curso;
    public DateTime DataInscricao = dataInscricao;

    public static void RealizarMatricula(Aluno aluno, Curso curso)
    {
        var matricula = new Matricula(aluno, curso, DateTime.Now);
        aluno.Matriculas.Add(matricula);
        Console.WriteLine($"Aluno {aluno.Nome} matriculado no curso \"{curso.NomeCurso}\" com sucesso.");
    }
}
