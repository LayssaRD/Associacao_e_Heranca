using System;

namespace SistemaBiblioteca.Modelos;

public class Leitor(string nome)
{
    public string Nome { get; set; } = nome;
    public List<Emprestimo> Emprestimos { get; set; } = [];

    public void MostrarEmprestimos()
    {
        Console.WriteLine($"\nEmpréstimos de {Nome}:");
        foreach (var emprestimo in Emprestimos)
        {
            Console.WriteLine($"  Livro: {emprestimo.Livro.Titulo} | Data: {emprestimo.DataEmprestimo:dd/MM/yyyy}");
        }
    }
    
    public override string ToString()
    {
        return $"{Nome}";
    }
}
