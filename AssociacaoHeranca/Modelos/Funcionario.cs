using System;


namespace CadastroEscolar.Modelos;

public class Funcionario(string nome, string cpf, DateTime dataNascimento, string setor) : Pessoa(nome, cpf, dataNascimento)
{
    public string Setor { get; set; } = setor;
    
    public override void Notificar(Pessoa pessoa)
    {
        base.Notificar(pessoa);
        Console.WriteLine($"Setor: {Setor}");
    }
}
