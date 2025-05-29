using System;

namespace Sistema_de_Recrutamento.Modelos;

public class Candidato(string nome, string email, string curriculo)
{
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    public string Curriculo { get; set; } = curriculo;
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
         return $"Nome: {Nome} - Email: {Email}\n Curriculo: {Curriculo}";
    }
}
