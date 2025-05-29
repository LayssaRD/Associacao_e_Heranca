using System;

namespace Plataforma_de_Streaming_com_Herança.Modelos;

public class Serie(string titulo, TimeSpan duracao, string genero, int temporadas)
    : Midia(titulo, duracao, genero)
{
    public int Temporadas { get; set; } = temporadas;
    public List<Episodio> Episodios { get; set; } = new();

    public void AdicionarEpisodio(Episodio ep) => Episodios.Add(ep);

    public override void ExibirResumo()
    {
        Console.WriteLine($"[Série] {Titulo} - {Temporadas} temporadas - {Episodios.Count} episódios");
        Console.WriteLine($"Duração total: {Duracao:hh\\:mm} | Gênero: {Genero}");
        Console.WriteLine("Episódios:");
        foreach (var ep in Episodios)
        {
            Console.WriteLine($"  Ep {ep.Numero}: {ep.Nome} ({ep.Duracao:hh\\:mm})");
        }
        Console.WriteLine();
    }
}

