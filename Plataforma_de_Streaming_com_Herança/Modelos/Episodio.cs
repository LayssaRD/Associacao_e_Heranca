using System;

namespace Plataforma_de_Streaming_com_Herança.Modelos;

public class Episodio(string nome, int numero, TimeSpan duracao)
{
    public string Nome { get; set; } = nome;
    public int Numero { get; set; } = numero;
    public TimeSpan Duracao { get; set; } = duracao;
}
