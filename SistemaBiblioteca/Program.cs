using SistemaBiblioteca.Modelos;

var livro1 = new Livro("Dom Casmurro", "Machado de Assis");
var livro2 = new Livro("O Pequeno Príncipe", "Saint-Exupéry");
var livro3 = new Livro("O Temor do Sábio", "Patrick Rothfuss");
var livro4 = new Livro("O Nome do Vento", "Patrick Rothfuss");
var leitor1 = new Leitor("Layssa Alves");
var leitor2 = new Leitor("Lorena Mendes");

Emprestimo.RealizarEmprestimo(livro1, leitor1);
Emprestimo.RealizarEmprestimo(livro2, leitor1);
Emprestimo.RealizarEmprestimo(livro3, leitor2);
Emprestimo.RealizarEmprestimo(livro1, leitor2);

Console.WriteLine("\n=== Situação dos livros ===");
Console.WriteLine(livro1);
Console.WriteLine(livro2);
Console.WriteLine(livro3);
Console.WriteLine(livro4);

Console.WriteLine("\n=== Empréstimos do leitor ===");
leitor1.MostrarEmprestimos();
leitor2.MostrarEmprestimos();


