using System;

namespace CursosOnline.Modelos;

public class Aluno(string nome)
{
    public string Nome { get; set; } = nome;
    public List<Matricula> Matriculas { get; set; } = [];

    public void MostrarCursos()
    {
        Console.WriteLine($"\nCursos do aluno: {Nome}");
        foreach (var matricula in Matriculas)
        {
            Console.WriteLine($"  - {matricula.Curso.NomeCurso}");
        }
    }
}
