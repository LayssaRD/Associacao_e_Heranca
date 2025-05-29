using System;

namespace SistemaEventosCulturais.Modelos
{
    public class Palestra : Evento
    {
        public string Palestrante { get; set; }
        public string Topico { get; set; }
        public string DuracaoPrevista { get; set; }

        public Palestra(string titulo, DateTime data, string horario, string local, int capacidade, string palestrante, string topico, string duracaoPrevista)
            : base(titulo, data, horario, local, capacidade)
        {
            Palestrante = palestrante;
            Topico = topico;
            DuracaoPrevista = duracaoPrevista;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Palestrante: {Palestrante}");
            Console.WriteLine($"Tópico: {Topico}");
            Console.WriteLine($"Duração Prevista: {DuracaoPrevista}");
        }
    }
} 