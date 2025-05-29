using System;
using AplicativoControleTreinos.Modelos;

namespace AplicativoControleTreinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Carlos Silva", 30, "Hipertrofia", "Peito: 100cm, Braço: 35cm");

            Treino treinoA = new Treino(DateTime.Now, "Treino de Peito e Tríceps");

            treinoA.AdicionarExercicio(new Exercicio("Supino Reto", 3, 10, 80));
            treinoA.AdicionarExercicio(new Exercicio("Crucifixo Reto", 3, 12, 20));
            treinoA.AdicionarExercicio(new Exercicio("Tríceps Pulley", 4, 15, 25));

            aluno1.AdicionarTreino(treinoA);

            Console.WriteLine($"Aluno: {aluno1.Nome}");
            Console.WriteLine($"Objetivo: {aluno1.ObjetivosFisicos}");
            Console.WriteLine("Treinos:");
            foreach (var treino in aluno1.Treinos)
            {
                Console.WriteLine($"  - {treino.Objetivo} (Criado em: {treino.DataCriacao.ToShortDateString()})");
                Console.WriteLine("    Exercícios:");
                foreach (var exercicio in treino.Exercicios)
                {
                    Console.WriteLine($"      - {exercicio.Nome}: {exercicio.NumeroSeries}x{exercicio.RepeticoesPorSerie} com {exercicio.Carga}kg");
                }
                Console.WriteLine($"    Carga Total do Treino: {treino.CalcularCargaTotal()}kg");
            }
        }
    }
}
