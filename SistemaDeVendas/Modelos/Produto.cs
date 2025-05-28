using System;

namespace SistemaDeVendas.Modelos;

public class Produto(string nome, double preco, int codigo)
{
    public string Nome { get; set; } = nome;
    public double Preco { get; set; } = preco;
    public int Codigo { get; set; } = codigo;

    public override string ToString()
    {
        return $"Nome: {Nome} - Preço: R${Preco:F2}";
    }
}
