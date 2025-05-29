using System.Collections.Generic;

namespace AplicativoControleTreinos.Modelos
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string ObjetivosFisicos { get; set; }
        public string MedidasCorporais { get; set; }
        public List<Treino> Treinos { get; private set; }

        public Aluno(string nome, int idade, string objetivosFisicos, string medidasCorporais)
        {
            Nome = nome;
            Idade = idade;
            ObjetivosFisicos = objetivosFisicos;
            MedidasCorporais = medidasCorporais;
            Treinos = new List<Treino>();
        }

        public void AdicionarTreino(Treino treino)
        {
            Treinos.Add(treino);
        }

        public void RemoverTreino(Treino treino)
        {
            Treinos.Remove(treino);
        }
    }
}
