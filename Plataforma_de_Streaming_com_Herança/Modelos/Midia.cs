using System;
using Plataforma_de_Streaming_com_Herança.Modelos.Interfaces;
namespace Plataforma_de_Streaming_com_Herança.Modelos;

public abstract class Midia(string titulo, TimeSpan duracao, string genero) : INotificacao
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Titulo { get; set; } = titulo;
    public TimeSpan Duracao { get; set; } = duracao;
    public string Genero { get; set; } = genero;

    public virtual void Notificar(Midia midia)
    {
        Console.WriteLine($"Titulo: {Titulo} \nDuração: {Duracao:hh\\:mm} Gênero: {Genero}");
    }
    
    public abstract void ExibirResumo();

}
