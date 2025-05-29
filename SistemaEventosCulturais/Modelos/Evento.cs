using System;
using System.Collections.Generic;

namespace SistemaEventosCulturais.Modelos
{
    public class Evento
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public string Local { get; set; }
        public int Capacidade { get; set; }
        public List<Participante> ParticipantesInscritos { get; private set; }

        public Evento(string titulo, DateTime data, string horario, string local, int capacidade)
        {
            Titulo = titulo;
            Data = data;
            Horario = horario;
            Local = local;
            Capacidade = capacidade;
            ParticipantesInscritos = new List<Participante>();
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Data: {Data.ToShortDateString()}");
            Console.WriteLine($"Horário: {Horario}");
            Console.WriteLine($"Local: {Local}");
            Console.WriteLine($"Capacidade: {Capacidade}");
        }

        public bool AdicionarParticipante(Participante participante)
        {
            if (ParticipantesInscritos.Count < Capacidade)
            {
                ParticipantesInscritos.Add(participante);
                participante.InscreverEmEvento(this); // Mantém a consistência da relação bidirecional
                return true;
            }
            Console.WriteLine($"Não foi possível inscrever {participante.Nome}, capacidade máxima atingida para o evento {Titulo}.");
            return false;
        }

        public void RemoverParticipante(Participante participante)
        {
            ParticipantesInscritos.Remove(participante);
            participante.CancelarInscricaoEvento(this); // Mantém a consistência da relação bidirecional
        }
    }
} 