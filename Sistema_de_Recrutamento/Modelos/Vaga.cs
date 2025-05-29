using System;

namespace Sistema_de_Recrutamento.Modelos;

public class Vaga(string cargo, string empresa, string descricao)
{
    public string Cargo { get; set; } = cargo;
    public string Empresa { get; set; } = empresa;
    public string Descricao { get; set; } = descricao;
    public List<Candidatura> Candidaturas { get; set; } = [];

    public void AdicionarCandidatura(Candidatura candidatura)
    {
        if (!Candidaturas.Contains(candidatura))
        {
           Candidaturas.Add(candidatura);
        }
    }
    public override string ToString()
    {
        return $"Cargo: {Cargo} - Empresa: {Empresa} - Descrição: {Descricao}";
    }
}
