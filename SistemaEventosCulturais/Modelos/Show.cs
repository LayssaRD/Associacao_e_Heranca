using System;

namespace SistemaEventosCulturais.Modelos
{
    public class Show : Evento
    {
        public string BandaArtista { get; set; }
        public string EstiloMusical { get; set; }
        public string ClassificacaoEtaria { get; set; }

        public Show(string titulo, DateTime data, string horario, string local, int capacidade, string bandaArtista, string estiloMusical, string classificacaoEtaria)
            : base(titulo, data, horario, local, capacidade)
        {
            BandaArtista = bandaArtista;
            EstiloMusical = estiloMusical;
            ClassificacaoEtaria = classificacaoEtaria;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Banda/Artista: {BandaArtista}");
            Console.WriteLine($"Estilo Musical: {EstiloMusical}");
            Console.WriteLine($"Classificação Etária: {ClassificacaoEtaria}");
        }
    }
} 