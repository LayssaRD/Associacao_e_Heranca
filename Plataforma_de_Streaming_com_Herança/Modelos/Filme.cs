using System;

namespace Plataforma_de_Streaming_com_Herança.Modelos;

public class Filme(string titulo, TimeSpan duracao, string genero, string diretor, int ano, List<string> elenco)
    : Midia(titulo, duracao, genero)
{
    public string Diretor { get; set; } = diretor;
    public int Ano { get; set; } = ano;
    public List<string> Elenco { get; set; } = elenco;

    public override void ExibirResumo()
    {
        Console.WriteLine($"[Filme] {Titulo} ({Ano})");
        Console.WriteLine($"Diretor: {Diretor}");
        Console.WriteLine($"Duração: {Duracao:hh\\:mm} | Gênero: {Genero}");
        Console.WriteLine($"Elenco: {string.Join(", ", Elenco)}\n");
    }
}
