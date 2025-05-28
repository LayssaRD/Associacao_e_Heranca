
using SistemaDeVendas.Modelos;

Produto produto1 = new("Notebook", 3500.00, 0001);
Produto produto2 = new("Mouse", 79.90, 0002);
Produto produto3 = new("Teclado", 149.50, 0003);

Console.WriteLine("===============Produtos===============");
Console.WriteLine($"{produto1}");
Console.WriteLine($"{produto2}");
Console.WriteLine($"{produto3}");

Pedido pedido = new();
pedido.AdicionarProduto(produto1, 1);
pedido.AdicionarProduto(produto2, 2);
pedido.AdicionarProduto(produto3, 1);

pedido.ExibirResumo();