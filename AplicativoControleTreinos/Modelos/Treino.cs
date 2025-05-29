using System;
using System.Collections.Generic;
using System.Linq;

namespace AplicativoControleTreinos.Modelos;

public class Treino
{
    public DateTime DataCriacao { get; set; }
    public string Objetivo { get; set; }
    public List<Exercicio> Exercicios { get; private set; }

    public Treino(DateTime dataCriacao, string objetivo)
    {
        DataCriacao = dataCriacao;
        Objetivo = objetivo;
        Exercicios = new List<Exercicio>();
    }

    public void AdicionarExercicio(Exercicio exercicio)
    {
        Exercicios.Add(exercicio);
    }

    public void RemoverExercicio(Exercicio exercicio)
    {
        Exercicios.Remove(exercicio);
    }

    public double CalcularCargaTotal()
    {
        return Exercicios.Sum(e => e.NumeroSeries * e.RepeticoesPorSerie * e.Carga);
    }
}
