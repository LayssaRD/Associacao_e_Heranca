using System;


namespace CadastroEscolar.Modelos;

public class Professor(string nome, string cpf, DateTime dataNascimento) : Pessoa(nome, cpf, dataNascimento)
{
    public List<string> Disciplinas { get; set; } = [];
    
    public override void Notificar(Pessoa pessoa)
    {
        base.Notificar(pessoa);
        Console.WriteLine($"Disciplinas: {string.Join(", ", Disciplinas)}");
    }
}
