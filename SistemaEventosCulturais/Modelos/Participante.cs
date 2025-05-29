using System;
using System.Collections.Generic;

namespace SistemaEventosCulturais.Modelos
{
    public class Participante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Evento> EventosInscritos { get; private set; }

        public Participante(string nome, string email)
        {
            Nome = nome;
            Email = email;
            EventosInscritos = new List<Evento>();
        }

        public void InscreverEmEvento(Evento evento)
        {
            if (!EventosInscritos.Contains(evento))
            {
                EventosInscritos.Add(evento);
                // A lógica de adicionar participante ao evento já é tratada em Evento.AdicionarParticipante
                // para evitar chamadas recursivas e garantir a consistência.
            }
        }

        public void CancelarInscricaoEvento(Evento evento)
        {
            EventosInscritos.Remove(evento);
            // A lógica de remover participante do evento já é tratada em Evento.RemoverParticipante.
        }

        public void ExibirEventosInscritos()
        {
            Console.WriteLine($"Eventos inscritos por {Nome} ({Email}):");
            if (EventosInscritos.Count == 0)
            {
                Console.WriteLine("Nenhum evento inscrito.");
                return;
            }
            foreach (var evento in EventosInscritos)
            {
                Console.WriteLine($"- {evento.Titulo} ({evento.Data.ToShortDateString()})");
            }
        }
    }
} 