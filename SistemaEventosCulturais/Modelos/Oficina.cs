using System;

namespace SistemaEventosCulturais.Modelos
{
    public class Oficina : Evento
    {
        public string MaterialNecessario { get; set; }
        public int NumeroMaximoParticipantes { get; set; }

        public Oficina(string titulo, DateTime data, string horario, string local, int capacidade, string materialNecessario, int numeroMaximoParticipantes)
            : base(titulo, data, horario, local, capacidade)
        {
            MaterialNecessario = materialNecessario;
            NumeroMaximoParticipantes = numeroMaximoParticipantes;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Material Necessário: {MaterialNecessario}");
            Console.WriteLine($"Número Máximo de Participantes: {NumeroMaximoParticipantes}");
        }
    }
} 