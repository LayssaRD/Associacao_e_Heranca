using System;

namespace SistemaDeVendas.Modelos;

public class ItemPedido(Produto produto, int quantidade)
{
    public Produto Produto { get; set; } = produto;
    public int Quantidade { get; set; } = quantidade;
    public double Subtotal = quantidade * produto.Preco;
    
    public override string ToString()
    {
        return $"{Produto.Nome} x {Quantidade} = R$ {Subtotal:F2}";
    }
}
