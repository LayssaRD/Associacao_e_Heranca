using System;
using AssociacaoHeranca.Modelos;

Aluno aluno = new("João Silva", "12345678900", new DateTime(2005, 3, 15), 1001, "Turma A");
Professor professor = new("Maria Oliveira", "98765432100", new DateTime(1980, 5, 20));
professor.Disciplinas.AddRange(new List<string> { "Matemática", "Física" });
Funcionario funcionario = new("Carlos Souza", "11122233344", new DateTime(1975, 8, 10), "Secretaria");

List<Pessoa> pessoas = new()
{
    aluno,
    professor,
    funcionario
};

Console.WriteLine("=== Lista de Notificações ===");
foreach (var pessoa in pessoas)
{
    pessoa.Notificar(pessoa);
}