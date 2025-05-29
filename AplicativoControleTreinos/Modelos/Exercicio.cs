using System;

namespace AplicativoControleTreinos.Modelos;

public class Exercicio
{
    public string Nome { get; set; }
    public int NumeroSeries { get; set; }
    public int RepeticoesPorSerie { get; set; }
    public double Carga { get; set; }

    public Exercicio(string nome, int numeroSeries, int repeticoesPorSerie, double carga)
    {
        Nome = nome;
        NumeroSeries = numeroSeries;
        RepeticoesPorSerie = repeticoesPorSerie;
        Carga = carga;
    }
}
