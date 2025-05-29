using System;
using SistemaEventosCulturais.Modelos;

namespace SistemaEventosCulturais
{
    class Program
    {
        static void Main(string[] args)
        {
            Oficina oficinaDePintura = new Oficina(
                "Oficina de Pintura Abstrata",
                new DateTime(2024, 8, 10),
                "14:00",
                "Sala de Artes Visuais",
                15,
                "Tintas acrílicas, pincéis, telas",
                15
            );

            Palestra palestraIA = new Palestra(
                "Inteligência Artificial na Música",
                new DateTime(2024, 8, 15),
                "19:00",
                "Auditório Principal",
                100,
                "Dra. Ada Lovelace",
                "Como a IA está transformando a criação e consumo musical",
                "1 hora e 30 minutos"
            );

            Show showDeRock = new Show(
                "Show da Banda Rock Alternativo",
                new DateTime(2024, 8, 20),
                "21:00",
                "Arena Externa",
                500,
                "Os Alternativos",
                "Rock Alternativo",
                "16 anos"
            );

            Participante participante1 = new Participante("Carlos Pereira", "carlos.p@email.com");
            Participante participante2 = new Participante("Ana Beatriz", "ana.b@email.com");
            Participante participante3 = new Participante("Lucas Mendes", "lucas.m@email.com");

            oficinaDePintura.AdicionarParticipante(participante1);
            oficinaDePintura.AdicionarParticipante(participante2);

            palestraIA.AdicionarParticipante(participante1);
            palestraIA.AdicionarParticipante(participante3);

            showDeRock.AdicionarParticipante(participante2);
            showDeRock.AdicionarParticipante(participante3);
            showDeRock.AdicionarParticipante(participante1);

            Console.WriteLine("--- DETALHES DOS EVENTOS ---");
            oficinaDePintura.ExibirInformacoes();
            Console.WriteLine("\nParticipantes Inscritos:");
            foreach (var p in oficinaDePintura.ParticipantesInscritos)
            {
                Console.WriteLine($"- {p.Nome}");
            }
            Console.WriteLine("----------------------------\n");

            palestraIA.ExibirInformacoes();
            Console.WriteLine("\nParticipantes Inscritos:");
            foreach (var p in palestraIA.ParticipantesInscritos)
            {
                Console.WriteLine($"- {p.Nome}");
            }
            Console.WriteLine("----------------------------\n");

            showDeRock.ExibirInformacoes();
            Console.WriteLine("\nParticipantes Inscritos:");
            foreach (var p in showDeRock.ParticipantesInscritos)
            {
                Console.WriteLine($"- {p.Nome}");
            }
            Console.WriteLine("----------------------------\n");

            Console.WriteLine("--- EVENTOS POR PARTICIPANTE ---");
            participante1.ExibirEventosInscritos();
            Console.WriteLine("----------------------------");
            participante2.ExibirEventosInscritos();
            Console.WriteLine("----------------------------");
            participante3.ExibirEventosInscritos();
            Console.WriteLine("----------------------------");

            Console.WriteLine("\n--- TESTE DE REMOÇÃO ---");
            Console.WriteLine($"Removendo {participante1.Nome} da {oficinaDePintura.Titulo}...");
            oficinaDePintura.RemoverParticipante(participante1);
            oficinaDePintura.ExibirInformacoes(); // Mostrar que a capacidade não mudou, mas o participante sim
            Console.WriteLine("\nParticipantes Inscritos na Oficina após remoção:");
            foreach (var p in oficinaDePintura.ParticipantesInscritos)
            {
                Console.WriteLine($"- {p.Nome}");
            }
            Console.WriteLine("Eventos de Carlos após cancelamento da oficina:");
            participante1.ExibirEventosInscritos();
            Console.WriteLine("----------------------------\n");

            Console.WriteLine("--- TESTE DE CAPACIDADE MÁXIMA ---");
            Evento eventoTesteCapacidade = new Evento("Teste Capacidade", DateTime.Now, "10:00", "Sala Teste", 1);
            Participante pTeste1 = new Participante("Teste User 1", "t1@email.com");
            Participante pTeste2 = new Participante("Teste User 2", "t2@email.com");

            Console.WriteLine($"Tentando inscrever {pTeste1.Nome}...");
            eventoTesteCapacidade.AdicionarParticipante(pTeste1);
            Console.WriteLine($"Participantes inscritos: {eventoTesteCapacidade.ParticipantesInscritos.Count}");

            Console.WriteLine($"\nTentando inscrever {pTeste2.Nome}...");
            eventoTesteCapacidade.AdicionarParticipante(pTeste2); // Deve falhar e exibir mensagem
            Console.WriteLine($"Participantes inscritos: {eventoTesteCapacidade.ParticipantesInscritos.Count}");
            Console.WriteLine("----------------------------");
        }
    }
}
