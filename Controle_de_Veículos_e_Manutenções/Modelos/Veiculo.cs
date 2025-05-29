using System;

namespace Controle_de_Veículos_e_Manutenções.Modelos;

public class Veiculo(string modelo, string placa, string tipo)
{
    public string Modelo { get; set; } = modelo;
    public string Placa { get; set; } = placa;
    public string Tipo { get; set; } = tipo;
    public List<Manutencao> manutencoes = [];

    public void AdicionarManutencao(Manutencao manutencaoNova)
    {
        DateTime hoje = DateTime.Today;

        if (manutencaoNova.DataServico.Date < hoje)
        {
            Console.WriteLine($"Erro: A data precisa ser no mínimo {hoje.AddDays(1):dd/MM/yyyy}.");
            return;
        }

        if (manutencoes.Any(manutencaoPresente => manutencaoPresente.DataServico.Date == manutencaoNova.DataServico.Date))
        {
            Console.WriteLine($"\nErro: já existe manutenção para {Placa} em {manutencaoNova.DataServico:dd/MM/yyyy}.");
            return;
        }

        manutencoes.Add(manutencaoNova);
    }
    public void ListarManutencoes()
    {
        Console.WriteLine($"\nManutenções do veículo {Placa} ({Modelo}):");
        foreach (var manutencao in manutencoes)
        {
            Console.WriteLine(manutencao);
        }
    }
}

