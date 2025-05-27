using System;

namespace SistemaBiblioteca.Modelos;

public class Livro(string titulo, string autor)
{
    public string Titulo { get; set; } = titulo;
    public string Autor { get; set; } = autor;
    public bool Status { get; set; } = true;

    public override string ToString()
    {
        return $"{Titulo} - {Autor} - {(Status ? "Disponível" : "Emprestado")}";
    }
}
