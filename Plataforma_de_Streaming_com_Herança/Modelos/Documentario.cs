using System;

namespace Plataforma_de_Streaming_com_Herança.Modelos;

public class Documentario(string titulo, TimeSpan duracao, string genero, string tema, string narrador)
    : Midia(titulo, duracao, genero)
{
    public string Tema { get; set; } = tema;
    public string Narrador { get; set; } = narrador;

    public override void ExibirResumo()
    {
        Console.WriteLine($"[Documentário] {Titulo}");
        Console.WriteLine($"Tema: {Tema} | Narrador: {Narrador}");
        Console.WriteLine($"Duração: {Duracao:hh\\:mm} | Gênero: {Genero}\n");
    }
}
