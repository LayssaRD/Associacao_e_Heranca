using CadastroEscolar.Modelos.Interfaces;

namespace CadastroEscolar.Modelos;

public abstract class Pessoa(string nome, string cpf, DateTime dataNascimento) : INotificacao
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; set; } = nome;
    public string CPF { get; set; } = cpf;
    public DateTime DataNascimento { get; set; } = dataNascimento;

    public virtual void Notificar(Pessoa pessoa)
    {
        Console.WriteLine($"Nome: {Nome} - CPF: {CPF} - Data de Nascimento: {DataNascimento}");
    }
}
