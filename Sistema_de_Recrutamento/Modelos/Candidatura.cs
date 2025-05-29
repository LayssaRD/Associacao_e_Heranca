using System;

namespace Sistema_de_Recrutamento.Modelos;

public class Candidatura(Candidato candidato, Vaga vaga, DateTime data, string status)
{
    public Candidato Candidatos { get; set; } = candidato;
    public Vaga Vagas { get; set; } = vaga;
    public DateTime Data { get; set; } = data;
    public string Status { get; set; } = status;

    public override string ToString()
    {
        return $"{Candidatos.Nome} candidatou-se à vaga \"{Vagas.Cargo}\" em {Data:dd/MM/yyyy} - Status: {Status}";
    }
}
