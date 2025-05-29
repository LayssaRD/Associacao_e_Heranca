using System;

namespace Controle_de_Veículos_e_Manutenções.Modelos;

public class Manutencao(DateTime dataservico, string descricao, string tipo)
{
    public DateTime DataServico { get; set; } = dataservico;
    public string Descricao { get; set; } = descricao;
    public string Tipo { get; set; } = tipo;

    public override string ToString()
    {
        return $"{DataServico:dd/MM/yyyy} - {Tipo}: {Descricao}";
    }
}
