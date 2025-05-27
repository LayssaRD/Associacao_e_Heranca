using System;

namespace CadastroEscolar.Modelos;

public class Aluno(string nome, string cpf, DateTime dataNascimento, int matricula, string turma) : Pessoa(nome, cpf, dataNascimento)
{
    public int Matricula { get; set; } = matricula;
    public string Turma { get; set; } = turma;

    public override void Notificar(Pessoa pessoa)
    {
        base.Notificar(pessoa);
        Console.WriteLine($"Matrícula: {Matricula} - Turma: {Turma}");
    }
}
