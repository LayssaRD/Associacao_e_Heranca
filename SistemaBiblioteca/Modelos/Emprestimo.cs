using System;

namespace SistemaBiblioteca.Modelos;

public class Emprestimo
{
    public Livro Livro { get; set; }
    public Leitor Leitor { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }

    public Emprestimo(Livro livro, Leitor leitor, DateTime dataEmprestimo)
    {
        Livro = livro;
        Leitor = leitor;
        DataEmprestimo = dataEmprestimo;
    }

    public void RegistrarDevolucao()
    {
        Livro.Status = true;
        DataDevolucao = DateTime.Now;
    }

    public static void RealizarEmprestimo(Livro livro, Leitor leitor)
    {
        if (!livro.Status)
        {
            Console.WriteLine($"O livro {livro.Titulo} não está disponível");
            return;
        }
        var emprestimo = new Emprestimo(livro, leitor, DateTime.Now);
        leitor.Emprestimos.Add(emprestimo);
        livro.Status = false;
        Console.WriteLine($"Livro {livro.Titulo} emprestado com sucesso para o leitor: {leitor}");
    }
}
