using System;

namespace SistemaDeVendas.Modelos;

public class Pedido
{
    public List<ItemPedido> Itens { get; set; } = [];

    public void AdicionarProduto(Produto produto, int quantidade)
    {
        Itens.Add(new ItemPedido(produto, quantidade));
    }

    public double CalcularTotal()
    {
        return Itens.Sum(item => item.Subtotal);
    }

    public void ExibirResumo()
    {
        Console.WriteLine("\nResumo do Pedido:");
        foreach (var item in Itens)
        {
            Console.WriteLine($"  - {item}");
        }
        Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
    }
}
