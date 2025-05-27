using System;

namespace CursosOnline.Modelos;

public class Curso(string nomeCurso)
{
    public string NomeCurso { get; set; } = nomeCurso;
    public List<Aula> Aulas { get; set; } = [];

    public void AdicionarAula(Aula aula)
    {
        Aulas.Add(aula);
    }

    public void MostrarAulas()
    {
        Console.WriteLine($"\nAulas do curso: {NomeCurso}");
        foreach (var aula in Aulas)
        {
            Console.WriteLine($"  - {aula.Descricao} ({aula.Duracao} min) | Professor: {aula.Professor}");
        }
    }
}
